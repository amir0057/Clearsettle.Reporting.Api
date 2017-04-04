using System;
using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Request
{
    public class ReportRequest
    {
        [JsonProperty("fromDate")]
        public DateTime FromDate { get; set; }

        [JsonProperty("toDate")]
        public DateTime ToDate { get; set; }

        [JsonProperty("merchant")]
        public int Merchant { get; set; }

        [JsonProperty("acquirer")]
        public int Acquirer { get; set; }
    }
}