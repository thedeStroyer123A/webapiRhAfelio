using ProjectRh_BLL.Models;
using WebApplication1.Models;

namespace WebApplication1.Mapper
{
    public static class MapperAffectation_Personnel
    {
        public static Affectation_Personnel_C AffectationEBLToClient(this Affectation_Personnel_BLL AP_BLL)
        {
            return new Affectation_Personnel_C()
            {
                Id = AP_BLL.Id,
                Date_Affectation_Personnel = AP_BLL.Date_Affectation_Personnel,
                Id_HR = AP_BLL.Id_HR,
                Id_Em = AP_BLL.Id_Em,

            };
        }

        public static Affectation_Personnel_BLL ClientToAffectationEBL(this Affectation_Personnel_C affectation_Personnel_C)
        {
            return new Affectation_Personnel_BLL()
            {
                Id = affectation_Personnel_C.Id,
                Date_Affectation_Personnel = affectation_Personnel_C.Date_Affectation_Personnel,
                Id_HR = affectation_Personnel_C.Id_HR,
                Id_Em = affectation_Personnel_C.Id_Em
            };
        }
    }
}
