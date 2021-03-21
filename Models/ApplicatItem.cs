using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NiiarGeneration.Models
{
    [Table ("ApplicatItems")]
    public class ApplicatItem
    {
        [Key]
        [DisplayName ("№п.п.")]
        public int Id { get; set; }

        [DisplayName("Заявка №")]
        public Applicat Applicat { get; set; }

        [DisplayName("Заявитель")]
        public virtual Customer Customer { get; set; }

        [DisplayName("Наименование транспорта и спецтехники")]
        public virtual Vehicle Vehicle { get; set; }

        [DisplayName("Вид проводимых работ")]
        public virtual TypeWork TypeWork { get; set; }

        [DisplayName("Дополнительное описание")]
        public string Additional_description { get; set; }

        [DisplayName("Время подачи техники")]
        public DateTime? Time_Of_Filing { get; set; }

        [DisplayName("Время окончания работы")]
        public DateTime? End_time_of_work { get; set; }

        [DisplayName("Адрес подачи техники")]
        public string Delivery_Address { get; set; }
              
    }

}