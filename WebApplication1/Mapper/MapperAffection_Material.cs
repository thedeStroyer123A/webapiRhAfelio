using ProjectRh_BLL.Models;
using WebApplication1.Models;

namespace WebApplication1.Mapper
{
    public static class MapperAffection_Material
    {
        public static Affectation_Material_C MaterialBLToClient(this Affectation_Material_BLL m_BLL)
        {
            return new Affectation_Material_C
            {
                Id = m_BLL.Id,
                Date_affectation_Material = m_BLL.Date_affectation_Material,
                Id_Material = m_BLL.Id_Material,
                Id_HR = m_BLL.Id_HR,
            };
        }

        public static Affectation_Material_BLL ClientToMaterialBL(this Affectation_Material_C affectation_Material_c)
        {
            return new Affectation_Material_BLL
            {
                Id = affectation_Material_c.Id,
                Date_affectation_Material = affectation_Material_c.Date_affectation_Material,
                Id_Material = affectation_Material_c.Id_Material,
                Id_HR = affectation_Material_c.Id_HR,
            };
        }
    }
}