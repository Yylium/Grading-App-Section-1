using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grading_App_Section_1.Models
{
    public class Rubric_Item
    {
        [Key]
        public int rubric_item_id { get; set; }

        [Required]
        [ForeignKey("class_number")]
        public int class_number { get; set; }
        public Admins_Teacher Admins_Teacher { get; set; }

        [Required]
        public string rubric_item_text { get; set; }

        public string? rubric_item_details { get; set; }

        [Required]
        public int max_points { get; set; }


    }
}
