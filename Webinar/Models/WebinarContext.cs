using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webinar.Models
{
    public class WebinarContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public System.Data.Entity.DbSet<Webinar.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<Webinar.Models.StudentCourse> StudentCourses { get; set; }
    }
}