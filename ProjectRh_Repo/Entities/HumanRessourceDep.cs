using ProjectRh_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_Repo.Entities
{
    public class HumanRessourceDep : IEntity<int>
    {
        
        public int Id { get; set; }
        public string HRDepartmentName { get; set; }
        public int RH_manager_Id { get; set; }   
        public int Location_Id { get; set; }
        public string email { get; set; }
        



    }
}
