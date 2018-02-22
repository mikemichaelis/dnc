// dotnet ef -s ../webapi/webapi.csproj dbcontext scaffold 'Data Source=.;Initial Catalog=dnc;User Id=sa;Password=asdfASDF!' Microsoft.EntityFrameworkCore.SqlServer

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace model
{
    public partial class dncContext : DbContext
    {
        public dncContext() {
            //Configuration.ProxyCreationEnabled = false;
            // Configuration.LazyLoadingEnabled = false;
        }

        public dncContext(DbContextOptions<dncContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=dnc;User Id=sa;Password=asdfASDF!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        public DbSet<Employee> Employees { get; set; }
    }
}
