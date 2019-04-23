using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SEPROJECT.Models
{
    public class office
    {
        [Key]
        [DisplayName("Office Id")]
        public int office_id { get; set; }
        [Required(ErrorMessage = "  City NAME Required!")]
        [DataType(DataType.Text)]
        [DisplayName("City")]
        public string City { get; set; }
        [Required(ErrorMessage = "HR Manager Required!")]
        [DataType(DataType.Text)]
        [DisplayName("HR Manager Name")]
        public string HR_manager { get; set; }
    }
}