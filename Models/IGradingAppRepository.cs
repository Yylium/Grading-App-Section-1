using Microsoft.EntityFrameworkCore;

namespace Grading_App_Section_1.Models
{
    public interface IGradingAppRepository
    {
        List<Admins_Teacher> Admins_Teachers { get; }
        List<Judge> Judges { get; }
        List<Judge_Team> Judge_Teams { get; }
        List<Rubric_Item> Rubric_Items { get; }
        List<Rubric_Item_Grade> Rubric_Item_Grades { get; }
        List<Schedule> Schedules { get; }
        List<Student> Students { get; }
        List<Student_Group> Student_Groups { get; }
        List<Survey_Response> Survey_Responses { get; }
        List<TA> TAs { get; }
        List<Login_Table> Login_Tables { get; }
        public void AddSurveyResponse(Survey_Response response);
        public void AddRubricItemGrade(Rubric_Item_Grade grade);
        public void AddSchedule(Schedule schedule);

    }
}
