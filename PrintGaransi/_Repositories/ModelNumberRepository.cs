using PrintPackingLabel.Model;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPackingLabel._Repositories
{
    public class ModelNumberRepository : IModelNumberRepository
    {
        private readonly string DBConnection;

        public ModelNumberRepository()
        {
            DBConnection = ConfigurationManager.ConnectionStrings["LSBUConnection"].ConnectionString;
        }

        public GaransiModel GetByModelCode(GaransiModel model)
        {
            GaransiModel result = new GaransiModel();
            string query = "SELECT * FROM GlobalModelCodes WHERE ModelCodeId = @ModelCodeId";

            using (SqlConnection connection = new SqlConnection(DBConnection))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.Add("@ModelCodeId", SqlDbType.VarChar).Value = model.ModelCode;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = new GaransiModel
                        {
                            GlobalCodeId = reader["GlobalCodeId"].ToString(),
                            NoReg = reader["Register"].ToString(),
                            ModelNumber = reader["ModelNumber"].ToString()
                            
                        };
                    }
                }
            }

            return result;
        }
    }
}
