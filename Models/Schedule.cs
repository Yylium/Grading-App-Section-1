using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grading_App_Section_1.Models
{
    public class Schedule
    {
        [Key]
        public int schedule_id {  get; set; }
        
        [ForeignKey("judge_team_id")]
        public int? judge_team_id { get; set; }
        public Judge_Team Judge_Team { get; set; }

        [ForeignKey("group_id")]
        public int? group_id { get; set;  }
        public Student_Group Student_Group { get; set; }
        public required string schedule_room { get; set;}
        public required int schedule_time { get; set; }

    }
}


