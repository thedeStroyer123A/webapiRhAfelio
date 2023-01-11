using ProjectRh_Repo.Interfaces;

namespace WebApplication1.Models
{
    public class Employes_C : IEntity<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Fonction { get; set; }
        public string NumeroTel { get; set; }
        public string email { get; set; }
    }
}
