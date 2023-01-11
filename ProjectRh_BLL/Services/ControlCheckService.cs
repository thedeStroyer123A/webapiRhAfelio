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
    public class ControlCheckService :IControlCheckService
    {
        private readonly ControlCheck_Repo _repository;
        public ControlCheckService()
        {
            _repository = new ControlCheck_Repo();
        }
        public ControlCheck_BLL Get(int id)
        {
            return _repository.Get(id)?.CC_BLLtoCC_Repo();
        }

        public IEnumerable<ControlCheck_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.CC_BLLtoCC_Repo());
        }

        public int Insert(ControlCheck_BLL entity)
        {
            return _repository.Insert(entity.CC_RepotoCC_BLL());
        }

        public bool Update(ControlCheck_BLL data)
        {
            return _repository.Update(data.CC_RepotoCC_BLL());
        }

        public bool Delete(ControlCheck_BLL entity)
        {
            return _repository.Delete(entity.CC_RepotoCC_BLL());
        }

        
    }
}
