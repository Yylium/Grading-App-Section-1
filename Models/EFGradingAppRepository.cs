using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Models
{
    public class EFGradingAppRepository : IGradingAppRepository
    {
        private GradingAppContext _context;

        public EFGradingAppRepository(GradingAppContext temp)
        {
            _context = temp;
        }
        //lists for each table to access for displaying purposes
        public List<Admins_Teacher> Admins_Teachers => _context.Admins_Teachers.ToList();
        public List<Judge> Judges => _context.Judges.ToList();
        public List<Judge_Team> Judge_Teams => _context.Judge_Teams.ToList();
        public List<Rubric_Item> Rubric_Items => _context.Rubric_Items.ToList();
        public List<Rubric_Item_Grade> Rubric_Item_Grades => _context.Rubric_Item_Grades.ToList();
        public List<Schedule> Schedules => _context.Schedules.ToList();
        public List<Student> Students => _context.Students.ToList();
        public List<Student_Group> Student_Groups => _context.Student_Groups.ToList();
        public List<Survey_Response> Survey_Responses => _context.Survey_Responses.ToList();
        public List<TA> TAs => _context.TAs.ToList();
        public List<Login_Table> Login_Tables => _context.Login_Tables.ToList();

        //Methods for adding, editing, deleting and any other functions necessary. NOT DONE
        public void AddSurveyResponse(Survey_Response response)
        {
            _context.Survey_Responses.Add(response);
            _context.SaveChanges();
        }

        public void AddRubricItemGrade(Rubric_Item_Grade grade)
        {
            _context.Rubric_Item_Grades.Add(grade);
            _context.SaveChanges();
        }

        public void AddSchedule(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
            _context.SaveChanges();
        }
    }
}
