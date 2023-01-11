using ProjectRh_BLL.Models;
using WebApplication1.Models;

namespace WebApplication1.Mapper
{
    public static class MapperEmployes 
    {
        public static Employes_C EmployésBLToClient(this Employes_BLL e_BLL)
        {
            return new Employes_C()
            {
                Id  = e_BLL.Id,
                FirstName = e_BLL.FirstName,
                LastName = e_BLL.LastName,
                DateDeNaissance = e_BLL.DateDeNaissance,
                Fonction = e_BLL.Fonction,
                NumeroTel = e_BLL.NumeroTel,
                email = e_BLL.email

            };
        }
        public static  Employes_BLL ClientToEmployésBL(this Employes_C employés_C)
        {
            return new Employes_BLL()
            {
                Id = employés_C.Id,
                FirstName = employés_C.FirstName,
                LastName = employés_C.LastName,
                DateDeNaissance = employés_C.DateDeNaissance,
                Fonction = employés_C.Fonction,
                NumeroTel = employés_C.NumeroTel,
                email = employés_C.email


            };
        }
    }

}

