using Microsoft.EntityFrameworkCore;

namespace MoneyIdroid.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions Options) : base(Options)   
        {}

        public DbSet<Transaction> Transactions{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
