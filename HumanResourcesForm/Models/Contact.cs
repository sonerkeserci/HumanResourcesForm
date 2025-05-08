using System.ComponentModel.DataAnnotations;

namespace HumanResourcesForm.Models
{
    public class Contact : IIdentity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30), Required]
        public required string NameSurname { get; set; }

        [StringLength(50), Required]
        public required string Email { get; set; }


        [StringLength(250), Required]
        public required string YourMessage { get; set; }
    }
}
