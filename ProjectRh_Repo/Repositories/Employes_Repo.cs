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
    public class Employes_Repo : Basic_Repository.BasicRepo<int, Employes>
    {
        public Employes_Repo() :base("Employes", "Id_Em")
        {

        }
        public override bool Delete(Employes id)
        {
            Command cmd = new Command("P_Employes_DELETE", true);
            cmd.AddParameter("@Id_Em", id.Id);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Employes entity)
        {
            Command cmd = new Command("P_Employes_INSERT", true);
            cmd.AddParameter("@FirstName", entity.FirstName);
            cmd.AddParameter("@LastName", entity.LastName);
            cmd.AddParameter("@DateDeNaissance",entity.DateDeNaissance);
            cmd.AddParameter("@Fonction", entity.Fonction);
            cmd.AddParameter("@NumeroTel", entity.NumeroTel);
            cmd.AddParameter("email" , entity.email);
            return ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(Employes data)
        {
            Command cmd = new Command("P_Employes_UPDATE", true);
            cmd.AddParameter("Id_Em",data.Id);
            cmd.AddParameter("FirstName", data.FirstName);
            cmd.AddParameter("LastName", data.LastName);
            cmd.AddParameter("DateDeNaissance", data.DateDeNaissance);
            cmd.AddParameter("Fonction", data.Fonction);
            cmd.AddParameter("NumeroTel", data.NumeroTel);
            cmd.AddParameter("email", data.email);
            return ConnectionString.ExecuteNonQuery(cmd)==1;
        }

        protected override Employes Convert(IDataRecord dtr)
        {
            return new Employes
            {
                Id =(int)dtr["Id_Em"],
                FirstName = dtr["FirstName"].ToString(),
                LastName = dtr["LastName"].ToString(),
                DateDeNaissance = (DateTime)dtr["DateDeNaissance"],
                Fonction =  dtr["Fonction"].ToString(),
                NumeroTel = dtr["NumeroTel"].ToString(),
                email = dtr["email"].ToString(),


            };
        }
    }
}
