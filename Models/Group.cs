using System.ComponentModel.DataAnnotations;

namespace Grading_App_Section_1.Models
{
    public class Group
    {
        [Key]
        public int group_id { get; set; }

        [Required]
        public int section_number { get; set; }

        [Required]
        public int group_number { get; set; }

        public string submission_link { get; set; }

        [Required] 
        public int group_modifier { get; set; } = 0;
    }
}
