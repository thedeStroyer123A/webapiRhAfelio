using ProjectRh_BLL.Interfaces;
using ProjectRh_BLL.Models;
using ProjectRh_Repo.Repositories;
using ProjectRh_BLL.Mapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Services
{
    public class Material_Services : IMaterialService
    {
        private readonly  Material_Repo _repository;
        public Material_Services()
        {
            _repository = new Material_Repo();
        }
        public bool Delete(Material_BLL entity)
        {
            return _repository.Delete(entity.M_RepotoM_BLL());
        }

        public Material_BLL Get(int id)
        {
            return _repository.Get(id)?.M_BLLtoM_Repo();
        }

        public IEnumerable<Material_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.M_BLLtoM_Repo());
        }

        public int Insert(Material_BLL entity)
        {
            return _repository.Insert(entity.M_RepotoM_BLL());  
        }

        public bool Update(Material_BLL data)
        {
            return _repository.Update(data.M_RepotoM_BLL());
        }
    }
}
