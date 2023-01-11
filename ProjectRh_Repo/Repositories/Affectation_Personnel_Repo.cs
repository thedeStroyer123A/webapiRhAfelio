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
    public class Affectation_Personnel_Repo : Basic_Repository.BasicRepo<int, Affectation_Personnel>
    {
        public Affectation_Personnel_Repo() : base("Affectation_Personnel", "Id_num")
        {

        }
        public override bool Delete(Affectation_Personnel id)
        {
            Command cmd = new Command("P_Affectation_Personnel_DELETE",true);
            cmd.AddParameter("Id_num", id.Id);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;

        }

        public override int Insert(Affectation_Personnel entity)
        {
            Command cmd = new Command("P_Affectation_Personnel_INSERT",true);
            cmd.AddParameter("Date_Affectation_Personnel", entity.Date_Affectation_Personnel);
            cmd.AddParameter("Id_HR", entity.Id_HR);
            cmd.AddParameter("Id_Em", entity.Id_Em);
            return base.ConnectionString.ExecuteNonQuery(cmd);


        }

        public override bool Update(Affectation_Personnel data)
        {
            Command cmd = new Command("P_Affectation_Personnel_UPDATE",true);
            cmd.AddParameter("Id_num", data.Id);
            cmd.AddParameter("Date_Affectation_Personnel", data.Date_Affectation_Personnel);
            cmd.AddParameter("Id_RH", data.Id_HR);
            cmd.AddParameter("Id_Em", data.Id_Em);
            return base.ConnectionString.ExecuteNonQuery (cmd) == 1;
        }

        protected override Affectation_Personnel Convert(IDataRecord dtr)
        {
            return new Affectation_Personnel()
            {
                Id = (int)dtr["Id_num"],
                Date_Affectation_Personnel = (DateTime)dtr["Date_Affectation_Personnel"],
                Id_HR = (int)dtr["Id_HR"],
                Id_Em = (int)dtr["Id_Em"]


            };
        }
    }
}
