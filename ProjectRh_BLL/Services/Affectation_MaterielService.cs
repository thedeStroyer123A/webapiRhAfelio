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
    public class Affectation_MaterielService : IAffectation_MaterialService
    {
        private readonly Affectation_Material_Repo _repository;
        public Affectation_MaterielService()
        {
            _repository = new Affectation_Material_Repo();
        }
        public bool Delete(Affectation_Material_BLL entity)
        {
            return _repository.Delete(entity.AP_RepotoAM_BLL());
        }

        public Affectation_Material_BLL Get(int id)
        {
            return _repository.Get(id)?.AM_BLLtoAP_Repo();
        }

        public IEnumerable<Affectation_Material_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.AM_BLLtoAP_Repo());
        }

        public int Insert(Affectation_Material_BLL entity)
        {
            return _repository.Insert(entity.AP_RepotoAM_BLL());
        }

        public bool Update(Affectation_Material_BLL data)
        {
            return _repository.Update(data.AP_RepotoAM_BLL());
        }
    }
}
