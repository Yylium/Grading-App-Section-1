using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grading_App_Section_1.Models
{
    public class Survey_Response
    {
        [Key]
        public int survey_response_id { get; set; }
        [ForeignKey("group_id")]
        public required int group_id { get; set; }
        public required Student_Group Student_Group { get; set; }
        [ForeignKey("judge_id")]
        public required int judge_id { get; set; }
        public required Judge Judge { get; set; }
        public required int question_id { get; set; }
        public int? survey_num_response {  get; set; }
        public string? survey_text_response { get; set; }


    }
}
