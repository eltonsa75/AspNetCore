using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOfBuild.Data
{
    public class ApplicationDbContext : DbContext
    {
            public ApplicationDbContext(ApplicationDbContext<ApplicationDbContext> option) : base (option)
            {

            }

            public DbSet<Category> Categories {get; set;}
    }
}