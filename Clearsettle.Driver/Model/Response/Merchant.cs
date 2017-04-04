using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Response
{
    public class Merchant
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}