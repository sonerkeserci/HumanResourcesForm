using System.ComponentModel.DataAnnotations;

namespace HumanResourcesForm.Models
{
    public class Applicant
    {
        public int Id { get; set; }


        [Required, StringLength(20)]
        public string NameSurname { get; set; }

        [Required, StringLength(11)]
        public string PhoneNumber { get; set; }

        [Required, StringLength(40)]
        public string Email { get; set; }

        [Required, StringLength(11)]
        public string IdentityNumber { get; set; }

        [Required, StringLength(2050)]
        public string CvUrl { get; set; }


        public ICollection<ContactMessage> Messages { get; set; }
    }
}
