using Newtonsoft.Json;

namespace Clearsettle.Driver.Model.Response
{
    public class CustomerInfoResponse
    {
        [JsonProperty("customerInfo")]
        public CustomerInfo CustomerInfo { get; set; }
    }
    public class CustomerInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("billingFirstName")]
        public string BillingFirstName { get; set; }
        [JsonProperty("created_at")]
        public string created_at { get; set; }
        [JsonProperty("updated_at")]
        public string updated_at { get; set; }
        [JsonProperty("deleted_at")]
        public string deleted_at { get; set; }
        [JsonProperty("number")]
        public string number { get; set; }
        [JsonProperty("expiryMonth")]
        public string expiryMonth { get; set; }
        [JsonProperty("expiryYear")]
        public string expiryYear { get; set; }
        [JsonProperty("startMonth")]
        public string startMonth { get; set; }
        [JsonProperty("startYear")]
        public string startYear { get; set; }
        [JsonProperty("issueNumber")]
        public string issueNumber { get; set; }
        [JsonProperty("birthday")]
        public string birthday { get; set; }
        [JsonProperty("gender")]
        public string gender { get; set; }
        [JsonProperty("billingTitle")]
        public string billingTitle { get; set; }
        [JsonProperty("billingLastName")]
        public string billingLastName { get; set; }
        [JsonProperty("billingCompany")]
        public string billingCompany { get; set; }
        [JsonProperty("billingAddress1")]
        public string billingAddress1 { get; set; }
        [JsonProperty("billingAddress2")]
        public string billingAddress2 { get; set; }
        [JsonProperty("billingCity")]
        public string billingCity { get; set; }
        [JsonProperty("billingPostcode")]
        public string billingPostcode { get; set; }
        [JsonProperty("billingState")]
        public string billingState { get; set; }
        [JsonProperty("billingCountry")]
        public string billingCountry { get; set; }
        [JsonProperty("billingPhone")]
        public string billingPhone { get; set; }
        [JsonProperty("billingFax")]
        public string billingFax { get; set; }
        [JsonProperty("shippingTitle")]
        public string shippingTitle { get; set; }
        [JsonProperty("shippingFirstName")]
        public string shippingFirstName { get; set; }
        [JsonProperty("shippingLastName")]
        public string shippingLastName { get; set; }
        [JsonProperty("shippingCompany")]
        public string shippingCompany { get; set; }
        [JsonProperty("shippingAddress1")]
        public string shippingAddress1 { get; set; }
        [JsonProperty("shippingAddress2")]
        public string shippingAddress2 { get; set; }
        [JsonProperty("shippingCity")]
        public string shippingCity { get; set; }
        [JsonProperty("shippingPostcode")]
        public string shippingPostcode { get; set; }
        [JsonProperty("shippingState")]
        public string shippingState { get; set; }
        [JsonProperty("shippingCountry")]
        public string shippingCountry { get; set; }
        [JsonProperty("shippingPhone")]
        public string shippingPhone { get; set; }
        [JsonProperty("shippingFax")]
        public string shippingFax { get; set; }
    }
}