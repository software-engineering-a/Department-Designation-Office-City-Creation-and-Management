using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SEPROJECT.Models
{
    public class designation
    {
        [Key]
        [DisplayName("Designation Id")]
        public int des_id { get; set; }
        [Required(ErrorMessage = "Designation NAME Required!")]
        [DataType(DataType.Text)]
        [DisplayName("Designation Name")]
        public string des_name { get; set; }
        [Required(ErrorMessage = "Status Required!")]
        [DataType(DataType.Text)]
        [DisplayName("Status")]
        public string status { get; set; }

    }
}