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

        DbSet<Contact> Contacts { get; set; }   
        DbSet<Form> Forms { get; set; }
    }
}
