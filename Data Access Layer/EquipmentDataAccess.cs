using System;
using System.Data;
using System.Data.SqlClient;
using Connection;

namespace Data_Access_Layer
{
    public class ClsEquipmentData
    {

        // Get Total Equipments
        public static int TotalEquipments()
        {
            int Total = 0;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "SELECT COUNT(*) FROM Equipment";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null)
                            Total = Convert.ToInt32(Result);
                    }
                    catch { }
                }
            }

            return Total;
        }


        // Get All Equipments
        public static DataTable GetAllEquipments()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        equipment_id AS 'Equipment ID',
                        type AS 'Equipment Type'
                      FROM Equipment";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                            dt.Load(reader);

                        reader.Close();
                    }
                    catch { }
                }
            }

            return dt;
        }


        // Get Equipment By ID
        public static bool GetEquipmentByID(int EquipmentID, ref string EquipmentType)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "SELECT * FROM Equipment WHERE equipment_id = @EquipmentID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@EquipmentID", EquipmentID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader =
                            command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;

                            EquipmentType = reader["type"].ToString();
                        }

                        reader.Close();
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        // Get Equipment By type
        public static bool GetEquipmentByType(ref int EquipmentID, string EquipmentType)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "SELECT * FROM Equipment WHERE type = @type";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@type", EquipmentType);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader =
                            command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;
                            EquipmentID = (int)reader["equipment_id"];
                            //EquipmentType = reader["type"].ToString();
                        }

                        reader.Close();
                    }
                    catch { }
                }
            }

            return IsFound;
        }


        // Insert New Equipment
        public static int InsertNewEquipment(string EquipmentType)
        {
            int EquipmentID = -1;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"INSERT INTO Equipment
                      (
                        type
                      )
                      VALUES
                      (
                        @EquipmentType
                      );

                      SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@EquipmentType", EquipmentType);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            EquipmentID = InsertedID;

                    }
                    catch { }
                }
            }

            return EquipmentID;
        }


        // Update Equipment
        public static bool UpdateEquipment(int EquipmentID, string EquipmentType)
        {
            bool IsUpdated = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"UPDATE Equipment SET type = @EquipmentType
                      WHERE equipment_id = @EquipmentID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@EquipmentID", EquipmentID);

                    command.Parameters.AddWithValue("@EquipmentType", EquipmentType);

                    try
                    {
                        connection.Open();

                        int RowsAffected = command.ExecuteNonQuery();

                        IsUpdated = (RowsAffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdated;
        }


        // Delete Equipment
        public static bool DeleteEquipment(int EquipmentID)
        {
            bool IsDeleted = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "DELETE FROM Equipment WHERE equipment_id = @EquipmentID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@EquipmentID", EquipmentID);

                    try
                    {
                        connection.Open();

                        int RowsAffected = command.ExecuteNonQuery();

                        IsDeleted = (RowsAffected > 0);
                    }
                    catch { }
                }
            }

            return IsDeleted;
        }


        // Search By ID
        public static DataTable SearchByID(int EquipmentID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"SELECT equipment_id AS 'Equipment ID', type AS 'Equipment Type'
                      FROM Equipment WHERE equipment_id LIKE '%' + @EquipmentID + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@EquipmentID", EquipmentID.ToString());

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                            dt.Load(reader);

                        reader.Close();
                    }
                    catch { }
                }
            }

            return dt;
        }


        // Search By Equipment Type
        public static DataTable SearchByEquipmentType(string EquipmentType)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"SELECT equipment_id AS 'Equipment ID', type AS 'Equipment Type'
                      FROM Equipment  WHERE type LIKE '%' + @EquipmentType + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@EquipmentType", EquipmentType);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                            dt.Load(reader);

                        reader.Close();
                    }
                    catch { }
                }
            }

            return dt;
        }


        // Check If Equipment Exists
        public static bool IsEquipmentExist(int EquipmentID)
        {
            bool Exists = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"SELECT Found = 1 FROM Equipment
                      WHERE equipment_id = @EquipmentID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@EquipmentID", EquipmentID);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        Exists = (Result != null);
                    }
                    catch { }
                }
            }

            return Exists;
        }

    }
}