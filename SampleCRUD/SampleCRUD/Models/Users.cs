using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleCRUD.Models
{
    public class Users
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Department { get; set; }
    }
}