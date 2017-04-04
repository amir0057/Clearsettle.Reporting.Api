using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Request
{
    public class MerchentRequest
    {
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }
}