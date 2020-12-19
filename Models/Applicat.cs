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
    //public class Applicat : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    private void OnPropertyChanged(Applicat propertyName)
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    //        }
    //    }

    //    [Key]
    //    [Display(Name = "№")]
    //    public int Id { get; set; }

    //    [Display(Name = "Дата")]
    //    public DateTime Date
    //    {
    //        get
    //        {
    //            return Date;
    //        }

    //        set
    //        {
    //            Date = value;
    //            OnPropertyChanged("Date");
    //        }
    //    }

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
