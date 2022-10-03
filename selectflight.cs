using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class selectflight
    {
        [Key]
        public int id { get; set; }
        public string flightname { get; set; }
        public decimal timefrom { get; set; }
        public  decimal  timeto { get; set; }
        public decimal duration { get; set; }
        public decimal economyclassprice { get; set; }
        public decimal businessclassprice { get; set; }

    }
}
