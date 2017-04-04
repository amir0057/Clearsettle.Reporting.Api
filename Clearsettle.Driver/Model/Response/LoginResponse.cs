using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Response
{
    public class LoginResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}