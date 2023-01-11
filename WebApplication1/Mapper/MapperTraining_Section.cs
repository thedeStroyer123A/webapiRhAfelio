using ProjectRh_BLL.Models;
using WebApplication1.Models;

namespace WebApplication1.Mapper
{
    public static class MapperTraining_Section
    {
        public static Training_Section_C TraningSecBLtoClient(this Training_Section_BLL tr_BLL)
        {
            return new Training_Section_C()
            {
                Id = tr_BLL.Id,
                First_Name = tr_BLL.First_Name,
                Last_Name = tr_BLL.Last_Name,
                Score = tr_BLL.Score,
            };
        }

        public static Training_Section_BLL ClienttoTrainingSecBL(this Training_Section_C training_C)
        {
            return new Training_Section_BLL()
            {
                Id = training_C.Id,
                First_Name = training_C.First_Name,
                Last_Name = training_C.Last_Name,
                Score = training_C.Score,
            };
        }
    }
}
