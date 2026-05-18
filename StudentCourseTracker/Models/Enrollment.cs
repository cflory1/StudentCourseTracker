using System.ComponentModel.DataAnnotations;

namespace StudentCourseTracker.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public int CourseId { get; set; }
        public Course? Course { get; set; }

        [Display(Name = "Date Enrolled")]
        public DateTime DateEnrolled { get; set; } = DateTime.Now;

        public string? Grade { get; set; } = "In Progress";
    }
}