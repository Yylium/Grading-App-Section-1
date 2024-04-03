using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grading_App_Section_1.Models
{
    public class Rubric_Item_Grade
    {
        [Key]
        public int grade_id {  get; set; }

        [Required]
        [ForeignKey("Student_Group")]
        public int group_id { get; set; }
        public virtual Student_Group Student_Group { get; set; }

        [Required]
        [ForeignKey("TA")]
        public string ta_netid { get; set; }
        public virtual TA TA {get; set; }


        [Required]
        [ForeignKey("Rubric_Item")]
        public int rubric_item_id { get; set; }
        public virtual Rubric_Item Rubric_Item { get; set; }

        [Required]
        public int rubric_item_score { get; set; }

        public string? ta_comment { get; set; }


    }
}
