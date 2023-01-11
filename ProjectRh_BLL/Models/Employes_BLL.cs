using ProjectRh_Repo.Interfaces;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Models
{
    public class Employes_BLL : IEntity<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Fonction { get; set; }    
        public string NumeroTel { get; set; }
        public string email { get; set; }


        
    }
}
