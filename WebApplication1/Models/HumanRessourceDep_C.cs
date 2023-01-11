using ProjectRh_Repo.Interfaces;

namespace WebApplication1.Models
{
    public class HumanRessourceDep_C :IEntity<int>
    {
        public int Id { get; set; }
        public string HRDepartmentName { get; set; }
        public int RH_manager_Id { get; set; }
        public int Location_Id { get; set; }
        public string email { get; set; }
        public bool IsAdmin { get; set; }
        

    }
}
