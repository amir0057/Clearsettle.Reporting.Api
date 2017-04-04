using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Response
{
    public class TransactionResponse
    {
        [JsonProperty("fx")]
        public Fx FX { get; set; }

        [JsonProperty("customerInfo")]
        public CustomerInfo CustomerInfo { get; set; }

        [JsonProperty("merchant")]
        public Merchant MerchantInfo { get; set; }

        [JsonProperty("transaction")]
        public MerchantTransaction merchantTransactions { get; set; }

        public class Fx
        {
            [JsonProperty("merchant")]
            public FXMerchant FxMerchant { get; set; }
        }

        public class Merchant
        {
            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class FXMerchant
        {
            [JsonProperty("originalAmount")]
            public int OriginalAmount { get; set; }

            [JsonProperty("originalCurrency")]
            public string OriginalCurrency { get; set; }
        }

        public class MerchantTransaction
        {
            [JsonProperty("merchant")]
            public Merchant MerchantInfo { get; set; }

            public class Merchant
            {
                [JsonProperty("referenceNo")]
                public string ReferenceNo { get; set; }

                [JsonProperty("status")]
                public string Status { get; set; }

                [JsonProperty("merchantId")]
                public string merchantId { get; set; }

                [JsonProperty("channel")]
                public string channel { get; set; }

                [JsonProperty("customData")]
                public string customData { get; set; }

                [JsonProperty("chainId")]
                public string chainId { get; set; }

                [JsonProperty("agentInfoId")]
                public string agentInfoId { get; set; }

                [JsonProperty("operation")]
                public string operation { get; set; }

                [JsonProperty("fxTransactionId")]
                public string fxTransactionId { get; set; }

                [JsonProperty("updated_at")]
                public string updated_at { get; set; }

                [JsonProperty("created_at")]
                public string created_at { get; set; }

                [JsonProperty("id")]
                public int id { get; set; }

                [JsonProperty("acquirerTransactionId")]
                public string acquirerTransactionId { get; set; }

                [JsonProperty("code")]
                public string code { get; set; }

                [JsonProperty("message")]
                public string message { get; set; }

                [JsonProperty("transactionId")]
                public string transactionId { get; set; }

                [JsonProperty("agent")]
                public Agent Agent { get; set; }
            }

            public class Agent
            {
                [JsonProperty("id")]
                public int Id { get; set; }
                [JsonProperty("customerIp")]
                public string CustomerIp { get; set; }
                [JsonProperty("customerUserAgent")]
                public string CustomerUserAgent { get; set; }
                [JsonProperty("merchantIp")]
                public string MerchantIp { get; set; }
                
                [JsonProperty("updated_at")]
                public string UpdatedAt { get; set; }
                [JsonProperty("merchantUserAgent")]
                public string MerchantUserAgent { get; set; }
                [JsonProperty("deleted_at")]
                public string DeletedAt { get; set; }
                [JsonProperty("created_at")]
                public string CreatedAt { get; set; }
            }
        }
    }
}