using ProjectRh_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_Repo.Entities
{
    public class Affectation_Materials : IEntity<int>
    {
        public int Id { get; set; }
       
        public DateTime Date_affectation_Material {get; set;}
        public int Id_Material {get; set;}
        public int Id_HR {get; set;}

    }
}
