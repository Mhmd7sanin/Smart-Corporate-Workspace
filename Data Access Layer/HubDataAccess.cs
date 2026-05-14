using System;
using System.Data;
using System.Data.SqlClient;
using Connection;

namespace Data_Access_Layer
{
    public class ClsHubData
    {

        // Get Total Hubs
        public static int TotalHubs()
        {
            int Total = 0;

            using (SqlConnection connection =
                new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "SELECT COUNT(*) FROM Hub";

                using (SqlCommand command =
                    new SqlCommand(Query, connection))
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


        // Get All Hubs
        public static DataTable GetAllHubs()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        hub_id AS 'Hub ID',
                        district_location AS 'District Location',
                        architectural_layout AS 'Layout'
                      FROM Hub";

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


        // Get Hub By ID
        public static bool GetHubByID(int HubID, ref string DistrictLocation, ref string Layout)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT *
                      FROM Hub
                      WHERE hub_id = @HubID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@HubID", HubID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;

                            DistrictLocation = reader["district_location"].ToString();
                            Layout = reader["architectural_layout"].ToString();
                        }

                        reader.Close();
                    }
                    catch { }
                }
            }

            return IsFound;
        }


        // Insert New Hub
        public static int InsertNewHub(string DistrictLocation, string Layout)
        {
            int HubID = -1;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"INSERT INTO Hub
                      (
                        district_location,
                        architectural_layout
                      )
                      VALUES
                      (
                        @DistrictLocation,
                        @Layout
                      );

                      SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@DistrictLocation", DistrictLocation);
                    command.Parameters.AddWithValue("@Layout", Layout);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            HubID = InsertedID;
                    }
                    catch { }
                }
            }

            return HubID;
        }


        // Update Hub
        public static bool UpdateHub(int HubID, string DistrictLocation, string Layout)
        {
            bool IsUpdated = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"UPDATE Hub SET
                        district_location = @DistrictLocation,
                        architectural_layout = @Layout
                      WHERE hub_id = @HubID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@HubID", HubID);
                    command.Parameters.AddWithValue("@DistrictLocation", DistrictLocation);
                    command.Parameters.AddWithValue("@Layout", Layout);

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


        // Delete Hub
        public static bool DeleteHub(int HubID)
        {
            bool IsDeleted = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "DELETE FROM Hub WHERE hub_id = @HubID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@HubID", HubID);

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
        public static DataTable SearchByID(int ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        hub_id AS 'Hub ID',
                        district_location AS 'District Location',
                        architectural_layout AS 'Layout'
                      FROM Hub
                      WHERE hub_id LIKE '%' + @ID + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID.ToString());

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


        // Search By District Location
        public static DataTable SearchByDistrictLocation(string DistrictLocation)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        hub_id AS 'Hub ID',
                        district_location AS 'District Location',
                        architectural_layout AS 'Layout'
                      FROM Hub
                      WHERE district_location
                      LIKE '%' + @DistrictLocation + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@DistrictLocation", DistrictLocation);

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


        // Search By Layout
        public static DataTable SearchByLayout(string Layout)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        hub_id AS 'Hub ID',
                        district_location AS 'District Location',
                        architectural_layout AS 'Layout'
                      FROM Hub
                      WHERE architectural_layout
                      LIKE '%' + @Layout + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Layout", Layout);

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


        // Check If Hub Exists
        public static bool IsHubExist(int HubID)
        {
            bool Exists = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT Found = 1
                      FROM Hub
                      WHERE hub_id = @HubID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@HubID", HubID);

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