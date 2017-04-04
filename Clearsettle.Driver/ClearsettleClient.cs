using System;
using System.Net.Http;
using System.Threading.Tasks;
using Clearsettle.Driver.Model.Request;
using Clearsettle.Driver.Model.Response;
using Newtonsoft.Json;

namespace Clearsettle.Driver
{
    public class ClearsettleClient
    {
        readonly ClearsettleConfiguration configuration;
        const string ActionLogin = "merchant/user/login";
        const string ActionReport = "transactions/report";
        const string ActionTransactionList = "transaction/list";
        const string ActionTransaction = "transaction";
        const string ActionClient = "client";
        const string ActionMerchant = "merchant";
        private HttpClient httpClient;
        private string _token;
        private DateTime _tokenExpireTime;

        private string Token
        {
            get
            {
                if (NeedFreshToken())
                {
                    _token = Login().Result;
                    _tokenExpireTime = DateTime.Now.AddMinutes(10);
                }
                return _token;
            }
        }

        private bool NeedFreshToken()
        {
            return _token == null || _tokenExpireTime < DateTime.Now;
        }

        public ClearsettleClient(ClearsettleConfiguration config)
        {
            configuration = config;
            httpClient = new HttpClient();
        }

        public HttpClient HttpClient(bool withAuthorization)
        {
            httpClient.DefaultRequestHeaders.Clear();

            if (!withAuthorization)
                return httpClient;

            httpClient.DefaultRequestHeaders.Add("Authorization", Token);
            return httpClient;
        }

        public async Task<string> Login()
        {
            var request = new LoginRequest
            {
                Email = configuration.Email,
                Password = configuration.Password
            };
            var response = await MakePostApiCall<LoginResponse>(ActionLogin, request, false);
            return response.Token;
        }

        public async Task<Merchant> GetMerchant(MerchentRequest request)
        {
            return await MakePostApiCall<Merchant>(ActionMerchant, request);
        }

        public async Task<ReportResponse> GetReport(ReportRequest request)
        {
            return await MakePostApiCall<ReportResponse>(ActionReport, request);
        }

        public async Task<TransactionResponse> GetTransaction(TransactionRequest request)
        {
            return await MakePostApiCall<TransactionResponse>(ActionTransaction, request);
        }

        public async Task<TransactionListResponse> GetTransactionList(TransactionListRequest request)
        {
            return await MakePostApiCall<TransactionListResponse>(ActionTransactionList, request);
        }

        async Task<T> MakePostApiCall<T>(string method, object data, bool withAuthorization = true)
        {
            try
            {
                var uri = configuration.BuildUrlFor(method);
                var result = await HttpClient(withAuthorization).PostAsJsonAsync(uri, data);
                return Deserialize<T>(await result.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        T Deserialize<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data, _serializerSettings);
        }

        readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            CheckAdditionalContent = false
        };
    }
}