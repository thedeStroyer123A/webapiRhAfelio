using ProjectRh_BLL.Models;
using WebApplication1.Models;

namespace WebApplication1.Mapper
{
    public static class MapperHumanRessourceDep
    {
        public static HumanRessourceDep_C HumanRBLToClient(this HumanRessourceDep_BLL HR_BLL)
        {
            return new HumanRessourceDep_C()
            {
                Id = HR_BLL.Id,
                HRDepartmentName = HR_BLL.HRDepartmentName,
                RH_manager_Id = HR_BLL.RH_manager_Id,
                Location_Id = HR_BLL.Location_Id,
                email = HR_BLL.email,
               
            };

        }
        public static HumanRessourceDep_BLL ClientToHumanRBL(this HumanRessourceDep_C humanRessourceDep_C)
        {
            return new HumanRessourceDep_BLL()
            {
                Id = humanRessourceDep_C.Id,
                HRDepartmentName= humanRessourceDep_C.HRDepartmentName,
                RH_manager_Id= humanRessourceDep_C.RH_manager_Id,
                Location_Id= humanRessourceDep_C.Location_Id,
                email= humanRessourceDep_C.email,
                
            };

        }
    }
}
