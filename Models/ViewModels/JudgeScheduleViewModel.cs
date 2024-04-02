namespace Grading_App_Section_1.Models.ViewModels
{
    public class RoomAssignment
    {
        public string RoomNumber { get; set; }
        public int JudgesCount { get; set; }
    }

    public class JudgeScheduleViewModel
    {
        public List<Judge> Judges { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<RoomAssignment> RoomAssignments { get; set; }
    }
}
