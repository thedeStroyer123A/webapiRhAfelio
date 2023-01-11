using ProjectRh_BLL.Models;
using ProjectRh_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Mapper
{
    public static  class MapperHumanRessourceDepBLL
    {
        public static HumanRessourceDep_BLL H_BLLtoH_Repo(this HumanRessourceDep H_repo)
        {
            return new HumanRessourceDep_BLL
            {
                Id = H_repo.Id,
                HRDepartmentName = H_repo.HRDepartmentName,
                RH_manager_Id = H_repo.RH_manager_Id,
                Location_Id = H_repo.Location_Id,
                email = H_repo.email,
                
            };
        }

        public static HumanRessourceDep H_RepotoH_BLL(this HumanRessourceDep_BLL Hr)
        {
            return new HumanRessourceDep
            {
                Id = Hr.Id,
                HRDepartmentName = Hr.HRDepartmentName,
                RH_manager_Id = Hr.RH_manager_Id,
                Location_Id = Hr.Location_Id,
                email =Hr.email,
                
            };
        }

    }
}
