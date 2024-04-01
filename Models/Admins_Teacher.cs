using System.ComponentModel.DataAnnotations;

namespace Grading_App_Section_1.Models
{
    public class Admins_Teacher
    {
        [Key]
        public string prof_netid { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set;}

        public string? class_number { get; set; }


    }
}
