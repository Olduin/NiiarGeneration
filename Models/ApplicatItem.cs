﻿using System;
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


        public Applicat Applicat { get; set; }

        [DisplayName("Ответсвенный от заказчика")]
        public string Responsible_Customer { get; set; }

        [DisplayName("Наименование транспорта и спецтехники")]
        public Vehincle Vehicle { get; set; }

        [Display(Name = "Описание проводимых работ")]
        public string Description_Work { get; set; }

        [Display(Name = "Время подачи техники")]
        public DateTime? Time_Of_Filingr { get; set; }

        [Display(Name = "Продолжительность использования")]
        public DateTime? Duration_Of_Use { get; set; }

        [Display(Name = "Адрес подачи техники")]
        public string Delivery_Address { get; set; }
    }
}