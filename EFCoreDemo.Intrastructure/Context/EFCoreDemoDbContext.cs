using EFCoreDemo.Infrastructure.Entities;

// todo: Step 2: Install the necessary nuget packages
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Infrastructure.Context
{
    // todo: Step 3: Define your DbContext
    public class EFCoreDemoDbContext : DbContext
    {
        public EFCoreDemoDbContext(DbContextOptions<EFCoreDemoDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
