namespace HumanResourcesForm.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string CvUrl { get; set; }

        public ICollection<ContactMessage> Messages { get; set; }
    }
}
