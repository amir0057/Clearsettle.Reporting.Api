using System;
using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Request
{
    public class TransactionListRequest
    {
        [JsonProperty("fromDate")]
        public DateTime FromDate { get; set; }

        [JsonProperty("toDate")]
        public DateTime ToDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("operation")]
        public string Operation { get; set; }

        [JsonProperty("merchantId")]
        public int MerchantId { get; set; }

        [JsonProperty("acquirerId")]
        public int AcquirerId { get; set; }

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