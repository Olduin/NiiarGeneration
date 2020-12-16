using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiiarGeneration.Models
{
    [Table ("Applicates")]
    public class Applicat
    {
        [Key]
        [Display(Name = "№")]
        public int Id { get; set; }

        [Display(Name = "Дата")]
        public DateTime Date{ get; set; }

        [Display(Name = "Тип заявки")]
        public virtual TypeApplicat Type { get; set; }

        [Display(Name = "Список")]
        public virtual List<ApplicatItem> ApplicatItems{ get; set; }
        
    }   
}
