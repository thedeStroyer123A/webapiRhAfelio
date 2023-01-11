using ProjectRh_Repo.Interfaces;

namespace WebApplication1.Models
{
    public class Affectation_Material_C :IEntity<int>
    {
        public int Id { get; set; }
        public int Id_Affectation_Material { get; set; }
        public DateTime Date_affectation_Material { get; set; }
        public int Id_Material { get; set; }
        public int Id_HR { get; set; }
    }
}
