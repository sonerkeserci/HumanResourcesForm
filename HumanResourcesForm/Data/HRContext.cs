using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace HumanResourcesForm
{
    public class HRContext : DbContext
    {
        public HRContext(DbContextOptions<HRContext> options) : base(options)
        {           
            
        }

        public DbSet<Contact> Contacts { get; set; }   
        public DbSet<Form> Forms { get; set; }
    }
}
