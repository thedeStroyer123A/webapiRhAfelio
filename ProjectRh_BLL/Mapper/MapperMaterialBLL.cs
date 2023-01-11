using ProjectRh_BLL.Models;
using ProjectRh_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Mapper
{
    public static class MapperMaterialBLL
    {
        public static Material_BLL M_BLLtoM_Repo(this Material M_repo)
        {
            return new Material_BLL
            {
                Id = M_repo.Id,
                Brand = M_repo.Brand,
                Type = M_repo.Type,
                RegistrationNumber = M_repo.RegistrationNumber,
                GrayCardNumber = M_repo.GrayCardNumber,
                ContractType = M_repo.ContractType,
                ContractName = M_repo.ContractName,


            };
        }
        public static Material  M_RepotoM_BLL(this Material_BLL ma)
        {
            return new Material
            {
                Id = ma.Id,
                Brand =ma.Brand,
                Type = ma.Type,
                RegistrationNumber = ma.RegistrationNumber,
                GrayCardNumber = ma.GrayCardNumber,
                ContractType = ma.ContractType,
                ContractName = ma.ContractName,

            };
        }
    } 
              

}
