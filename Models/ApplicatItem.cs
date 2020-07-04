using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiiarGeneration.Models
{
    [Table ("ApplicatItems")]
    public class ApplicatItem
    {
        [Key]
        public int Id { get; set; } 
        public Applicat Applicat { get; set; }
        public string Responsible_Customer { get; set; }
        public Vehincle Vehicle { get; set; }
        public string Description_Work { get; set; }
        public DateTime? Time_Of_Filingr { get; set; }
        public DateTime? Duration_Of_Use { get; set; }
        public string Delivery_Address { get; set; }
    }
}