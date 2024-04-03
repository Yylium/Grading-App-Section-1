using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grading_App_Section_1.Models
{
    public class Student
    {
        [Key]
        public string student_netid { get; set; }
        [ForeignKey("Student_Group")]
        public int group_id { get; set;  }
        public virtual Student_Group Student_Group { get; set; }
        [Required]
        public string first_name { get; set; }
        [Required]
        public string last_name { get; set;}

        [Required]
        public int student_modifier { get; set; }

    }
}
