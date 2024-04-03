using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grading_App_Section_1.Models
{
    public class Judge
    {
        [Key]
        public int judge_id { get; set; }
        public required string first_name { get; set; }
        public required string last_name { get; set; }
        [ForeignKey("judge_team_id")]
        public int? judge_team_id { get; set; }
        public Judge_Team? Judge_Team { get; set; }

    }
}
