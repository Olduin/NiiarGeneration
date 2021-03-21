using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NiiarGeneration.Models;
using System.Data.Entity;

namespace NiiarGeneration
{
    public class Repository
    {
        private ApplicatDbContext applicatDbContext;

        
        public Repository()
        {
            applicatDbContext = new ApplicatDbContext();
            //applicatDbContext.Configuration.LazyLoadingEnabled = false;
        }

        public IList<Applicat> ApplicatGetList() 
        {
            return applicatDbContext.Applicats.ToList();
        }

      
        public Applicat ApplicatGet(long id)
        {
            //  Applicat applicat = applicatDbContext.Applicats.Attach(applicat.ApplicatItems.).AsNoTracking().FirstOrDefault(ac => ac.Id == id);
            return applicatDbContext.Applicats
                //.Include(ai => ai.ApplicatItems)
                //.Include(ai => ai.ApplicatItems.Select(v => v.Vehicle))
                .AsNoTracking().FirstOrDefault(ac => ac.Id == id);
        }

        public List<Applicat> ApplicatsGet(long typeApplicat)
        {
          return applicatDbContext.Applicats.Where(ap => ap.Type.Id == typeApplicat).ToList() ;

        }
          

        public List<ApplicatItem> GetApplicatItems()
        {
            return applicatDbContext.ApplicatItems.ToList();
        }

        public List<Vehicle> VehicleGetList()
        {
            return applicatDbContext.Vehincles.ToList();
        }

        public List<TypeWork> TypeWorkGetList()
        {
            return applicatDbContext.TypeWorks.ToList();
        }

        public List<Customer> CustomerGetList()
        {
            return applicatDbContext.Customers.ToList();
        }

        public Vehicle GetVehicle(long id)
        {
            return applicatDbContext.Vehincles.FirstOrDefault(vh => vh.Id == id);
        }

        public TypeWork GetTypeWork(long id)
        {
            return applicatDbContext.TypeWorks.FirstOrDefault(tw => tw.Id == id);
        }

        public Customer GetCustomer(long id)
        {
            return applicatDbContext.Customers.FirstOrDefault(vh => vh.Id == id);
        }

        public List<TypeApplicat> GetTypesList()
        {
            return applicatDbContext.TypeApplicates.ToList();
        }

        public void ApplicateAdd(Applicat applicat)
        {
            applicatDbContext.Applicats.Add(applicat);
            applicatDbContext.SaveChanges();
            DeatchAll();
        }

        public void ApplicateSave(Applicat applicat)
        {
            /* applicat = Normalize(applicat);
             applicatDbContext.Applicats.Attach(applicat);
             applicatDbContext.Entry(applicat).State = EntityState.Modified;          

             foreach(var ai in applicat.ApplicatItems)
             {
                 applicatDbContext.ApplicatItems.Attach(ai);
                 applicatDbContext.Entry(ai).State = EntityState.Modified;
             }

             applicatDbContext.SaveChanges();
             DeatchAll();
            */

            Applicat sourseApplicat = applicatDbContext.Applicats.FirstOrDefault(sa => sa.Id == applicat.Id);
            sourseApplicat.Type = applicat.Type;
            sourseApplicat.Date = applicat.Date;

            for(int index = 0; index<sourseApplicat.ApplicatItems.Count; index++)
            {
                var oldItem = sourseApplicat.ApplicatItems[index];
                var newItem = applicat.ApplicatItems.Find(ni => ni.Id == oldItem.Id);

                if (newItem != null)
                {
                    oldItem = newItem;
                }
                else
                    applicatDbContext.Entry(oldItem).State = EntityState.Deleted;

            }
            applicatDbContext.SaveChanges();

            /*foreach( var ai in sourseApplicat.ApplicatItems)
            {
                var newItem = applicat.ApplicatItems.Find(nai => nai.Id == ai.Id);
                if (newItem != null)
                    sourseApplicat.ApplicatItems.Find(ni=> ni==ai) = newItem;
                else
                    applicatDbContext.Entry(ai).State = EntityState.Deleted;

            }*/
        }

        

        public void VehicleSave(Vehicle vehicle)
        {
            applicatDbContext.Vehincles.Attach(vehicle);
            applicatDbContext.Entry(vehicle).State = EntityState.Modified;
            applicatDbContext.SaveChanges();
            DeatchAll();
        }

        private Applicat Normalize(Applicat applicat)
        {
            foreach(var ai in applicat.ApplicatItems)
            {
                foreach(var v in applicat.ApplicatItems.FindAll(a => a.Vehicle.Id == ai.Vehicle.Id && a.Vehicle != ai.Vehicle))
                {
                    v.Vehicle = ai.Vehicle;
                }
            }

            return applicat;
        }
            
        // Отключение отслеживания всех сущьностей.
        private void DeatchAll()
        {
            var changeEntry = applicatDbContext.ChangeTracker.Entries()
                .Where(ce => ce.State != EntityState.Detached).ToList();

            foreach (var entry in changeEntry)
            {
                entry.State = EntityState.Detached;
            }
        }
    }
}
