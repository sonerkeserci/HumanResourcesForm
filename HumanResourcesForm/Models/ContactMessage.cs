using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResourcesForm.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; } = DateTime.Now;

        public int? ApplicantId { get; set; }

        [ForeignKey("ApplicantId")]
        public Applicant Applicant { get; set; }
    }
}
