using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grading_App_Section_1.Models
{
    public class Admins_Teacher
    {
        [Key]
        public int class_number { get; set; }
        
        [Required]
        public string prof_netid { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set;}
    }
}
