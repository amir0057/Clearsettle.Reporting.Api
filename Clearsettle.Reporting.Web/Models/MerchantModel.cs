using System.ComponentModel;

namespace Clearsettle.Reporting.Web.Models
{
    public class MerchantModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Parent Id")]
        public string ParentId { get; set; }
        [DisplayName("3D Status")]
        public string Status3D { get; set; }
        [DisplayName("MCC")]
        public string Mcc { get; set; }
        [DisplayName("IpnUrl")]
        public string IpnUrl { get; set; }
        [DisplayName("Api Key")]
        public string ApiKey { get; set; }
        [DisplayName("Cpg Key")]
        public string CpgKey { get; set; }
        [DisplayName("Type")]
        public string Type { get; set; }
        [DisplayName("Descriptor")]
        public string Descriptor { get; set; }
        [DisplayName("Secret Key")]
        public string SecretKey { get; set; }
        [DisplayName("Com Type")]
        public string ComType { get; set; }
    }
}