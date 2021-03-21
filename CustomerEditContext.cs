using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiiarGeneration.Models;

namespace NiiarGeneration
{
    public class CustomerEditContext
    {
        private Repository repository;

        public List<Customer> Customers { get; set; }

        public CustomerEditContext(Repository repository)
        {
            this.repository = repository;
        }
    }
}
