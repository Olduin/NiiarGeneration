using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace NiiarGeneration.Models
{
    [Table("TypeWorks")]

    public class TypeWork
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Наименование работы")]
        public string Name { get; set; }

    }
}
