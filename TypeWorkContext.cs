using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiiarGeneration.Models;

namespace NiiarGeneration
{
    public class TypeWorkContext
    {
        Repository repository;

        public List<TypeWork> TypeWorks { get;  set; }

        public TypeWorkContext(Repository repository)
        {
            this.repository = repository;
        }
    }
}
