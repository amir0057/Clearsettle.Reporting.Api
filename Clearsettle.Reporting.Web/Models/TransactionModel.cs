using System.ComponentModel;
using Newtonsoft.Json;

namespace Clearsettle.Reporting.Web.Models
{
    public class TransactionModel
    {
        [JsonProperty("fx")]
        public Fx FX { get; set; }

        [JsonProperty("customerInfo")]
        public ClientModel CustomerInfo { get; set; }

        [JsonProperty("merchant")]
        public TransactionMerchantInfo MerchantInfo { get; set; }

        [JsonProperty("transaction")]
        public MerchantTransaction merchantTransactions { get; set; }
    }

    public class Fx
    {
        [JsonProperty("merchant")]
        public FXMerchant FxMerchant { get; set; }
    }

    public class TransactionMerchantInfo
    {
        [DisplayName("name")]
        public string Name { get; set; }
    }

    public class FXMerchant
    {
        [DisplayName("originalAmount")]
        public int OriginalAmount { get; set; }

        [DisplayName("originalCurrency")]
        public string OriginalCurrency { get; set; }
    }

    public class MerchantTransaction
    {
        [JsonProperty("merchant")]
        public MerchantTransactionMerchant MerchantInfo { get; set; }
    }

    public class MerchantTransactionMerchant
    {
        [DisplayName("referenceNo")]
        public string ReferenceNo { get; set; }

        [DisplayName("status")]
        public string Status { get; set; }

        [DisplayName("merchantId")]
        public string merchantId { get; set; }

        [DisplayName("channel")]
        public string channel { get; set; }

        [DisplayName("customData")]
        public string customData { get; set; }

        [DisplayName("chainId")]
        public string chainId { get; set; }

        [DisplayName("agentInfoId")]
        public string agentInfoId { get; set; }

        [DisplayName("operation")]
        public string operation { get; set; }

        [DisplayName("fxTransactionId")]
        public string fxTransactionId { get; set; }

        [DisplayName("updated_at")]
        public string updated_at { get; set; }

        [DisplayName("created_at")]
        public string created_at { get; set; }

        [DisplayName("id")]
        public int id { get; set; }

        [DisplayName("acquirerTransactionId")]
        public string acquirerTransactionId { get; set; }

        [DisplayName("code")]
        public string code { get; set; }

        [DisplayName("message")]
        public string message { get; set; }

        [DisplayName("transactionId")]
        public string transactionId { get; set; }

        [JsonProperty("agent")]
        public TransactionAgent Agent { get; set; }
    }

    public class TransactionAgent
    {
        [DisplayName("id")]
        public int Id { get; set; }

        [DisplayName("customerIp")]
        public string CustomerIp { get; set; }

        [DisplayName("customerUserAgent")]
        public string CustomerUserAgent { get; set; }

        [DisplayName("merchantIp")]
        public string MerchantIp { get; set; }

        [DisplayName("updated_at")]
        public string UpdatedAt { get; set; }

        [DisplayName("merchantUserAgent")]
        public string MerchantUserAgent { get; set; }

        [DisplayName("deleted_at")]
        public string DeletedAt { get; set; }

        [DisplayName("created_at")]
        public string CreatedAt { get; set; }
    }
}