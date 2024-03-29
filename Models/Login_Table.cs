using System.ComponentModel.DataAnnotations;

namespace Grading_App_Section_1.Models
{
    public class Login_Table
    {
        [Key]
        public string username { get; set; }
        public required string password_hash { get; set; }
        public required string authorization_level { get; set; }
    }
}
