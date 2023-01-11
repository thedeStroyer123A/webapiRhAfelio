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
    public class Material_Repo : Basic_Repository.BasicRepo<int ,Material>
    {
        public Material_Repo() : base("Materials", "Id_Material")
        {

        }

        public override bool Delete(Material id)
        {
            Command cmd = new Command("P_Material_DELETE", true);
            cmd.AddParameter("Id_Material", id.Id);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Material entity)
        {
            Command cmd = new Command("P_Material_INSERT", true);
            cmd.AddParameter("@Brand", entity.Brand);
            cmd.AddParameter("@Type", entity.Type);
            cmd.AddParameter("@RegistrationNumber", entity.RegistrationNumber);
            cmd.AddParameter("@GrayCardNumber", entity.GrayCardNumber);
            cmd.AddParameter("@ContractType", entity.ContractType);
            cmd.AddParameter("@ContractName", entity.ContractName);
            return ConnectionString.ExecuteNonQuery(cmd);

        }

        public override bool Update(Material data)
        {
            Command cmd = new Command("P_Material_UPDATE", true);
            cmd.AddParameter("Id_Material", data.Id);
            cmd.AddParameter("Brand", data.Brand);
            cmd.AddParameter("Type", data.Type);
            cmd.AddParameter("RegistrationNumber", data.RegistrationNumber);
            cmd.AddParameter("GrayCardNumber", data.GrayCardNumber);
            cmd.AddParameter("ContractType", data.ContractType);
            cmd.AddParameter("ContractName", data.ContractName);
            return ConnectionString.ExecuteNonQuery(cmd)==1;
        }

        protected override Material Convert(IDataRecord dtr)
        {
            return new Material
            {
                Id = (int)dtr["Id_Material"],
                Brand = dtr["Brand"].ToString(),
                Type = dtr["Type"].ToString(),
                RegistrationNumber = dtr["RegistrationNumber"].ToString(),
                GrayCardNumber = (int)dtr["GrayCardNumber"],
                ContractType = dtr["ContractType"].ToString(),
                ContractName = dtr["ContractName"].ToString(),

            };
        }
    }
}
