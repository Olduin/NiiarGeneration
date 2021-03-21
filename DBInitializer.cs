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
                new Vehicle {Name = "ГАЗ-5312 (бортовойс бортподъемником)", state_Number = "Е588ТС73" },    //0
                new Vehicle {Name = "ЗИЛ- 4505 (самосвал)", state_Number = "А413НВ73" },    //1
                new Vehicle {Name = "КАМАЗ-5320 ", state_Number = "В270МТ" },   //2
                new Vehicle {Name = "КАМАЗ-4528-10 (самосвал)", state_Number = "Т218ХО73" },     //3
                new Vehicle {Name = "ЗИЛ-130 ПМ ", state_Number = "Е478ХН73" },            //4
                new Vehicle {Name = "ЗИЛ-433362 КО-520", state_Number = "Р573СО73" },        //5
                new Vehicle {Name = "ЗИЛ-433362 КО-510, КО-530 ", state_Number = "В513ОУ73" },            //6
                new Vehicle {Name = "ЗИЛ-5301 (аварий-ная, сантехниче-ская)", state_Number = "Х391НС73" },      //7
                new Vehicle {Name = "УРАЛ-555 КС-35719", state_Number = "Р366АР73" },        //8
                new Vehicle {Name = "МАЗ-5334 (автокран)", state_Number = "Т509АА73" },            //9
                new Vehicle {Name = "А-4081 (автопогруз-чик)", state_Number = "С345ТУ73" },      //10

                new Vehicle {Name = "А-4081 (автопогруз-чик)", state_Number = "Х210АЕ73" },            //11
                new Vehicle {Name = "ЭО-33211А экскаватор ", state_Number = "У986МТ73" },        //12
                new Vehicle {Name = "ЭО-2621 Беларусь ", state_Number = "У986МТ73" },            //13
                new Vehicle {Name = "Фронтальный по-грузчик В-140.001", state_Number = "Е629РТ73" },      //14
                new Vehicle {Name = "МАЗ – 5337ПМС-328Д", state_Number = "Р700НО73" },        //15
                new Vehicle {Name = "КАМАЗ – 5410 ", state_Number = "К814ЕЕ73" },            //16
                new Vehicle {Name = "Трактор Т-150 ", state_Number = "Н003СВ73" }      //17
            };

            dbContext.Vehincles.AddRange(vehincles);

            IList<Customer> customers = new List<Customer>
            {
                new Customer {Name = "Электро-ремонтный цех", Responsible = "Шестаков С.Г." }, //0
                new Customer {Name = "Химический цех (генерация углекислоты)", Responsible = "Безенкова Т.Д." },//1
                new Customer {Name = "Группа по учету энергоносителей", Responsible = "Фомин Е.А." },//2
                new Customer {Name = "Отдел правовых и корпоративных отношений", Responsible = "Абакумова М.А." },//3
                new Customer {Name = "Административно-хозяйственный отдел", Responsible = "Чигрина В.В." },//4
                new Customer {Name = "РМЦ", Responsible = "Назаров К.М." },//5
                new Customer {Name = "Цех холодоснабжения", Responsible = "Андрианов М.Г." }//6
            };


            dbContext.Customers.AddRange(customers);

            IList<Applicat> applicats = new List<Applicat>
            {
                new Applicat{Date = new DateTime(2020,06,20),Type = typeApplicats[0]},   //0
                new Applicat{Date = new DateTime(2020,08,10), Type = typeApplicats[1] },//1
                new Applicat{Date = new DateTime(2020,09,29), Type = typeApplicats[1] },//2
                new Applicat{Date = new DateTime(2020,09,13), Type = typeApplicats[1] },//3
                new Applicat{Date = new DateTime(2020,10,14), Type = typeApplicats[0] },//4
                new Applicat{Date = new DateTime(2020,10,21), Type = typeApplicats[0] },//5
                new Applicat{Date = new DateTime(2020,11,22), Type = typeApplicats[0] },//6
                new Applicat{Date = new DateTime(2020,11,28), Type = typeApplicats[1] },//7
                new Applicat{Date = new DateTime(2020,12,18), Type = typeApplicats[1] },//8
                new Applicat{Date = new DateTime(2020,12,14), Type = typeApplicats[0] }//9
            };

            dbContext.Applicats.AddRange(applicats);

            IList<TypeWork> typeWorks = new List<TypeWork>
            {
                new TypeWork{ Name = "Перевозка материалов" },//0
                new TypeWork{ Name = "Трансфер человека" },//1
                new TypeWork{ Name = "Раскопка грунта" },//2
                new TypeWork{ Name = "Вентиляция ТК" },//3
            };

            dbContext.TypeWorks.AddRange(typeWorks);

            IList<ApplicatItem> applicatItems = new List<ApplicatItem>
            {
                new ApplicatItem {Applicat = applicats[0], Delivery_Address = "Курчатова 40", Vehicle =vehincles[0], Customer = customers [1], TypeWork = typeWorks [0], Time_Of_Filing = new DateTime(2020,06,20, 07,55, 44), End_time_of_work = new DateTime(2020,06,20, 10,00, 44)  },
                new ApplicatItem {Applicat = applicats[0], Delivery_Address = "ул. Смирьянова д.51 кв.30",  Vehicle = vehincles[0], Customer = customers [0], TypeWork = typeWorks [0], Time_Of_Filing = new DateTime(2020,06,20, 09, 39, 26) , End_time_of_work = new DateTime(2020,06,20, 11, 50, 26)  },

                new ApplicatItem {Applicat = applicats[1], Delivery_Address = "Октябрьская",  Vehicle =vehincles[1], Customer = customers [1]  , TypeWork = typeWorks [2] , Time_Of_Filing = new DateTime(2020,08,10, 19,55,45) , End_time_of_work = new DateTime(2020,08,10, 20,56,45) },
                new ApplicatItem {Applicat = applicats[2], Delivery_Address = "ул. Синяя д.1 кв.123",  Vehicle = vehincles[1], Customer = customers [3]  , TypeWork = typeWorks [0], Time_Of_Filing = new DateTime(2020,09,29, 21,55,22) , End_time_of_work = new DateTime(2020,09,29, 22,40,22)},
                new ApplicatItem {Applicat = applicats[2], Delivery_Address = "ул. Белова д.71",  Vehicle = vehincles[5] , Customer = customers [5] , TypeWork = typeWorks [0], Time_Of_Filing = new DateTime(2020,09,29, 18,53,53) , End_time_of_work = new DateTime(2020,09,29, 20,49,53) },

                new ApplicatItem {Applicat = applicats[3], Delivery_Address = "ул. Зелёная строение 5", Vehicle = vehincles[2], Customer = customers [4]  , TypeWork = typeWorks [1], Time_Of_Filing = new DateTime(2020,09,13, 06,26,11), End_time_of_work = new DateTime(2020,09,13, 09,00,11)  },
                new ApplicatItem {Applicat = applicats[3], Delivery_Address = "ул. ", Vehicle = vehincles[2], Customer = customers [4]  , TypeWork = typeWorks [1] , Time_Of_Filing = new DateTime(2020,09,13, 01,16,39), End_time_of_work = new DateTime(2020,09,13, 01,16,39) },

                new ApplicatItem {Applicat = applicats[4], Delivery_Address = "ул. Вселенной 232", Vehicle = vehincles[5], Customer = customers [0] , TypeWork = typeWorks [2] , Time_Of_Filing = new DateTime(2020,10,14, 22,21,07) , End_time_of_work = new DateTime(2020,10,14, 23,15,07) },

                new ApplicatItem {Applicat = applicats[5], Delivery_Address = "ул. Сергеева 10, д. 5", Vehicle = vehincles[2], Customer = customers [0] , TypeWork = typeWorks [3] , Time_Of_Filing = new DateTime(2020,10,21, 21,37,07)  , End_time_of_work = new DateTime(2020,10,21, 23,00,07)},

                new ApplicatItem {Applicat = applicats[6], Delivery_Address = "ул. Капищева 40, кв. 80", Vehicle = vehincles[1], Customer = customers [4]  , TypeWork = typeWorks [1] , Time_Of_Filing = new DateTime(2020,11,22, 08,07,18), End_time_of_work = new DateTime(2020,11,22, 12,30,18) },
                new ApplicatItem {Applicat = applicats[6], Delivery_Address = "ул. Темный переулок", Vehicle = vehincles[15], Customer = customers [3] , TypeWork = typeWorks [0] , Time_Of_Filing = new DateTime(2020,11,22, 10,39,40)  , End_time_of_work = new DateTime(2020,11,22, 11,50,40)},

                new ApplicatItem {Applicat = applicats[7], Delivery_Address = "ул. Александрова 124, кв. 55 ", Vehicle = vehincles[1], Customer = customers [6] , TypeWork = typeWorks [2] , Time_Of_Filing = new DateTime(2020,11,28, 09,59,32), End_time_of_work = new DateTime(2020,11,28, 11,30,32)  },
                new ApplicatItem {Applicat = applicats[7], Delivery_Address = "ул. Белова д.71", Vehicle = vehincles[7], Customer = customers [2] , TypeWork = typeWorks [0]  , Time_Of_Filing = new DateTime(2020,11,28, 09,43,40), End_time_of_work = new DateTime(2020,11,28, 12,05,40) }, 

                new ApplicatItem {Applicat = applicats[8], Delivery_Address = "ул. Формы, стр. 1", Vehicle = vehincles[1], Customer = customers [1]  , TypeWork = typeWorks [3] , Time_Of_Filing = new DateTime(2020,12,18, 13,42,05), End_time_of_work = new DateTime(2020,12,18, 15,36,05) },
                new ApplicatItem {Applicat = applicats[8], Delivery_Address = "ул. Бордова 12", Vehicle = vehincles[4], Customer = customers [0] , TypeWork = typeWorks [2] , Time_Of_Filing = new DateTime(2020,12,18, 22,18,12) , End_time_of_work = new DateTime(2020,12,18, 23,50,12) },

                new ApplicatItem {Applicat = applicats[9], Delivery_Address = "КТЦ",  Vehicle = vehincles[2], Customer = customers [3] , TypeWork = typeWorks [2] , Time_Of_Filing = new DateTime(2020,12,14, 16,04,24) , End_time_of_work = new DateTime(2020,12,14, 18,10,24)}
            };  

            dbContext.ApplicatItems.AddRange(applicatItems);


            dbContext.SaveChanges();
        }
    }
}
