using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiiarGeneration.Models;

namespace NiiarGeneration
{
    public class ApplicatEditContext
    {
        public Applicat  Applicat { get; set; }

        public List<Vehicle> Vehincles { get { return repository.GetVehincles(); } }

        public List<TypeApplicat> Types { get { return repository.GetTypes(); } }

        private Repository repository;

        public ApplicatEditContext(Repository repository)
        {
            this.repository = repository;
        }


    }
}
