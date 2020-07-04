using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NiiarGeneration.Models;

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
            return applicatDbContext.Applicats.ToList();
        }       
    }
}
