using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Response
{
    public class ReportResponse
    {
        [JsonProperty("response")]
        public report[] Report { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class report
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}