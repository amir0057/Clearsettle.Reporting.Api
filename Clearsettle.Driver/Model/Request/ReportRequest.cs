using System;
using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Request
{
    public class ReportRequest
    {
        [JsonProperty("fromDate")]
        public string FromDate { get; set; }

        [JsonProperty("toDate")]
        public string ToDate { get; set; }

        [JsonProperty("merchant")]
       
        public int? Merchant { get; set; }

        [JsonProperty("acquirer")]
        public int? Acquirer { get; set; }
    }
}