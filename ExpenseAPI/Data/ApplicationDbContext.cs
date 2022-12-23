using ExpenseAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Category> Categories { get; set; } 
        public DbSet<Transaction> Transactions { get; set; } 
    }
}
