using ProjectRh_Repo.Interfaces;

namespace WebApplication1.Models
{
    public class ControlCheck_C : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime EndDateTraining { get; set; }
        public DateTime BeginingDateTraining { get; set; }
        public bool Passed { get; set; }
        public bool Failed { get; set; }
        public int Id_HR { get; set; }
        public int Id_Trained_Employee { get; set; }

    }
}
