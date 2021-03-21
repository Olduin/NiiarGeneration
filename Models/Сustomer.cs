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
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Наименование заявителя")]
        public string Name { get; set; }

        [MaxLength(30)]
        [DisplayName("Отвественное лицо")]
        public string Responsible{ get; set; }

        public override string ToString()
        {
            return Name + " [" + Responsible + "]";
        }
    }
}
