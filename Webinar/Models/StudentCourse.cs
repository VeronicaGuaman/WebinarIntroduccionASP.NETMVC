using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webinar.Models
{
    public class StudentCourse
    {
        [Key]
        public int StudentCourse_ID { get; set; }

        [Display(Name = "Estudiante")]
        public int Student_ID { get; set; }

        [Display(Name = "Curso")]
        public int Course_ID { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

    }
}