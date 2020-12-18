﻿using System;
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
            return applicatDbContext.Applicats.AsNoTracking().FirstOrDefault(ac => ac.Id == id);
        }

        public void ApplicateAdd(Applicat applicat)
        {
            applicatDbContext.Applicats.Add(applicat);
            applicatDbContext.SaveChanges();
            DeatchAll();
        }

        public void ApplicateSave(Applicat applicat) 
        {
            applicatDbContext.Applicats.Attach(applicat);
            applicatDbContext.Entry(applicat).State = EntityState.Modified;
            foreach(var ai in applicat.ApplicatItems)
            {
                applicatDbContext.ApplicatItems.Attach(ai);
                applicatDbContext.Entry(ai).State = EntityState.Modified;
            }
            applicatDbContext.SaveChanges();
            DeatchAll();
        }

        // Отключение отслеживания всех сущьностей.
        private void DeatchAll()
        {
            var changeEntry = applicatDbContext.ChangeTracker.Entries()
                .Where(ce => ce.State != EntityState.Detached).ToList();

            foreach(var entry in changeEntry)
            {
                entry.State = EntityState.Detached;
            }
        }
    }
}
