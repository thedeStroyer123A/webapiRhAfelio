using ProjectRh_BLL.Models;
using ProjectRh_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Mapper
{
    public static class MapperTraining_SectionBLL
    {
        public static Training_Section_BLL T_BLLtoT_Repo(this Training_Section T_repo)
        {
            return new Training_Section_BLL
            {
                Id = T_repo.Id,
                First_Name = T_repo.First_Name,
                Last_Name = T_repo.Last_Name,
                Score = T_repo.Score,
            };
        }

        public static Training_Section T_RepotoT_BLL(this Training_Section_BLL tr)
        {
            return new Training_Section
            {
                Id=tr.Id,
                Last_Name = tr.Last_Name,   
                First_Name = tr.First_Name,
                Score=tr.Score,
            };
        }
         
    }
}
