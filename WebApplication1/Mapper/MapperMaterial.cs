using ProjectRh_BLL.Models;
using WebApplication1.Models;

namespace WebApplication1.Mapper
{
    public static class MapperMaterial
    {
        public static Material_C MaterialBLTOClient(this Material_BLL M_BLL)
        {
            return new Material_C()
            {
                Id = M_BLL.Id,
                Brand = M_BLL.Brand,
                Type = M_BLL.Type,
                RegistrationNumber = M_BLL.RegistrationNumber,
                GrayCardNumber = M_BLL.GrayCardNumber,
                ContractType = M_BLL.ContractType,
                ContractName = M_BLL.ContractName

            };
        }


        public static Material_BLL ClientToMaterialBl(this Material_C material_C)
        {
            return new Material_BLL()
            {
                Id=material_C.Id,
                Brand=material_C.Brand,
                Type=material_C.Type,
                RegistrationNumber=material_C.RegistrationNumber,
                GrayCardNumber=material_C.GrayCardNumber,
                ContractType=material_C.ContractType,
                ContractName=material_C.ContractName

            };
        }
    }
}
