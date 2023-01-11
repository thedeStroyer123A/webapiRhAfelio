using ProjectRh_BLL.Interfaces;
using ProjectRh_BLL.Mapper;
using ProjectRh_BLL.Models;
using ProjectRh_Repo.Entities;
using ProjectRh_Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Services
{
    public class HumanRessourceDep_Services : IHumanRessourceDepService
    {
        private readonly  HumanRessourceDep_Repo _repository;
        public HumanRessourceDep_Services()
        {
            _repository = new HumanRessourceDep_Repo();
        }
        public bool Delete(HumanRessourceDep_BLL entity)
        {
            return _repository.Delete(entity.H_RepotoH_BLL());
        }

        public HumanRessourceDep_BLL Get(int id)
        {
            return _repository.Get(id)?.H_BLLtoH_Repo();
        }

        public IEnumerable<HumanRessourceDep_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.H_BLLtoH_Repo());
        }

        public int Insert(HumanRessourceDep_BLL entity)
        {
            return _repository.Insert(entity.H_RepotoH_BLL());
        }

        public bool Update(HumanRessourceDep_BLL data)
        {
            return _repository.Update(data.H_RepotoH_BLL());
        }
    }
}
