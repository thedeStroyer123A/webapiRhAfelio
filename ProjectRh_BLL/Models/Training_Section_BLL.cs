using ProjectRh_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Models
{
    public class Training_Section_BLL : IEntity<int>
    {
        public int Id { get; set; } 
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Score { get; set; }
    }
}
