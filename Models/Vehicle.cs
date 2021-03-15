using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiiarGeneration.Models
{
    [Table("Vehincles")]

    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Наименование техники")]
        public string Name { get; set; }

        [MaxLength(8)]
        [Display(Name = "Гос. Номер")]
        public string state_Number { get; set; }

        public override string ToString()
        {
            return Name + " ["+ state_Number +"]";
        }
    }
}
