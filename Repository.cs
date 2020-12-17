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
        }

        public IList<Applicat> ApplicatGetList() 
        {
            return applicatDbContext.Applicats.AsNoTracking().ToList();
        }   
        
        public Applicat ApplicatGet(long id)
        {
            //  Applicat applicat = applicatDbContext.Applicats.Attach(applicat.ApplicatItems.).AsNoTracking().FirstOrDefault(ac => ac.Id == id);
            return applicatDbContext.Applicats.AsNoTracking().FirstOrDefault(ac => ac.Id == id);
        }

        public void ApplicateAdd(Applicat applicat)
        {
            applicatDbContext.Applicats.Add(applicat);
            applicatDbContext.SaveChanges();
        }

        public void ApplicateSave(Applicat applicat) 
        {
            applicatDbContext.Applicats.Attach(applicat);
            applicatDbContext.Entry(applicat).State = EntityState.Modified;
            applicatDbContext.SaveChanges();
        }

        public List<ApplicatItem> GetApplicatItems()
        {
            return applicatDbContext.ApplicatItems.ToList();
        }

        public List<Vehincle> GetVehincles()
        {
            return applicatDbContext.Vehincles.ToList();
        }

        public Vehincle GetVehincle(long id)
        {
            return applicatDbContext.Vehincles.FirstOrDefault(vh => vh.Id == id);
        }

        public List<TypeApplicat> GetTypes()
        {
            return applicatDbContext.TypeApplicates.ToList();
        }


        
    }
}
