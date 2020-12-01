using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NET_CodeFirst.Models
{
    public class Student:Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Name")]
        public DateTime EnrollmentDate { get; set; }

        public bool? Enabled { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}