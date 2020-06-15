using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShopSolution.Data.EF
{
    class eShopSolutionDbContextFactory : IDesignTimeDbContextFactory<eShopDbContext>
    {
        public eShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings1.json")
                .Build();
            var ConnectionString = configuration.GetConnectionString("eShopSolutionDB");
            var optionsBuilder = new DbContextOptionsBuilder<eShopDbContext>();
            optionsBuilder.UseSqlServer(ConnectionString);

            return new eShopDbContext(optionsBuilder.Options);
        }
    }
}
