using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Response
{
    public class TransactionResponse
    {
        [JsonProperty("fx")]
        public FXInformation[] FxInformations { get; set; }

        [JsonProperty("customerInfo")]
        public CustomerInfo[] CustomerInfos { get; set; }

        [JsonProperty("acquirerTransactions")]
        public Acquirer[] AcquirerTransactions { get; set; }

        [JsonProperty("merchant")]
        public Merchant Merchants { get; set; }

        [JsonProperty("merchantTransactions")]
        public MerchantTransaction[] merchantTransactions { get; set; }
    }

    public class FXInformation
    {
        [JsonProperty("originalAmount")]
        public decimal OriginalAmount { get; set; }

        [JsonProperty("originalCurrency")]
        public string OriginalCurrency { get; set; }
    }

    public class Acquirer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class MerchantTransaction
    {
        [JsonProperty("referenceNo")]
        public string ReferenceNo { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}