using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connection;

namespace Data_Access_Layer
{
    public class ClsMemberData
    {

        // Get Total Members
        public static int TotalMembers()
        {
            int Total = 0;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "SELECT COUNT(*) FROM Member";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null) Total = Convert.ToInt32(Result);
                    }
                    catch { }
                }
            }

            return Total;
        }


        // Get All Members
        public static DataTable GetAllMembers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "SELECT member_id AS 'Member ID', name AS 'Member Name', " +
                        "corporate_affiliation AS 'Corporate Affiliation' FROM Member";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows) dt.Load(reader);

                        reader.Close();
                    }
                    catch { }
                }
            }

            return dt;
        }


        // Get Member By ID
        public static bool GetMemberByID(int MemberID, ref string Name, ref string CorporateAffiliation)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"SELECT * FROM Member WHERE member_id = @MemberID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", MemberID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;

                            Name = reader["name"].ToString();

                            CorporateAffiliation = reader["corporate_affiliation"].ToString();
                        }

                        reader.Close();
                    }
                    catch { }
                }
            }

            return IsFound;
        }


        // Insert New Member
        public static int InsertNewMember(string Name, string CorporateAffiliation)
        {
            int MemberID = -1;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "INSERT INTO Member  (name, corporate_affiliation)"
                      + " VALUES (@Name, @CorporateAffiliation); SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);

                    if (CorporateAffiliation != null && CorporateAffiliation != "")
                        command.Parameters.AddWithValue("@CorporateAffiliation", CorporateAffiliation);

                    else command.Parameters.AddWithValue("@CorporateAffiliation", DBNull.Value);


                    try
                    {
                        connection.Open(); object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            MemberID = InsertedID;
                    }
                    catch { }
                }
            }

            return MemberID;
        }


        // Update Member
        public static bool UpdateMember(int MemberID, string Name, string CorporateAffiliation)
        {
            bool IsUpdated = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"UPDATE Member SET
                      name = @Name, corporate_affiliation = @CorporateAffiliation
                      WHERE member_id = @MemberID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", MemberID);

                    command.Parameters.AddWithValue("@Name", Name);

                    if (CorporateAffiliation != null && CorporateAffiliation != "")
                        command.Parameters.AddWithValue("@CorporateAffiliation", CorporateAffiliation);

                    else
                        command.Parameters.AddWithValue("@CorporateAffiliation", DBNull.Value);


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


        // Delete Member
        public static bool DeleteMember(int MemberID)
        {
            bool IsDeleted = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = "DELETE FROM Member WHERE member_id = @MemberID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", MemberID);

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

        // Search By Id
        public static DataTable SearchById(int id)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"SELECT  member_id AS 'Member ID', name AS 'Member Name',
                        corporate_affiliation AS 'Corporate Affiliation' FROM Member
                        WHERE member_id LIKE '%' + @id + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@id", id.ToString());

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows) dt.Load(reader);

                        reader.Close();
                    }
                    catch { }
                }
            }

            return dt;
        }

        // Search By Name
        public static DataTable SearchByName(string Name)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"SELECT  member_id AS 'Member ID', name AS 'Member Name',
                        corporate_affiliation AS 'Corporate Affiliation' FROM Member
                        WHERE name LIKE '%' + @Name + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows) dt.Load(reader);

                        reader.Close();
                    }
                    catch { }
                }
            }

            return dt;
        }

        // Search By Corporate Affiliation
        public static DataTable SearchByCorporateAffiliation(string Co_Af)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"SELECT  member_id AS 'Member ID', name AS 'Member Name',
                 corporate_affiliation AS 'Corporate Affiliation' FROM Member
                 WHERE corporate_affiliation LIKE '%' + @Co_Af + '%'";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Co_Af", Co_Af);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows) dt.Load(reader);

                        reader.Close();
                    }
                    catch { }
                }
            }

            return dt;
        }


        // Check If Member Exists
        public static bool IsMemberExist(int MemberID)
        {
            bool Exists = false;

            using (SqlConnection connection = new SqlConnection(ServerConnection.ConnectionString))
            {
                string Query = @"SELECT Found = 1  FROM Member
                      WHERE member_id = @MemberID";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", MemberID);

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
