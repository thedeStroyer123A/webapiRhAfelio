using ProjectRh_Repo.Interfaces;

namespace WebApplication1.Models
{
    public class Training_Section_C : IEntity<int>
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }   
        public int Score { get; set; }
    }
}
