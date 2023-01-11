using ProjectRh_Repo.Interfaces;

namespace WebApplication1.Models
{
    public class Material_C : IEntity<int>
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string RegistrationNumber { get; set; }
        public int GrayCardNumber { get; set; }
        public string ContractType { get; set; }    
        public string ContractName { get; set; }




    }
}
