using DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork.Context
{
    public static class DbInitializer
    {
        public static void CreateDbIfNotExists(IHost host)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=DemoDb;Trusted_Connection=True;");
            EFContext context = new EFContext(optionsBuilder.Options);
            Initialize(context);
        }

        public static EFContext CreateEFContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=DemoDb;Trusted_Connection=True;");
            EFContext context = new EFContext(optionsBuilder.Options);
        }
        public static void Initialize(EFContext context)
        {
            context.Database.EnsureCreated();
            context.Database.Migrate();

        }
    }
}
