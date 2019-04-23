using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SEPROJECT.Models
{
    public class department
    {
        [Key]
        [DisplayName("Department Id")]
        public int dep_id { get; set; }
        [Required(ErrorMessage = "Department NAME Required!")]
        [DataType(DataType.Text)]
        [DisplayName("Department Name")]
        public string dep_name { get; set; }
        [Required(ErrorMessage = "Department Manager Required!")]
        [DataType(DataType.Text)]
        [DisplayName("Manager Name")]
        public string dep_manager { get; set; }
    }
}