using ProjectRh_BLL.Models;
using ProjectRh_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Mapper
{
    public static class MapperControlCheckBLL
    {
        public static ControlCheck_BLL CC_BLLtoCC_Repo(this ControlCheck CC_repo)
        {
            return new ControlCheck_BLL
            {
                Id = CC_repo.Id,
                EndDateTraining = CC_repo.EndDateTraining,
                BeginingDateTraining = CC_repo.BeginingDateTraining,
                Passed = CC_repo.Passed,
                Failed = CC_repo.Failed,
                Id_HR = CC_repo.Id_HR,
                Id_Trained_Employee = CC_repo.Id_Trained_Employee

            };

        }

        public static ControlCheck CC_RepotoCC_BLL(this ControlCheck_BLL cc )
        {
            return new ControlCheck
            {
                Id=cc.Id,
                EndDateTraining=cc.EndDateTraining,
                BeginingDateTraining=cc.BeginingDateTraining,
                Passed=cc.Passed,
                Failed=cc.Failed,
                Id_HR=cc.Id_HR,
                Id_Trained_Employee=cc.Id_Trained_Employee 

            };
        }
    }   

}
