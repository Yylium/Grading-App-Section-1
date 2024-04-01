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

        //READ the README in the "EFGradingAppRepository.cs" file before editing these methods.

        //Team1 Methods
        public void Team1Method1();
        public void Team1Method2();
        public void Team1Method3();
        public void Team1Method4();

        //Team2 Methods
        public void Team2Method1();
        public void Team2Method2();
        public void Team2Method3();
        public void Team2Method4();

        //Team3 Methods
        public void Team3Method1();
        public void Team3Method2();
        public void Team3Method3();
        public void Team3Method4();

        //Team4 Methods
        public void Team4Method1();
        public void Team4Method2();
        public void Team4Method3();
        public void Team4Method4();

        //Team5 Methods
        public void Team5Method1();
        public void Team5Method2();
        public void Team5Method3();
        public void Team5Method4();

        //Team6 Methods
        public void Team6Method1();
        public void Team6Method2();
        public void Team6Method3();
        public void Team6Method4();

        //Team7 Methods

        public void Team7Method1();
        public void Team7Method2();
        public void Team7Method3();
        public void Team7Method4();

        //Team8 Methods
        public void Team8Method1();
        public void Team8Method2();
        public void Team8Method3();
        public void Team8Method4();

        //Team9 Methods
        public void Team9Method1();
        public void Team9Method2();
        public void Team9Method3();
        public void Team9Method4();

        //Team10 Methods
        public void Team10Method1();
        public void Team10Method2();
        public void Team10Method3();
        public void Team10Method4();

        //Team11 Methods
        public void Team11Method1();
        public void Team11Method2();
        public void Team11Method3();
        public void Team11Method4();

        //Team12 Methods
        public void Team12Method1();
        public void Team12Method2();
        public void Team12Method3();
        public void Team12Method4();

        //Team13 Methods
        public void Team13Method1();
        public void Team13Method2();
        public void Team13Method3();
        public void Team13Method4();

        //Team14 Methods
        public void Team14Method1();
        public void Team14Method2();
        public void Team14Method3();
        public void Team14Method4();

        //Team15 Methods
        public void Team15Method1();
        public void Team15Method2();
        public void Team15Method3();
        public void Team15Method4();

    }
}
