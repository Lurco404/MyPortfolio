using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("Server=(local)\\SQLEXPRESS ; Database = MyPortfolioDb ; Trusted_connection=true;TrustServerCertificate=True;multipleActiveResultSets=true;");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
