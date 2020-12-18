using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiiarGeneration.Models;

namespace NiiarGeneration
{
    public class VehicleEditContext
    {
        private Repository repository;

        public List<Vehicle> Vehincles { get; set; }

        public VehicleEditContext(Repository repository)
        {
            this.repository = repository;
        }

        
        
    }
}
