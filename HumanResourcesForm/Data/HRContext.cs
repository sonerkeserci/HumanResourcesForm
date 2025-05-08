using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HumanResourcesForm
{
    public class HRContext : DbContext
    {
        public HRContext(DbContextOptions<HRContext> options) : base(options)
        {
            
        }
    }
}
