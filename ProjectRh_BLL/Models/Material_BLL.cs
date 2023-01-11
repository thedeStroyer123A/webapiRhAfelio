using ProjectRh_Repo.Entities;
using ProjectRh_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Models
{
    public class Material_BLL : IEntity<int>
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
