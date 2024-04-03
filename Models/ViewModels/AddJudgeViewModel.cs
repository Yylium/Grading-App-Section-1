using System.ComponentModel.DataAnnotations;

namespace Grading_App_Section_1.Models.ViewModels
{
    public class AddJudgeViewModel
    {
        [Required(ErrorMessage = "First Name is required")]
        public string first_name { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string last_name { get; set; }
        //Need to set password- here or another file?
        [Required(ErrorMessage = "Password is required")]
        public string password_hash { get; set; }
        // If a judge can be assigned to multiple rooms
        // public List<string> schedule_room { get; set; }

        // If a judge can be assigned to a single room
        [Required(ErrorMessage = "Room is required")]
        public string schedule_room { get; set; }
    }
}
