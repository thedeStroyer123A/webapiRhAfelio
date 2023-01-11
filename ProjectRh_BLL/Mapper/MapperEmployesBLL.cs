using ProjectRh_BLL.Models;
using ProjectRh_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Mapper
{
    public static class MapperEmployesBLL
    {
        public static Employes_BLL E_BLLtoE_Repo(this Employes em_repo )
        {
            return new Employes_BLL
            {
                Id = em_repo.Id,
                FirstName = em_repo.FirstName,
                LastName = em_repo.LastName,
                DateDeNaissance = em_repo.DateDeNaissance,
                Fonction = em_repo.Fonction,
                NumeroTel = em_repo.NumeroTel,
                email = em_repo.email

            };

           
        }
        public static Employes E_RepotoE_BLL(this Employes_BLL Em)
        {
            return new Employes
            {
                Id=Em.Id,
                FirstName=Em.FirstName,
                LastName=Em.LastName,
                DateDeNaissance=Em.DateDeNaissance,
                Fonction=Em.Fonction,
                NumeroTel=Em.NumeroTel,
                email=Em.email
                
            };


        }

    }



}
