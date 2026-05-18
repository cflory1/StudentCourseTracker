using System.ComponentModel.DataAnnotations;

namespace StudentCourseTracker.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required]
        public string Instructor { get; set; }

        [Display(Name = "Credit Hours")]
        public int Credits { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}