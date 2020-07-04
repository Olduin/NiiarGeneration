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
        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public TypeApplicat Type{ get; set; }
        public virtual List<ApplicatItem> ApplicatItems{ get; set; }
        
    }   
}
