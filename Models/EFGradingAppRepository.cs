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
        //These are lists for each table that has been created for ViewBag and other displaying purposes. Use them if needed. 
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

        //README BEFORE EDITING
        //Each Team (1-15) has 4 Methods that have been created here.

        //These are basic structures that each team may use for their individual purposes. 
        //For example: Method 1 - ADD, Method 2 - EDIT, Method 3 - DELETE, Method 4 - RETURN BY ID (etc.)

        //You may modify the return type, the method parameters, and then the _context variable as needed. Do not edit the context file itself. 
        //If you choose to modify those things you MUST also CHANGE where that method is referenced in the "IGradingAppRepository" to match what you changed

        //You may change the Method names, however, you must make sure the Interface matches what you change with the method. 

        //Please be careful when editing and adding methods as this will easily break the GradingApp

        //Team 1 Methods
        public void Team1Method1()
        {
        }
        public void Team1Method2()
        {
        }
        public void Team1Method3()
        {
        }
        public void Team1Method4()
        {
        }

        //Team 2 Methods
        public void Team2Method1()
        {
        }
        public void Team2Method2()
        {
        }
        public void Team2Method3()
        {
        }
        public void Team2Method4()
        {
        }

        //Team 3 Methods
        public void Team3Method1()
        {
        }
        public void Team3Method2()
        {
        }
        public void Team3Method3()
        {
        }
        public void Team3Method4()
        {
        }

        //Team 4 Methods
        public void Team4Method1()
        {
        }
        public void Team4Method2()
        {
        }
        public void Team4Method3()
        {
        }
        public void Team4Method4()
        {
        }

        //Team 5 Methods
        public void Team5Method1()
        {
        }
        public void Team5Method2()
        {
        }
        public void Team5Method3()
        {
        }
        public void Team5Method4()
        {
        }

        //Team 6 Methods
        public void Team6Method1()
        {
        }
        public void Team6Method2()
        {
        }
        public void Team6Method3()
        {
        }
        public void Team6Method4()
        {
        }

        //Team 7 Methods
        public void Team7Method1()
        {
        }
        public void Team7Method2()
        {
        }
        public void Team7Method3()
        {
        }
        public void Team7Method4()
        {
        }

        //Team 8 Methods
        public void Team8Method1()
        {
        }
        public void Team8Method2()
        {
        }
        public void Team8Method3()
        {
        }
        public void Team8Method4()
        {
        }

        //Team 9 Methods
        public void Team9Method1()
        {
        }
        public void Team9Method2()
        {
        }
        public void Team9Method3()
        {
        }
        public void Team9Method4()
        {
        }

        //Team 10 Methods
        public void Team10Method1()
        {
        }
        public void Team10Method2()
        {
        }
        public void Team10Method3()
        {
        }
        public void Team10Method4()
        {
        }

        //Team 11 Methods
        public void Team11Method1()
        {
        }
        public void Team11Method2()
        {
        }
        public void Team11Method3()
        {
        }
        public void Team11Method4()
        {
        }

        //Team 12 Methods
        public void Team12Method1()
        {
        }
        public void Team12Method2()
        {
        }
        public void Team12Method3()
        {
        }
        public void Team12Method4()
        {
        }

        //Team 13 Methods
        public void Team13Method1()
        {
        }
        public void Team13Method2()
        {
        }
        public void Team13Method3()
        {
        }
        public void Team13Method4()
        {
        }

        //Team 14 Methods
        public void Team14Method1()
        {
        }
        public void Team14Method2()
        {
        }
        public void Team14Method3()
        {
        }
        public void Team14Method4()
        {
        }

        //Team 15 Methods
        public void Team15Method1()
        {
        }
        public void Team15Method2()
        {
        }
        public void Team15Method3()
        {
        }
        public void Team15Method4()
        {
        }
    }
}
