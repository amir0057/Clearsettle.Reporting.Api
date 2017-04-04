using System;
using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Request
{
    public class TransactionListRequest
    {
        [JsonProperty("fromDate")]
        public string FromDate { get; set; }

        [JsonProperty("toDate")]
        public string ToDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("operation")]
        public string Operation { get; set; }

        [JsonProperty("merchant")]
        public int Merchant { get; set; }

        [JsonProperty("acquirer")]
        public int Acquirer { get; set; }

        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("filterField")]
        public string FilterField { get; set; }

        [JsonProperty("filterValue")]
        public string FilterValue { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
    }
}