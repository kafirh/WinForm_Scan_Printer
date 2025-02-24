using PrintPackingLabel.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrintPackingLabel._Repositories
{
    public class GaransiRepository : IGaransiRepository
    {
        private string LSBUDBPRODUCTION;

        public GaransiRepository()
        {
            LSBUDBPRODUCTION = ConfigurationManager.ConnectionStrings["LSBUConnection"].ConnectionString;
            Console.WriteLine($"Connecting to Database: {LSBUDBPRODUCTION}");
        }


        public IEnumerable<GaransiModel> GetData(string model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GaransiModel> GetAll(string location)
        {
            List<GaransiModel> models = new List<GaransiModel>();

            string query = @"
                    SELECT 
                        Result_Packing_Labels.Id,
                        Result_Packing_Labels.JenisProduk,
                        Result_Packing_Labels.ModelCode,
                        Result_Packing_Labels.ModelNumber,
                        Result_Packing_Labels.GlobalCodeId,
                        Result_Packing_Labels.SerialNumber,
                        Result_Packing_Labels.Register,
                        CONVERT(DATE, Result_Packing_Labels.ScanningDate) AS ScanningDate,
                        Result_Packing_Labels.ScanningTime,
                        Locations.LocationName AS Location,
                        AspNetUsers.Name AS OperatorId
                    FROM 
                        Result_Packing_Labels
                    INNER JOIN 
                        AspNetUsers 
                    ON 
                        Result_Packing_Labels.OperatorId = AspNetUsers.NIK
                    INNER JOIN 
                        Locations 
                    ON 
                        Result_Packing_Labels.Location = Locations.Id
                    WHERE 
                        Locations.LocationName = @Location AND CONVERT(DATE, ScanningDate) = @date
                    ORDER BY 
                        Id DESC;
                ";

            using (SqlConnection connection = new SqlConnection(LSBUDBPRODUCTION))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Location", location);
                command.Parameters.AddWithValue("@date", Convert.ToDateTime(DateTime.Today).Date);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        models.Add(new GaransiModel
                        {
                            Id = reader["Id"].ToString(),
                            JenisProduk = reader["JenisProduk"].ToString(),
                            ModelCode = reader["ModelCode"].ToString(),
                            ModelNumber = reader["ModelNumber"].ToString(),
                            GlobalCodeId = reader["GlobalCodeId"].ToString(),
                            NoSeri = reader["SerialNumber"].ToString(),
                            NoReg = reader["Register"].ToString(),
                            Date = Convert.ToDateTime(reader["ScanningDate"]).ToString("yyyy-MM-dd"),
                            ScanTime = reader["ScanningTime"].ToString(),
                            Location = reader["Location"].ToString(),
                            Inspector = reader["OperatorId"].ToString()
                        });
                    }
                }
                connection.Close();
            }
            return models;
        }


        public IEnumerable<GaransiModel> GetFilter(string serialNumber, DateTime selectedDate, string location)
        {
            List<GaransiModel> results = new List<GaransiModel>();

            string query = @"
                    SELECT 
                        Result_Packing_Labels.Id, 
                        Result_Packing_Labels.JenisProduk, 
                        Result_Packing_Labels.ModelCode, 
                        Result_Packing_Labels.ModelNumber, 
                        Result_Packing_Labels.SerialNumber,
                        Result_Packing_Labels.GlobalCodeId,
                        Result_Packing_Labels.Register, 
                        Result_Packing_Labels.ScanningDate, 
                        Result_Packing_Labels.ScanningTime, 
                        Locations.LocationName AS Location, 
                        AspNetUsers.Name AS OperatorId 
                    FROM 
                        Result_Packing_Labels 
                    INNER JOIN 
                        AspNetUsers 
                    ON 
                        Result_Packing_Labels.OperatorId = AspNetUsers.NIK 
                    INNER JOIN 
                        Locations 
                    ON 
                        Result_Packing_Labels.Location = Locations.Id 
                    WHERE 
                        SerialNumber LIKE @SerialNumber 
                        AND CAST(ScanningDate AS DATE) = @SelectedDate
                        AND Locations.LocationName = @Location
                    ORDER BY
                        Id DESC;
                    ";

            using (SqlConnection connection = new SqlConnection(LSBUDBPRODUCTION))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.Add("@SerialNumber", SqlDbType.VarChar).Value = "%" + serialNumber;
                command.Parameters.Add("@SelectedDate", SqlDbType.Date).Value = selectedDate.Date;
                command.Parameters.Add("@Location", SqlDbType.VarChar).Value = location;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var result = new GaransiModel
                        {
                            Id = reader["Id"].ToString(),
                            JenisProduk = reader["JenisProduk"].ToString(),
                            ModelCode = reader["ModelCode"].ToString(),
                            ModelNumber = reader["ModelNumber"].ToString(),
                            GlobalCodeId = reader["GlobalCodeId"].ToString(),
                            NoSeri = reader["SerialNumber"].ToString(),
                            NoReg = reader["Register"].ToString(),
                            Date = Convert.ToDateTime(reader["ScanningDate"]).ToString("yyyy-MM-dd"),
                            ScanTime = reader["ScanningTime"].ToString(),
                            Location = reader["Location"].ToString(),
                            Inspector = reader["OperatorId"].ToString()
                        };
                        results.Add(result);
                    }
                }
                connection.Close();
            }

            return results;
        }

        public void Add(GaransiModel model)
        {
            using (var connection = new SqlConnection(LSBUDBPRODUCTION))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "INSERT INTO Result_Packing_Labels (JenisProduk, ModelCode, ModelNumber, GlobalCodeId, SerialNumber, ScanningDate, ScanningTime, Location, Register, OperatorId) values (@JenisProduk, @ModelCode, @ModelNumber, @GlobalCodeId, @SerialNumber, @ScanningDate, @ScanningTime, @Location, @Register, @OperatorId)";
                command.Parameters.Add("@JenisProduk", SqlDbType.VarChar).Value = model.JenisProduk;
                command.Parameters.Add("@ModelCode", SqlDbType.VarChar).Value = model.ModelCode;
                command.Parameters.Add("@ModelNumber", SqlDbType.VarChar).Value = model.ModelNumber;
                command.Parameters.Add("@SerialNumber", SqlDbType.VarChar).Value = model.NoSeri;
                command.Parameters.Add("@GlobalCodeId", SqlDbType.VarChar).Value = model.GlobalCodeId;
                command.Parameters.Add("@ScanningDate", SqlDbType.Date).Value = model.Date;
                command.Parameters.Add("@ScanningTime", SqlDbType.Time).Value = model.ScanTime;
                command.Parameters.Add("@Location", SqlDbType.Int).Value = model.Location;
                command.Parameters.Add("@Register", SqlDbType.VarChar).Value = model.NoReg;
                command.Parameters.Add("@OperatorId", SqlDbType.VarChar).Value = model.inspectorId;
                Console.WriteLine($"JenisProduk: {model.JenisProduk}");
                Console.WriteLine($"ModelCode: {model.ModelCode}");
                Console.WriteLine($"ModelNumber: {model.ModelNumber}");
                Console.WriteLine($"SerialNumber: {model.NoSeri}");
                Console.WriteLine($"ScanningDate: {model.Date}");
                Console.WriteLine($"ScanningTime: {model.ScanTime}");
                Console.WriteLine($"Location: {model.Location}");
                Console.WriteLine($"Register: {model.NoReg}");
                Console.WriteLine($"OperatorId: {model.inspectorId}");

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public List<string> JenisProduk()
        {
            List<string> dataList = new List<string>();

            using (SqlConnection connection = new SqlConnection(LSBUDBPRODUCTION))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM ProductType";
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        dataList.Add(reader["ProductName"].ToString());
                    }

                    reader.Close();
                }
                connection.Close();
            }
            return dataList;
        }

        public IEnumerable<GaransiModel> GetExists(string noSeri, string modelCode)
        {
            List<GaransiModel> results = new List<GaransiModel>();
            string query = "SELECT * FROM Result_Packing_Labels WHERE SerialNumber = @SerialNumber AND ModelCode = @ModelCode";

            using (SqlConnection connection = new SqlConnection(LSBUDBPRODUCTION))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.Add("@SerialNumber", SqlDbType.VarChar).Value = noSeri;
                command.Parameters.Add("@ModelCode", SqlDbType.VarChar).Value = modelCode;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var result = new GaransiModel
                        {
                            Id = reader["Id"].ToString(),
                            JenisProduk = reader["JenisProduk"].ToString(),
                            ModelCode = reader["ModelCode"].ToString(),
                            ModelNumber = reader["ModelNumber"].ToString(),
                            GlobalCodeId = reader["GlobalCodeId"].ToString(),
                            NoSeri = reader["SerialNumber"].ToString(),
                            NoReg = reader["Register"].ToString(),
                            Date = reader["ScanningDate"].ToString(),
                            ScanTime = reader["ScanningTime"].ToString(),
                            Location = reader["Location"].ToString()
                        };
                        results.Add(result);
                    }
                }
                connection.Close();
            }

            return results;
        }
    }
}
