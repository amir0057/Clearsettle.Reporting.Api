using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Clearsettle.Driver;
using Clearsettle.Driver.Model.Builder;
using Clearsettle.Driver.Model.Request;
using Clearsettle.Reporting.Web.Models;
using Newtonsoft.Json;
using System;

namespace Clearsettle.Reporting.Web
{
    public class ClearsettleApiService
    {
        static ClearsettleClient _clearsettleClient;
        public static ClearsettleClient ClearsettleClient
        {
            get
            {
                if (_clearsettleClient == null)
                    _clearsettleClient =
                        new ClearsettleClient(ClearsettleConfiguration.FromDictionary(ApplicationSettings));

                return _clearsettleClient;
            }
        }

        public static async Task<ReportModel> GetReport(DateTime fromDate, DateTime toDate)
        {
            var response = await ClearsettleClient.GetReport(ReportRequestBuilder.Create().FromDate(fromDate).ToDate(toDate).Build());
            return JsonConvert.DeserializeObject<ReportModel>(JsonConvert.SerializeObject(response, Formatting.None));
        }

        public static async Task<TransactionModel> GetTransaction(string transactionId)
        {
            var response = await ClearsettleClient.GetTransaction(new TransactionRequest { TransactionId = transactionId });
            return JsonConvert.DeserializeObject<TransactionModel>(JsonConvert.SerializeObject(response, Formatting.None));
        }

        public static async Task<MerchantModel> GetMerchant(string transactionId)
        {
            var response = await ClearsettleClient.GetMerchant(new MerchentRequest { TransactionId = transactionId });
            return JsonConvert.DeserializeObject<MerchantModel>(JsonConvert.SerializeObject(response.Merchant));
        }

        public static async Task<ClientModel> GetClient(string transactionId)
        {
            var response = await ClearsettleClient.GetClient(new ClientRequest { TransactionId = transactionId });
            return JsonConvert.DeserializeObject<ClientModel>(JsonConvert.SerializeObject(response.CustomerInfo));
        }
        static Dictionary<string, string> ApplicationSettings
        {
            get
            {
                return ConfigurationManager
                    .AppSettings
                    .AllKeys
                    .ToDictionary(x => x,
                        x =>
                            ConfigurationManager
                                .AppSettings[x]
                    );
            }
        }
    }
}