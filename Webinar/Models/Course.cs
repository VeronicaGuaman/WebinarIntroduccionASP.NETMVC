using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webinar.Models
{
    public class Course
    {
        [Key]
        public int Course_ID { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(50, ErrorMessage =
         "The field {0} can contain maximun {1} and minimum {2} characters",
         MinimumLength = 3)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]

        public decimal Price { get; set; }

        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }
}