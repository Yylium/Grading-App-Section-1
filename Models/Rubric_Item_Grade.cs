using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grading_App_Section_1.Models
{
    public class Rubric_Item_Grade
    {
        [Key]
        public int grade_id {  get; set; }

        [Required]
        [ForeignKey("group_id")]
        public int group_id { get; set; }
        public Student_Group Student_Group { get; set; }

        [Required]
        [ForeignKey("ta_netid")]
        public string ta_netid { get;}


        [Required]
        [ForeignKey("rubric_item_id")]
        public int rubric_item_id { get; set; }

        [Required]
        public int rubric_item_score { get; set; }

        public string? ta_comment { get; set; }


    }
}
