using HumanResourcesForm.Models;
using Microsoft.EntityFrameworkCore;

namespace HumanResourcesForm.Data
{
    public class HRContext : DbContext
    {
        public HRContext(DbContextOptions<HRContext> options) : base(options)
        {
        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
    
}
