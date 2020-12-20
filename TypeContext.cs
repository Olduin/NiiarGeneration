using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiiarGeneration.Models;

namespace NiiarGeneration
{
    public class TypeContext
    {
        private Repository repository;

        public List<TypeApplicat> Types{ get; set; }

        public TypeContext(Repository repository)
        {
            this.repository = repository;
        }
    }


}
