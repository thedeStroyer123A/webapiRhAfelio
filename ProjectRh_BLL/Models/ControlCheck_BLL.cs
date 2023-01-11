using ProjectRh_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Models
{
    public class ControlCheck_BLL : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime EndDateTraining { get; set; }
        public DateTime BeginingDateTraining { get; set; }
        public bool Passed { get; set; }
        public bool Failed { get; set; }
        public int Id_HR { get; set; }
        public int Id_Trained_Employee { get; set; }

    }
}
