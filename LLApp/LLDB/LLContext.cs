using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

using LLDB.Models;

namespace StoreDB
{
    public class StoreContext : DbContext
    {
        public StoreContext()
        {
        }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        
        public DbSet<Child> Children { get; set; }

        public DbSet<Parent> Parents { get; set; }
        
        public DbSet<Team> Teams { get; set; }

        public DbSet<Practice> Practices { get; set; }

        public DbSet<Game> Games { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                var connectionString = configuration.GetConnectionString("LLDB");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }
    }
}