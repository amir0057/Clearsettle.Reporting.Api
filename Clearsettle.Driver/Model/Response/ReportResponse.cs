using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Response
{
    public class ReportResponse
    {
        public string Status { get; set; }
        public ResponseData[] Response { get; set; }

        public class ResponseData
        {
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("total")]
            public int Total { get; set; }

            [JsonProperty("currency")]
            public string Currency { get; set; }
        }
    }
}