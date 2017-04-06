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
        const int TokenExpiredInMinute = 10;
        HttpClient httpClient;
        string _token;
        DateTime _tokenExpireTime;


        private async Task<string> GetToken()
        {
            if (NeedFreshToken())
            {
                _token = await Login();
                _tokenExpireTime = DateTime.Now.AddMinutes(TokenExpiredInMinute);
            }
            return _token;
        }

        public ClearsettleClient(ClearsettleConfiguration config)
        {
            configuration = config;
            httpClient = new HttpClient();
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

        public async Task<MerchantResponse> GetMerchant(MerchentRequest request)
        {
            return await MakePostApiCall<MerchantResponse>(ActionMerchant, request);
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

        public async Task<CustomerInfoResponse> GetClient(ClientRequest request)
        {
            return await MakePostApiCall<CustomerInfoResponse>(ActionClient, request);
        }

        async Task<T> MakePostApiCall<T>(string method, object data, bool withAuthorization = true)
        {
            if (withAuthorization)
                await AddAuthorization();

            var uri = configuration.BuildUrlFor(method);
            var result = await httpClient.PostAsJsonAsync(uri, data);
            return Deserialize<T>(await result.Content.ReadAsStringAsync());
        }

        private async Task AddAuthorization()
        {
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Authorization", await GetToken());
        }

        T Deserialize<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data, _serializerSettings);
        }

        readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            CheckAdditionalContent = false
        };

        private bool NeedFreshToken()
        {
            return _token == null || _tokenExpireTime < DateTime.Now;
        }
    }
}