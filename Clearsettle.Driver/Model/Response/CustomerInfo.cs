using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Response
{
    public class CustomerInfo
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("billingFirstName")]
        public string BillingFirstName { get; set; }
    }
}