using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grading_App_Section_1.Models
{
    public class Student
    {
        [Key]
        public int student_netid { get; set; }
        [ForeignKey("group_id")]
        public required int group_id { get; set;  }
        public required Student_Group Student_Group { get; set; }
        public required string first_name { get; set; }
        public required string last_name { get; set;}

        public required int student_modifier { get; set; }

    }
}
