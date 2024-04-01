using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Reflection.Emit;

namespace Grading_App_Section_1.Models
{
    public class GradingAppContext : DbContext
    {

        public GradingAppContext(DbContextOptions<GradingAppContext> options) : base(options)
        { }

        public DbSet<Admins_Teacher> Admins_Teachers { get; set; }
        public DbSet<Judge> Judges { get; set; }
        public DbSet<Judge_Team> Judge_Teams { get; set; }
        public DbSet<Rubric_Item> Rubric_Items { get; set; }
        public DbSet<Rubric_Item_Grade> Rubric_Item_Grades { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_Group> Student_Groups { get; set;}
        public DbSet<Survey_Response> Survey_Responses { get; set; }
        public DbSet<TA> TAs { get; set; }
        public DbSet<Login_Table> Login_Tables { get; set; }
    }

}
