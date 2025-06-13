
using System.ComponentModel.DataAnnotations.Schema;

[Table("Course")]
public class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; }
    public decimal Rating { get; set; }

}