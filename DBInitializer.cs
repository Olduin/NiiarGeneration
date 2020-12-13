using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NiiarGeneration.Models;


namespace NiiarGeneration
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<ApplicatDbContext>
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
                new Vehincle {Name = "Легковой а/м", state_Number = "н134иа73" },
                new Vehincle {Name = "автопогрузчик", state_Number = "н442иа73" },
                new Vehincle {Name = "СамосвалЗИЛ", state_Number = "п451иа73" }
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
                new ApplicatItem {Applicat = applicats[0],Description_Work = "Покататься",Delivery_Address = "Курчатова 40",Responsible_Customer = "Махмутов Игорь Леонтьевич", Vehicle =vehincles[0]  },
                new ApplicatItem {Applicat = applicats[1],Description_Work = "Транспортировка груза",Delivery_Address = "Октябрьская",Responsible_Customer = "Богатырёв Анатолий Сергеевич", Vehicle =vehincles[1]  },
                new ApplicatItem { Applicat = applicats[0], Description_Work = "Трансфер 1 человека в Арбитажный суд г. Тольятти, ул. Автономная, 43", Delivery_Address = "ул. Смирьянова д.51 кв.30", Responsible_Customer = "Сергеев П.П.", Vehicle = vehincles[0] }
        };  
            dbContext.ApplicatItems.AddRange(applicatItems);


            dbContext.SaveChanges();
        }
    }
}
