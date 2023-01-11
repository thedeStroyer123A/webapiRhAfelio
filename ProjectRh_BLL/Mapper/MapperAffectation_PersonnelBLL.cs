using ProjectRh_BLL.Models;
using ProjectRh_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Mapper
{
    public static class MapperAffectation_PersonnelBLL
    {
        public static Affectation_Personnel_BLL AP_BLLtoAP_Repo(this Affectation_Personnel AP_repo)
        {
            return new Affectation_Personnel_BLL
            {
                Id = AP_repo.Id,
                Date_Affectation_Personnel = AP_repo.Date_Affectation_Personnel,
                Id_HR = AP_repo.Id_HR,
                Id_Em = AP_repo.Id_Em
            };
        }

        public static  Affectation_Personnel AP_RepotoAP_BLL(this Affectation_Personnel_BLL ap)
        {
            return new Affectation_Personnel
            {
                Id = ap.Id,
                Date_Affectation_Personnel = ap.Date_Affectation_Personnel,
                Id_HR = ap.Id_HR,
                Id_Em = ap.Id_Em

            };
        }
    }
}
