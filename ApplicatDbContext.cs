using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NiiarGeneration.Models;

namespace NiiarGeneration
{
    public class ApplicatDbContext : DbContext
    {
        public ApplicatDbContext()
            : base("Server=localHost\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Applicat")
        {
            Database.SetInitializer(new DBInitializer());
        }

        public DbSet<TypeApplicat> TypeApplicates { get; set; }
        public DbSet<Vehicle> Vehincles { get; set; }
        public DbSet<Applicat> Applicats { get; set; }
        public DbSet<ApplicatItem> ApplicatItems { get; set; }
        public DbSet<TypeWork> TypeWorks { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
