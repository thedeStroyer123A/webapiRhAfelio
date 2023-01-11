using ProjectRh_BLL.Models;
using ProjectRh_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Mapper
{
    public static class MapperAffectation_MaterialBLL
    {
        public static Affectation_Material_BLL AM_BLLtoAP_Repo( this Affectation_Materials AM_repo)
        {
            return new Affectation_Material_BLL
            {
                Id = AM_repo.Id,
                Date_affectation_Material = AM_repo.Date_affectation_Material,
                Id_Material=AM_repo.Id_Material,
                Id_HR = AM_repo.Id_HR

            };
        }
        public static Affectation_Materials AP_RepotoAM_BLL(this Affectation_Material_BLL am )
        {
            return new Affectation_Materials
            {
                Id = am.Id,
                Date_affectation_Material = am.Date_affectation_Material,
                Id_Material = am.Id_Material,
                Id_HR = am.Id_HR

            };
        }

    }
}
