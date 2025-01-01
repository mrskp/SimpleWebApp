using Microsoft.EntityFrameworkCore;
using SimpleWebApplication.Models;

namespace SimpleWebApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
    }
}
