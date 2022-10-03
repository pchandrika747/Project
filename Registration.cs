using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Registration
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public DateTime dateofbirth { get; set; }
        public  string phonenumber { get; set; }

    }
}
