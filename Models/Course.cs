using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecture { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string Place { get; set; }

        public DateTime DateTime { get; set; }
        public Category category { get; set; }

        public byte CategoryId { get; set; }
    }
}