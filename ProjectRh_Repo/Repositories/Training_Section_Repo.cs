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
    public class Training_Section_Repo : Basic_Repository.BasicRepo<int,Training_Section>
    {
        public Training_Section_Repo() : base("Training_Section", "Id_Trained_Employee")
        {

        }

        public override bool Delete(Training_Section id)
        {
            Command cmd = new Command("P_Training_Section_DELETE", true);
            cmd.AddParameter("Id_Trained_Employee", id.Id);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Training_Section entity)
        {
            Command cmd = new Command("P_Training_Section_INSERT", true);
            cmd.AddParameter("@First_Name",entity.First_Name);
            cmd.AddParameter("@Last_Name",entity.Last_Name);
            cmd.AddParameter("@Score", entity.Score);
            return ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(Training_Section data)
        {
            Command cmd = new Command("P_Training_Section_UPDATE", true);
            cmd.AddParameter("Id_Trained_Employee", data.Id);
            cmd.AddParameter("First_Name", data.First_Name);
            cmd.AddParameter("Last_Name",data.Last_Name);
            cmd.AddParameter("Score",data.Score);
            return ConnectionString.ExecuteNonQuery(cmd)==1;
        }

        protected override Training_Section Convert(IDataRecord dtr)
        {
            return new Training_Section
            {
                Id = (int)dtr["id_Trained_Employee"],
                First_Name = dtr["First_Name"].ToString(),
                Last_Name = dtr["Last_Name"].ToString(),
                Score = (int)dtr["Score"]
            };
        }
    }
}
