using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Response
{
    public class MerchantResponse
    {
        [JsonProperty("merchant")]
        public Merchant Merchant { get; set; }
    }

    public class Merchant
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("3dStatus")]
        public string Status3D { get; set; }

        [JsonProperty("mcc")]
        public string Mcc { get; set; }

        [JsonProperty("ipnUrl")]
        public string IpnUrl { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("cpgKey")]
        public string CpgKey { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("descriptor")]
        public string Descriptor { get; set; }

        [JsonProperty("secretKey")]
        public string SecretKey { get; set; }

        [JsonProperty("comType")]
        public string ComType { get; set; }
    }
}