using ProjectRh_BLL.Models;
using WebApplication1.Models;

namespace WebApplication1.Mapper
{
    public static class MapperControlCheck
    {
        public static ControlCheck_C ControlCheckBLtoClient(this ControlCheck_BLL CC_BL)
        {
            return new ControlCheck_C
            {
                Id = CC_BL.Id,
                EndDateTraining = CC_BL.EndDateTraining,
                BeginingDateTraining = CC_BL.BeginingDateTraining,
                Passed = CC_BL.Passed,
                Failed = CC_BL.Failed,
                Id_HR = CC_BL.Id_HR,
                Id_Trained_Employee = CC_BL.Id_Trained_Employee

            };
        }

        public static ControlCheck_BLL ClienttoControlCheckBL(this ControlCheck_C controlcheck_c)
        {
            return new ControlCheck_BLL
            {
                Id = controlcheck_c.Id,
                EndDateTraining = controlcheck_c.EndDateTraining,
                BeginingDateTraining = controlcheck_c.BeginingDateTraining,
                Passed = controlcheck_c.Passed,
                Failed = controlcheck_c.Failed,
                Id_HR = controlcheck_c.Id_HR,
                Id_Trained_Employee = controlcheck_c.Id_Trained_Employee
            };
        }
    }
}
