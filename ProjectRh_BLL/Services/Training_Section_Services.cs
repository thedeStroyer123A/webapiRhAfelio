using ProjectRh_BLL.Interfaces;
using ProjectRh_BLL.Mapper;
using ProjectRh_BLL.Models;
using ProjectRh_Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Services
{
    public class Training_Section_Services :ITraining_SectionService
    {
        private readonly  Training_Section_Repo _repository;
        public Training_Section_Services()
        {
            _repository = new Training_Section_Repo();  
        }

        public bool Delete(Training_Section_BLL entity)
        {
            return _repository.Delete(entity.T_RepotoT_BLL());
        }

        public Training_Section_BLL Get(int id)
        {
            return _repository.Get(id)?.T_BLLtoT_Repo();
        }

        public IEnumerable<Training_Section_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.T_BLLtoT_Repo());
        }

        public int Insert(Training_Section_BLL entity)
        {
            return _repository.Insert(entity.T_RepotoT_BLL());
        }

        public bool Update(Training_Section_BLL data)
        {
            return _repository.Update(data.T_RepotoT_BLL());
        }
    }
}
