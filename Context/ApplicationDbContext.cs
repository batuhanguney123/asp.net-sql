using batuhan.Models;
using Microsoft.EntityFrameworkCore;

namespace batuhan.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions): base(contextOptions) { }

        public DbSet<employee> Employees { get; set; }
    }
}
