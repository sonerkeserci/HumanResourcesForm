using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResourcesForm
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

        // Foreign key
        public int FormId { get; set; }

        [ForeignKey("FormId")]
        public Form Form { get; set; }
    }
}
