using System.ComponentModel.DataAnnotations;

namespace HumanResourcesForm
{
    public class Form : IIdentity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30), Required]
        public string NameSurname { get; set; }

        [StringLength(50), Required]
        public string Email { get; set; }

        [StringLength(11), Required]
        public string IdentityNumber { get; set; }

        [StringLength(11), Required]
        public string PhoneNumber { get; set; }

        [StringLength(2050), Required]
        public string CV_Url { get; set; }




    }
}
