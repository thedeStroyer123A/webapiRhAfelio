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
    public class Employes_Services : IEmployesService
    {
        private readonly Employes_Repo _repository;
        public Employes_Services()
        {
            _repository = new Employes_Repo();
        }
        public bool Delete(Employes_BLL entity)
        {
            return _repository.Delete(entity.E_RepotoE_BLL());
        }

        public Employes_BLL Get(int id)
        {
            return _repository.Get(id)?.E_BLLtoE_Repo();
        }

        public IEnumerable<Employes_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.E_BLLtoE_Repo());
        }

        public int Insert(Employes_BLL entity)
        {
            return _repository.Insert(entity.E_RepotoE_BLL());
        }

        public bool Update(Employes_BLL data)
        {
            return _repository.Update(data.E_RepotoE_BLL());
        }
    }
}
