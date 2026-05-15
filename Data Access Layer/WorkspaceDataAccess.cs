using System;
using System.Data;
using System.Data.SqlClient;
using Connection;

namespace Data_Access_Layer
{
    public class ClsWorkspaceData
    {

        // Get Total Workspaces
        public static int TotalWorkspaces()
        {
            int Total = 0;

            using (SqlConnection connection =
                new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "SELECT COUNT(*) FROM Workspace";

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


        // Get All Workspaces
        public static DataTable GetAllWorkspaces()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        w.workspace_id AS 'Workspace ID',
                        w.type AS 'Workspace Type',
                        h.district_location AS 'District Location',
                        h.architectural_layout AS 'Layout',
                        w.rate AS 'Rate' 
                      FROM Workspace w
                      INNER JOIN Hub h
                      ON w.hub_id = h.hub_id";

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


        // Get Workspace By ID
        public static bool GetWorkspaceByID(int WorkspaceID, ref int HubID, ref string WorkspaceType, ref decimal WorkspaceRate)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "SELECT * FROM Workspace WHERE workspace_id = @WorkspaceID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@WorkspaceID", WorkspaceID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;

                            HubID = (int)reader["hub_id"];
                            WorkspaceType = reader["type"].ToString();
                            WorkspaceRate = (decimal)reader["rate"];
                        }

                        reader.Close();
                    }
                    catch { }
                }
            }

            return IsFound;
        }


        // Insert New Workspace
        public static int InsertNewWorkspace(int HubID, string WorkspaceType, decimal WorkspaceRate)
        {
            int WorkspaceID = -1;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"INSERT INTO Workspace
                      (
                        hub_id,
                        type,
                        rate
                      )
                      VALUES
                      (
                        @HubID,
                        @WorkspaceType,
                        @Rate
                      );

                      SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@HubID", HubID);
                    command.Parameters.AddWithValue("@WorkspaceType", WorkspaceType);
                    command.Parameters.AddWithValue("@Rate", WorkspaceRate);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            WorkspaceID = InsertedID;
                    }
                    catch { }
                }
            }

            return WorkspaceID;
        }


        // Update Workspace
        public static bool UpdateWorkspace(int WorkspaceID, int HubID, string WorkspaceType, decimal WorkspaceRate)
        {
            bool IsUpdated = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"UPDATE Workspace SET
                        hub_id = @HubID,
                        type = @WorkspaceType,
                        rate = @Rate
                      WHERE workspace_id = @WorkspaceID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@WorkspaceID", WorkspaceID);
                    command.Parameters.AddWithValue("@HubID", HubID);
                    command.Parameters.AddWithValue("@WorkspaceType", WorkspaceType);
                    command.Parameters.AddWithValue("@Rate", WorkspaceRate);

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


        // Delete Workspace
        public static bool DeleteWorkspace(int WorkspaceID)
        {
            bool IsDeleted = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "DELETE FROM Workspace WHERE workspace_id = @WorkspaceID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@WorkspaceID", WorkspaceID);

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
                        w.workspace_id AS 'Workspace ID',
                        w.type AS 'Workspace Type',
                        h.district_location AS 'District Location',
                        h.architectural_layout AS 'Layout',
                        w.rate AS 'Rate' 
                      FROM Workspace w
                      INNER JOIN Hub h
                      ON w.hub_id = h.hub_id
                      WHERE w.workspace_id
                      LIKE '%' + @ID + '%'";

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


        // Search By Workspace Type
        public static DataTable SearchByWorkspaceType(string WorkspaceType)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        w.workspace_id AS 'Workspace ID',
                        w.type AS 'Workspace Type',
                        h.district_location AS 'District Location',
                        h.architectural_layout AS 'Layout',
                        w.rate AS 'Rate' 
                      FROM Workspace w
                      INNER JOIN Hub h
                      ON w.hub_id = h.hub_id
                      WHERE w.type
                      LIKE '%' + @WorkspaceType + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@WorkspaceType", WorkspaceType);

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


        // Search By Hub Id
        public static DataTable SearchByHubId(int HubId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        w.workspace_id AS 'Workspace ID',
                        w.type AS 'Workspace Type',
                        h.district_location AS 'District Location',
                        h.architectural_layout AS 'Layout',
                        w.rate AS 'Rate' 
                      FROM Workspace w
                      INNER JOIN Hub h
                      ON w.hub_id = h.hub_id
                      WHERE h.hub_id = @HubId";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@HubId", HubId);

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



        // Search By Hub District Location
        public static DataTable SearchByHubDistrictLocation(string DistrictLocation)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        w.workspace_id AS 'Workspace ID',
                        w.type AS 'Workspace Type',
                        h.district_location AS 'District Location',
                        h.architectural_layout AS 'Layout',
                        w.rate AS 'Rate' 
                      FROM Workspace w
                      INNER JOIN Hub h
                      ON w.hub_id = h.hub_id
                      WHERE h.district_location
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


        // Search By Hub Layout
        public static DataTable SearchByHubLayout(string Layout)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        w.workspace_id AS 'Workspace ID',
                        w.type AS 'Workspace Type',
                        h.district_location AS 'District Location',
                        h.architectural_layout AS 'Layout',
                        w.rate AS 'Rate' 
                      FROM Workspace w
                      INNER JOIN Hub h
                      ON w.hub_id = h.hub_id
                      WHERE h.architectural_layout
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

        // Search By Rate
        public static DataTable SearchByRate(decimal Rate)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        w.workspace_id AS 'Workspace ID',
                        w.type AS 'Workspace Type',
                        h.district_location AS 'District Location',
                        h.architectural_layout AS 'Layout',
                        w.rate AS 'Rate' 
                      FROM Workspace w
                      INNER JOIN Hub h
                      ON w.hub_id = h.hub_id
                      WHERE w.rate
                      LIKE '%' + @Rate + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Rate", Rate.ToString());

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


        // Check If Workspace Exists
        public static bool IsWorkspaceExist(int WorkspaceID)
        {
            bool Exists = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT Found = 1
                      FROM Workspace
                      WHERE workspace_id = @WorkspaceID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@WorkspaceID", WorkspaceID);

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