using ProjectRh_DAL;
using ProjectRh_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_Repo.Repositories
{
    public class ControlCheck_Repo : Basic_Repository.BasicRepo<int , ControlCheck>
    {
        public ControlCheck_Repo() : base("ControlCheck" , "Id")
        {

        }

        public override bool Delete(ControlCheck id)
        {
            Command cmd = new Command("P_ControleCheck_DELETE", true);
            cmd.AddParameter("@Id", id.Id);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(ControlCheck entity)
        {
            Command cmd = new Command("P_ControlCheck_INSERT", true);
            cmd.AddParameter("@EndDateTraining", entity.EndDateTraining);
            cmd.AddParameter("@BeginingDateTrining", entity.BeginingDateTraining);
            cmd.AddParameter("@Passed", entity.Passed);
            cmd.AddParameter("@Failed", entity.Failed);
            cmd.AddParameter("@Id_HR", entity.Id_HR);
            cmd.AddParameter("Id_Trained_Employee", entity.Id_Trained_Employee);
            return ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(ControlCheck data)
        {
            Command cmd = new Command("P_ControlCheck_UPDATE", true);
            cmd.AddParameter("Id", data.Id);
            cmd.AddParameter("@EndDateTraining", data.EndDateTraining);
            cmd.AddParameter("@BeginingDateTrining", data.BeginingDateTraining);
            cmd.AddParameter("@Passed", data.Passed);
            cmd.AddParameter("@Failed", data.Failed);
            cmd.AddParameter("@Id_HR", data.Id_HR);
            cmd.AddParameter("Id_Trained_Employee", data.Id_Trained_Employee);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        protected override ControlCheck Convert(IDataRecord dtr)
        {
            return new ControlCheck
            {
                Id = (int)dtr["Id"],
                EndDateTraining = (DateTime)dtr["EndDateTraining"],
                BeginingDateTraining = (DateTime)dtr["BeginingDateTrining"],
                Passed= (bool)dtr["Passed"],
                Failed = (bool)dtr["Failed"],
                Id_HR= (int)dtr["NumeroTel"],
                Id_Trained_Employee = (int)dtr["Id_Trained_Employee"],
                


            };
        }
    }
}
