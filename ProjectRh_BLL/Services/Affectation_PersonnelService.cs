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
    public class Affectation_PersonnelService : IAffectation_PersonnelService
    {
        private readonly Affectation_Personnel_Repo _repository;
        public Affectation_PersonnelService()
        {
            _repository =new Affectation_Personnel_Repo();
        }
        public bool Delete(Affectation_Personnel_BLL entity)
        {
            return _repository.Delete(entity.AP_RepotoAP_BLL());
        }

        public Affectation_Personnel_BLL Get(int id)
        {
            return _repository.Get(id)?.AP_BLLtoAP_Repo();
        }

        public IEnumerable<Affectation_Personnel_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.AP_BLLtoAP_Repo());
        }

        public int Insert(Affectation_Personnel_BLL entity)
        {
            return _repository.Insert(entity.AP_RepotoAP_BLL());
        }

        public bool Update(Affectation_Personnel_BLL data)
        {
            return _repository.Update(data.AP_RepotoAP_BLL());
        }
    }
}
