using System;
using System.Data;
using System.Data.SqlClient;
using Connection;

namespace Data_Access_Layer
{
    public class ClsReservationData
    {

        // Get Total Reservations
        public static int TotalReservations()
        {
            int Total = 0;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "SELECT COUNT(*) FROM Reservation";

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


        // Get All Reservations
        public static DataTable GetAllReservations()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        Reservation.reservation_id AS 'Reservation ID',
                        Member.name AS 'Member Name',
                        Member.corporate_affiliation AS 'Corporate Affiliation',
                        Workspace.type AS 'Workspace Type',
                        Hub.district_location AS 'District Location',
                        Hub.architectural_layout AS 'Layout',
                        Equipment.type AS 'Equipment Type',
                        Reservation.rate AS 'Reservation Rate',
                        Reservation.reservation_date AS 'Reservation Date'
                      FROM Reservation
                      INNER JOIN Member
                      ON Reservation.member_id = Member.member_id
                      INNER JOIN Workspace
                      ON Reservation.workspace_id = Workspace.workspace_id
                      INNER JOIN Hub
                      ON Workspace.hub_id = Hub.hub_id
                      INNER JOIN Equipment
                      ON Reservation.equipment_id = Equipment.equipment_id";

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


        // Get Reservation By ID
        public static bool GetReservationByID(int ReservationID, ref int MemberID, ref int WorkspaceID, ref int EquipmentID, ref decimal Rate, ref DateTime ReservationDate)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"SELECT * FROM Reservation WHERE reservation_id = @ReservationID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationID", ReservationID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;

                            MemberID = Convert.ToInt32(reader["member_id"]);
                            WorkspaceID = Convert.ToInt32(reader["workspace_id"]);
                            EquipmentID = Convert.ToInt32(reader["equipment_id"]);
                            Rate = Convert.ToDecimal(reader["rate"]);
                            ReservationDate = Convert.ToDateTime(reader["reservation_date"]);
                        }

                        reader.Close();
                    }
                    catch { }
                }
            }

            return IsFound;
        }


        // Insert New Reservation
        public static int InsertNewReservation(int MemberID, int WorkspaceID, int EquipmentID, decimal Rate, DateTime ReservationDate)
        {
            int ReservationID = -1;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"INSERT INTO Reservation
                      (
                        member_id,
                        workspace_id,
                        equipment_id,
                        rate,
                        reservation_date
                      )
                      VALUES
                      (
                        @MemberID,
                        @WorkspaceID,
                        @EquipmentID,
                        @Rate,
                        @ReservationDate
                      );

                      SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    command.Parameters.AddWithValue("@WorkspaceID", WorkspaceID);
                    command.Parameters.AddWithValue("@EquipmentID", EquipmentID);
                    command.Parameters.AddWithValue("@Rate", Rate);
                    command.Parameters.AddWithValue("@ReservationDate", ReservationDate);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            ReservationID = InsertedID;
                    }
                    catch { }
                }
            }

            return ReservationID;
        }


        // Update Reservation
        public static bool UpdateReservation(int ReservationID, int MemberID, int WorkspaceID, int EquipmentID, decimal Rate, DateTime ReservationDate)
        {
            bool IsUpdated = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"UPDATE Reservation SET
                      member_id = @MemberID,
                      workspace_id = @WorkspaceID,
                      equipment_id = @EquipmentID,
                      rate = @Rate,
                      reservation_date = @ReservationDate
                      WHERE reservation_id = @ReservationID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationID", ReservationID);
                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    command.Parameters.AddWithValue("@WorkspaceID", WorkspaceID);
                    command.Parameters.AddWithValue("@EquipmentID", EquipmentID);
                    command.Parameters.AddWithValue("@Rate", Rate);
                    command.Parameters.AddWithValue("@ReservationDate", ReservationDate);

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


        // Delete Reservation
        public static bool DeleteReservation(int ReservationID)
        {
            bool IsDeleted = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "DELETE FROM Reservation WHERE reservation_id = @ReservationID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationID", ReservationID);

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
                        Reservation.reservation_id AS 'Reservation ID',
                        Member.name AS 'Member Name',
                        Member.corporate_affiliation AS 'Corporate Affiliation',
                        Workspace.type AS 'Workspace Type',
                        Hub.district_location AS 'District Location',
                        Hub.architectural_layout AS 'Layout',
                        Equipment.type AS 'Equipment Type',
                        Reservation.rate AS 'Reservation Rate',
                        Reservation.reservation_date AS 'Reservation Date'
                      FROM Reservation
                      INNER JOIN Member
                      ON Reservation.member_id = Member.member_id
                      INNER JOIN Workspace
                      ON Reservation.workspace_id = Workspace.workspace_id
                      INNER JOIN Hub
                      ON Workspace.hub_id = Hub.hub_id
                      INNER JOIN Equipment
                      ON Reservation.equipment_id = Equipment.equipment_id
                      WHERE Reservation.reservation_id LIKE '%' + @ID + '%'";

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


        // Search By Member Name
        public static DataTable SearchByMemberName(string Name)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        Reservation.reservation_id AS 'Reservation ID',
                        Member.name AS 'Member Name',
                        Member.corporate_affiliation AS 'Corporate Affiliation',
                        Workspace.type AS 'Workspace Type',
                        Hub.district_location AS 'District Location',
                        Hub.architectural_layout AS 'Layout',
                        Equipment.type AS 'Equipment Type',
                        Reservation.rate AS 'Reservation Rate',
                        Reservation.reservation_date AS 'Reservation Date'
                      FROM Reservation
                      INNER JOIN Member
                      ON Reservation.member_id = Member.member_id
                      INNER JOIN Workspace
                      ON Reservation.workspace_id = Workspace.workspace_id
                      INNER JOIN Hub
                      ON Workspace.hub_id = Hub.hub_id
                      INNER JOIN Equipment
                      ON Reservation.equipment_id = Equipment.equipment_id
                      WHERE Member.name LIKE '%' + @Name + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);

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


        // Search By Corporate Affiliation
        public static DataTable SearchByCorporateAffiliation(string CorporateAffiliation)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        Reservation.reservation_id AS 'Reservation ID',
                        Member.name AS 'Member Name',
                        Member.corporate_affiliation AS 'Corporate Affiliation',
                        Workspace.type AS 'Workspace Type',
                        Hub.district_location AS 'District Location',
                        Hub.architectural_layout AS 'Layout',
                        Equipment.type AS 'Equipment Type',
                        Reservation.rate AS 'Reservation Rate',
                        Reservation.reservation_date AS 'Reservation Date'
                      FROM Reservation
                      INNER JOIN Member
                      ON Reservation.member_id = Member.member_id
                      INNER JOIN Workspace
                      ON Reservation.workspace_id = Workspace.workspace_id
                      INNER JOIN Hub
                      ON Workspace.hub_id = Hub.hub_id
                      INNER JOIN Equipment
                      ON Reservation.equipment_id = Equipment.equipment_id
                      WHERE Member.corporate_affiliation LIKE '%' + @CorporateAffiliation + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@CorporateAffiliation", CorporateAffiliation);

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
                        Reservation.reservation_id AS 'Reservation ID',
                        Member.name AS 'Member Name',
                        Member.corporate_affiliation AS 'Corporate Affiliation',
                        Workspace.type AS 'Workspace Type',
                        Hub.district_location AS 'District Location',
                        Hub.architectural_layout AS 'Layout',
                        Equipment.type AS 'Equipment Type',
                        Reservation.rate AS 'Reservation Rate',
                        Reservation.reservation_date AS 'Reservation Date'
                      FROM Reservation
                      INNER JOIN Member
                      ON Reservation.member_id = Member.member_id
                      INNER JOIN Workspace
                      ON Reservation.workspace_id = Workspace.workspace_id
                      INNER JOIN Hub
                      ON Workspace.hub_id = Hub.hub_id
                      INNER JOIN Equipment
                      ON Reservation.equipment_id = Equipment.equipment_id
                      WHERE Workspace.type LIKE '%' + @WorkspaceType + '%'";

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


        // Search By Hub Location
        public static DataTable SearchByHubLocation(string DistrictLocation)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        Reservation.reservation_id AS 'Reservation ID',
                        Member.name AS 'Member Name',
                        Member.corporate_affiliation AS 'Corporate Affiliation',
                        Workspace.type AS 'Workspace Type',
                        Hub.district_location AS 'District Location',
                        Hub.architectural_layout AS 'Layout',
                        Equipment.type AS 'Equipment Type',
                        Reservation.rate AS 'Reservation Rate',
                        Reservation.reservation_date AS 'Reservation Date'
                      FROM Reservation
                      INNER JOIN Member
                      ON Reservation.member_id = Member.member_id
                      INNER JOIN Workspace
                      ON Reservation.workspace_id = Workspace.workspace_id
                      INNER JOIN Hub
                      ON Workspace.hub_id = Hub.hub_id
                      INNER JOIN Equipment
                      ON Reservation.equipment_id = Equipment.equipment_id
                      WHERE Hub.district_location LIKE '%' + @DistrictLocation + '%'";

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
                        Reservation.reservation_id AS 'Reservation ID',
                        Member.name AS 'Member Name',
                        Member.corporate_affiliation AS 'Corporate Affiliation',
                        Workspace.type AS 'Workspace Type',
                        Hub.district_location AS 'District Location',
                        Hub.architectural_layout AS 'Layout',
                        Equipment.type AS 'Equipment Type',
                        Reservation.rate AS 'Reservation Rate',
                        Reservation.reservation_date AS 'Reservation Date'
                      FROM Reservation
                      INNER JOIN Member
                      ON Reservation.member_id = Member.member_id
                      INNER JOIN Workspace
                      ON Reservation.workspace_id = Workspace.workspace_id
                      INNER JOIN Hub
                      ON Workspace.hub_id = Hub.hub_id
                      INNER JOIN Equipment
                      ON Reservation.equipment_id = Equipment.equipment_id
                      WHERE Hub.architectural_layout LIKE '%' + @Layout + '%'";

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


        // Search By Equipment Type
        public static DataTable SearchByEquipmentType(string EquipmentType)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        Reservation.reservation_id AS 'Reservation ID',
                        Member.name AS 'Member Name',
                        Member.corporate_affiliation AS 'Corporate Affiliation',
                        Workspace.type AS 'Workspace Type',
                        Hub.district_location AS 'District Location',
                        Hub.architectural_layout AS 'Layout',
                        Equipment.type AS 'Equipment Type',
                        Reservation.rate AS 'Reservation Rate',
                        Reservation.reservation_date AS 'Reservation Date'
                      FROM Reservation
                      INNER JOIN Member
                      ON Reservation.member_id = Member.member_id
                      INNER JOIN Workspace
                      ON Reservation.workspace_id = Workspace.workspace_id
                      INNER JOIN Hub
                      ON Workspace.hub_id = Hub.hub_id
                      INNER JOIN Equipment
                      ON Reservation.equipment_id = Equipment.equipment_id
                      WHERE Equipment.type LIKE '%' + @EquipmentType + '%'";

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


        // Search By Reservation Rate
        public static DataTable SearchByRate(string Rate)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        Reservation.reservation_id AS 'Reservation ID',
                        Member.name AS 'Member Name',
                        Member.corporate_affiliation AS 'Corporate Affiliation',
                        Workspace.type AS 'Workspace Type',
                        Hub.district_location AS 'District Location',
                        Hub.architectural_layout AS 'Layout',
                        Equipment.type AS 'Equipment Type',
                        Reservation.rate AS 'Reservation Rate',
                        Reservation.reservation_date AS 'Reservation Date'
                      FROM Reservation
                      INNER JOIN Member
                      ON Reservation.member_id = Member.member_id
                      INNER JOIN Workspace
                      ON Reservation.workspace_id = Workspace.workspace_id
                      INNER JOIN Hub
                      ON Workspace.hub_id = Hub.hub_id
                      INNER JOIN Equipment
                      ON Reservation.equipment_id = Equipment.equipment_id
                      WHERE CAST(Reservation.rate AS VARCHAR(50)) LIKE '%' + @Rate + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Rate", Rate);

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


        // Search By Reservation Date
        public static DataTable SearchByReservationDate(DateTime ReservationDate)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query =
                    @"SELECT
                        Reservation.reservation_id AS 'Reservation ID',
                        Member.name AS 'Member Name',
                        Member.corporate_affiliation AS 'Corporate Affiliation',
                        Workspace.type AS 'Workspace Type',
                        Hub.district_location AS 'District Location',
                        Hub.architectural_layout AS 'Layout',
                        Equipment.type AS 'Equipment Type',
                        Reservation.rate AS 'Reservation Rate',
                        Reservation.reservation_date AS 'Reservation Date'
                      FROM Reservation
                      INNER JOIN Member
                      ON Reservation.member_id = Member.member_id
                      INNER JOIN Workspace
                      ON Reservation.workspace_id = Workspace.workspace_id
                      INNER JOIN Hub
                      ON Workspace.hub_id = Hub.hub_id
                      INNER JOIN Equipment
                      ON Reservation.equipment_id = Equipment.equipment_id
                      WHERE CAST(Reservation.reservation_date AS DATE) = @ReservationDate";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationDate", ReservationDate.Date);

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


        // Check If Reservation Exists
        public static bool IsReservationExist(int ReservationID)
        {
            bool Exists = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"SELECT Found = 1 FROM Reservation WHERE reservation_id = @ReservationID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationID", ReservationID);

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