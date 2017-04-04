using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Request
{
    public class ClientRequest
    {
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }
}