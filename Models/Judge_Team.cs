using System.ComponentModel.DataAnnotations;

namespace Grading_App_Section_1.Models
{
    public class Judge_Team
    {
        [Key]
        public int judge_team_id {  get; set; }
        public required int judge_team_modifier { get; set; }
    }
}
