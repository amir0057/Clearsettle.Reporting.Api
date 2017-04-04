using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Request
{
    public class TransactionRequest
    {
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }
}