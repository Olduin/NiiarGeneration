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

        public List<Vehicle> Vehincles { get { return repository.VehicleGetList(); } }

        public List<TypeApplicat> Types { get { return repository.GetTypesList(); } }

        public List<Customer> Customers { get { return repository.CustomerGetList(); } }

        public List<TypeWork> TypeWorks { get { return repository.TypeWorkGetList(); } }

        private List<ApplicatItem> deletedItems;

        public void DeleteItem(ApplicatItem applicatItem)
        {
            deletedItems.Add(applicatItem);
            Applicat.ApplicatItems.Remove(applicatItem);
        }

        

        private Repository repository;

        public ApplicatEditContext(Repository repository)
        {
            this.repository = repository;
        }


    }
}
