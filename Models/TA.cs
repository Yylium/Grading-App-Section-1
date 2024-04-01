using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grading_App_Section_1.Models
{
    public class TA
    {
        [Key]
        public string ta_netid { get; set; }

        [ForeignKey("class_number")]
        public int class_number { get; set; }
        public Admins_Teacher Admins_Teacher { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set;}

    }
}
