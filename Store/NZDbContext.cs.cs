using Microsoft.EntityFrameworkCore;
using NZ_API.Domain.Models;

namespace NZ_API.Store
{
    public class NZDbContext : DbContext
    {
        public NZDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Walks> walks { get; set; }
        public DbSet<Regions>  regions { get; set; }
        public DbSet<Difficulty> difficulties { get; set; }

        public DbSet<TestTable> TestTables { get; set; }

       // public DbSet<test2> test2 { get; set; }


    }
}
