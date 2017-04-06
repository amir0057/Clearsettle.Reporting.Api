using Newtonsoft.Json;
using System.ComponentModel;

namespace Clearsettle.Reporting.Web.Models
{
    public class ReportModel
    {
        [JsonProperty("response")]
        public ReportData[] Report { get; set; }
        [DisplayName("status")]
        public string Status { get; set; }
    }

    public class ReportData
    {
        [DisplayName("count")]
        public int Count { get; set; }

        [DisplayName("total")]
        public int Total { get; set; }

        [DisplayName("currency")]
        public string Currency { get; set; }
    }
}