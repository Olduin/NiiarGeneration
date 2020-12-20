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

            IList<Vehicle> vehincles = new List<Vehicle>
            {
                new Vehicle {Name = "Легковой а/м", state_Number = "п333иа73" },    //0
                new Vehicle {Name = "Легковой а/м", state_Number = "н134иа73" },    //1
                new Vehicle {Name = "Автопогрузчик", state_Number = "н442иа73" },   //2
                new Vehicle {Name = "СамосвалЗИЛ", state_Number = "п451иа73" },     //3
                new Vehicle {Name = "Икар", state_Number = "п432ет73" },            //4
                new Vehicle {Name = "грузовик", state_Number = "х322еа73" },        //5
                new Vehicle {Name = "Кран", state_Number = "п123иа73" },            //6
                new Vehicle {Name = "Внедорожник", state_Number = "п312ии73" }      //7
            };

            dbContext.Vehincles.AddRange(vehincles);

            IList<Applicat> applicats = new List<Applicat>
            {
                new Applicat{Date = new DateTime(2020,06,20),Type = typeApplicats[0]},
                new Applicat{Date = new DateTime(2020,08,10), Type = typeApplicats[1] },
                new Applicat{Date = new DateTime(2020,09,29), Type = typeApplicats[1] },
                new Applicat{Date = new DateTime(2020,09,13), Type = typeApplicats[1] },
                new Applicat{Date = new DateTime(2020,10,14), Type = typeApplicats[0] },
                new Applicat{Date = new DateTime(2020,10,21), Type = typeApplicats[0] },
                new Applicat{Date = new DateTime(2020,11,22), Type = typeApplicats[0] },
                new Applicat{Date = new DateTime(2020,11,28), Type = typeApplicats[1] },
                new Applicat{Date = new DateTime(2020,12,18), Type = typeApplicats[1] },
                new Applicat{Date = new DateTime(2020,12,14), Type = typeApplicats[0] }
            };

            dbContext.Applicats.AddRange(applicats);

            IList<ApplicatItem> applicatItems = new List<ApplicatItem>
            {
                new ApplicatItem {Applicat = applicats[0], Description_Work = "Покататься", Delivery_Address = "Курчатова 40", Responsible_Customer = "Махмутов Игорь Леонтьевич", Vehicle =vehincles[0] },
                new ApplicatItem {Applicat = applicats[0], Description_Work = "Трансфер 1 человека в Арбитажный суд г. Тольятти, ул. Автономная, 43", Delivery_Address = "ул. Смирьянова д.51 кв.30", Responsible_Customer = "Сергеев П.П.", Vehicle = vehincles[0] },

                new ApplicatItem {Applicat = applicats[1], Description_Work = "Транспортировка груза", Delivery_Address = "Октябрьская", Responsible_Customer = "Богатырёв Анатолий Сергеевич", Vehicle =vehincles[1]  },
                new ApplicatItem {Applicat = applicats[2], Description_Work = "Прорыв трубы теплопровода", Delivery_Address = "ул. Синяя д.1 кв.123", Responsible_Customer = "Самсонов Г.И.", Vehicle = vehincles[1] },
                new ApplicatItem {Applicat = applicats[2], Description_Work = "Доставка груза", Delivery_Address = "ул. Белова д.71", Responsible_Customer = "Каронин Л.Н.", Vehicle = vehincles[5] },

                new ApplicatItem {Applicat = applicats[3], Description_Work = "Конфискация транспорта", Delivery_Address = "ул. Зелёная строение 5", Responsible_Customer = "Романов Ф.М.", Vehicle = vehincles[2] },
                new ApplicatItem {Applicat = applicats[3], Description_Work = "Доставка ремонтной бригады", Delivery_Address = "ул. ", Responsible_Customer = "Каронин Л.Н.", Vehicle = vehincles[2] },

                new ApplicatItem {Applicat = applicats[4], Description_Work = "Доставка груза", Delivery_Address = "ул. Вселенной 232", Responsible_Customer = "Королёв Н.Г.", Vehicle = vehincles[5] },

                new ApplicatItem {Applicat = applicats[5], Description_Work = "Трансфер 4 человек в регистратуру, ул. Регламета, 19 д. 7", Delivery_Address = "ул. Сергеева 10, д. 5", Responsible_Customer = "Каронин Л.Н.", Vehicle = vehincles[2] },

                new ApplicatItem {Applicat = applicats[6], Description_Work = "Трансфер 1 человека в отдел внутренних дел РФ по Самарской области, ул. Гаечная 121 ", Delivery_Address = "ул. Капищева 40, кв. 80", Responsible_Customer = "Лапласов А.А.", Vehicle = vehincles[1] },
                new ApplicatItem {Applicat = applicats[6], Description_Work = "Доставка оборудования в новый отдел, ул. Гоголя 18", Delivery_Address = "ул. Темный переулок", Responsible_Customer = "пр. Автостроителей 7, кв. 14", Vehicle = vehincles[1] },

                new ApplicatItem {Applicat = applicats[7], Description_Work = "Трансфер специалиста по БД в серверную г. Самары д. 14 кв. 55", Delivery_Address = "ул. Александрова 124, кв. 55 ", Responsible_Customer = "Самсонов Г.И.", Vehicle = vehincles[1] },
                new ApplicatItem {Applicat = applicats[7], Description_Work = "Доставка груза", Delivery_Address = "ул. Белова д.71", Responsible_Customer = "Несмеянов П.Н.", Vehicle = vehincles[7] },

                new ApplicatItem {Applicat = applicats[8], Description_Work = "Проверка системы пожаротушения", Delivery_Address = "ул. Формы, стр. 1", Responsible_Customer = "Фишер Е.Н.", Vehicle = vehincles[1] },
                new ApplicatItem {Applicat = applicats[8], Description_Work = "Эвакуация работников фирмы", Delivery_Address = "ул. Бордова 12", Responsible_Customer = "Каронин Л.Н.", Vehicle = vehincles[4] },

                new ApplicatItem {Applicat = applicats[9], Description_Work = "Перевозка материалов", Delivery_Address = "КТЦ", Responsible_Customer = "Сенин П.Ф.", Vehicle = vehincles[2] }
                
            };  

            dbContext.ApplicatItems.AddRange(applicatItems);


            dbContext.SaveChanges();
        }
    }
}
