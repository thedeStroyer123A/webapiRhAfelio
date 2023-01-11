using ProjectRh_Repo.Interfaces;

namespace WebApplication1.Models
{
    public class Affectation_Personnel_C : IEntity<int>
    {
        public int Id { get; set; }
        
        public DateTime Date_Affectation_Personnel { get; set; }
        public int Id_HR { get; set; }
        public int Id_Em { get; set; }
    }
}
