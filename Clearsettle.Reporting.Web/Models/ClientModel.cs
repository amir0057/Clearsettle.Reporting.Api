using System.ComponentModel;

namespace Clearsettle.Reporting.Web.Models
{
    public class ClientModel
    {
        [DisplayName("id")]
        public int Id { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Billing FirstName")]
        public string BillingFirstName { get; set; }
        [DisplayName("Created at")]
        public string created_at { get; set; }
        [DisplayName("Updated at")]
        public string updated_at { get; set; }
        [DisplayName("Deleted at")]
        public string deleted_at { get; set; }
        [DisplayName("Number")]
        public string number { get; set; }
        [DisplayName("Expiry Month")]
        public string expiryMonth { get; set; }
        [DisplayName("Expiry Year")]
        public string expiryYear { get; set; }
        [DisplayName("Start Month")]
        public string startMonth { get; set; }
        [DisplayName("Start Year")]
        public string startYear { get; set; }
        [DisplayName("Issue Number")]
        public string issueNumber { get; set; }
        [DisplayName("Birthday")]
        public string birthday { get; set; }
        [DisplayName("Gender")]
        public string gender { get; set; }
        [DisplayName("Billing Title")]
        public string billingTitle { get; set; }
        [DisplayName("Billing LastName")]
        public string billingLastName { get; set; }
        [DisplayName("Billing Company")]
        public string billingCompany { get; set; }
        [DisplayName("Billing Address1")]
        public string billingAddress1 { get; set; }
        [DisplayName("Billing Address2")]
        public string billingAddress2 { get; set; }
        [DisplayName("Billing City")]
        public string billingCity { get; set; }
        [DisplayName("Billing Postcode")]
        public string billingPostcode { get; set; }
        [DisplayName("Billing State")]
        public string billingState { get; set; }
        [DisplayName("Billing Country")]
        public string billingCountry { get; set; }
        [DisplayName("Billing Phone")]
        public string billingPhone { get; set; }
        [DisplayName("Bbilling Fax")]
        public string billingFax { get; set; }
        [DisplayName("Shipping Title")]
        public string shippingTitle { get; set; }
        [DisplayName("Shipping FirstName")]
        public string shippingFirstName { get; set; }
        [DisplayName("Shipping LastName")]
        public string shippingLastName { get; set; }
        [DisplayName("Shipping Company")]
        public string shippingCompany { get; set; }
        [DisplayName("Shipping Address1")]
        public string shippingAddress1 { get; set; }
        [DisplayName("Shipping Address2")]
        public string shippingAddress2 { get; set; }
        [DisplayName("Shipping City")]
        public string shippingCity { get; set; }
        [DisplayName("Shipping Postcode")]
        public string shippingPostcode { get; set; }
        [DisplayName("Shipping State")]
        public string shippingState { get; set; }
        [DisplayName("Shipping Country")]
        public string shippingCountry { get; set; }
        [DisplayName("Shipping Phone")]
        public string shippingPhone { get; set; }
        [DisplayName("Shipping Fax")]
        public string shippingFax { get; set; }
    }
}