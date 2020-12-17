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
        
        public List<Vehincle> Vehincles { get; set; }

        private Repository repository;

        public VehicleEditContext(Repository repository)
        {
            this.repository = repository;
        }
    }
}
