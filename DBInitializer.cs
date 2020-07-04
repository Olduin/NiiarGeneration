using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NiiarGeneration.Models;


namespace NiiarGeneration
{
    public class DBInitializer : DropCreateDatabaseAlways<ApplicatDbContext>//: DropCreateDatabaseIfModelChanges<ApplicatDbContext>
    {
        protected override void Seed(ApplicatDbContext dbContext)
        {
            IList<TypeApplicat> typeApplicats = new List<TypeApplicat>
            {
                new TypeApplicat {Name = "Обычная" },
                new TypeApplicat {Name = "Аварийная" }
            };

            dbContext.TypeApplicates.AddRange(typeApplicats);

            IList<Vehincle> vehincles = new List<Vehincle>
            {
                new Vehincle {Name = "Легковой а/м", state_Number = "п333иа73" },
                new Vehincle {Name = "автопогрузчик", state_Number = "н442иа73" }
            };

            dbContext.Vehincles.AddRange(vehincles);

            IList<Applicat> applicats = new List<Applicat>
            {
                new Applicat{Date = new DateTime(2020,06,20),Type = typeApplicats[0]},
                new Applicat{Date = new DateTime(2020,06,13), Type = typeApplicats[1] }
            };

            dbContext.Applicats.AddRange(applicats);

            IList<ApplicatItem> applicatItems = new List<ApplicatItem>
            {
                new ApplicatItem {Applicat = applicats[0],Description_Work = "Покататься",}
            };

            dbContext.ApplicatItems.AddRange(applicatItems);


            dbContext.SaveChanges();
        }
    }
}
