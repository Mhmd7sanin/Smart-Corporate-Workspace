using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class ClsReservations
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int ReservationID { get; set; }
        public int MemberID { get; set; }
        public int WorkspaceID { get; set; }
        public int EquipmentID { get; set; }
        public decimal Rate { get; set; }
        public DateTime ReservationDate { get; set; }

        public ClsReservations()
        {
            ReservationID = -1;
            MemberID = -1;
            WorkspaceID = -1;
            EquipmentID = -1;
            Rate = 0;
            ReservationDate = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private ClsReservations(int ReservationID, int MemberID, int WorkspaceID, int EquipmentID, decimal Rate, DateTime ReservationDate)
        {
            this.ReservationID = ReservationID;
            this.MemberID = MemberID;
            this.WorkspaceID = WorkspaceID;
            this.EquipmentID = EquipmentID;
            this.Rate = Rate;
            this.ReservationDate = ReservationDate;
            Mode = enMode.Update;
        }

        // Count Reservations
        public static int CountReservations()
        {
            return ClsReservationData.TotalReservations();
        }

        // Get All Reservations
        public static DataTable GetReservations()
        {
            return ClsReservationData.GetAllReservations();
        }

        // Find Reservation
        public static ClsReservations Find(int ReservationID)
        {
            int MemberID = -1;
            int WorkspaceID = -1;
            int EquipmentID = -1;
            decimal Rate = 0;
            DateTime ReservationDate = DateTime.Now;

            if (ClsReservationData.GetReservationByID(ReservationID, ref MemberID, ref WorkspaceID, ref EquipmentID, ref Rate, ref ReservationDate))
            {
                return new ClsReservations(ReservationID, MemberID, WorkspaceID, EquipmentID, Rate, ReservationDate);
            }

            return null;
        }

        // Add New Reservation
        private bool _Add()
        {
            ReservationID = ClsReservationData.InsertNewReservation(MemberID, WorkspaceID, EquipmentID, Rate, ReservationDate);
            return (ReservationID > 0);
        }

        // Update Reservation
        private bool _Update()
        {
            return ClsReservationData.UpdateReservation(ReservationID, MemberID, WorkspaceID, EquipmentID, Rate, ReservationDate);
        }

        // Save
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        // Delete Reservation
        public static bool Delete(int ReservationID)
        {
            return ClsReservationData.DeleteReservation(ReservationID);
        }

        // Search By ID
        public static DataTable SearchByID(int ID)
        {
            return ClsReservationData.SearchByID(ID);
        }

        // Search By Member Name
        public static DataTable SearchByMemberName(string Name)
        {
            return ClsReservationData.SearchByMemberName(Name);
        }

        // Search By Corporate Affiliation
        public static DataTable SearchByCorporateAffiliation(string CorporateAffiliation)
        {
            return ClsReservationData.SearchByCorporateAffiliation(CorporateAffiliation);
        }

        // Search By Workspace Type
        public static DataTable SearchByWorkspaceType(string WorkspaceType)
        {
            return ClsReservationData.SearchByWorkspaceType(WorkspaceType);
        }

        // Search By Hub Location
        public static DataTable SearchByHubLocation(string DistrictLocation)
        {
            return ClsReservationData.SearchByHubLocation(DistrictLocation);
        }

        // Search By Hub Layout
        public static DataTable SearchByHubLayout(string Layout)
        {
            return ClsReservationData.SearchByHubLayout(Layout);
        }

        // Search By Equipment Type
        public static DataTable SearchByEquipmentType(string EquipmentType)
        {
            return ClsReservationData.SearchByEquipmentType(EquipmentType);
        }

        // Search By Rate
        public static DataTable SearchByRate(string Rate)
        {
            return ClsReservationData.SearchByRate(Rate);
        }

        // Search By Reservation Date
        public static DataTable SearchByReservationDate(DateTime ReservationDate)
        {
            return ClsReservationData.SearchByReservationDate(ReservationDate);
        }

        // Exists
        public static bool Exists(int ReservationID)
        {
            return ClsReservationData.IsReservationExist(ReservationID);
        }
    }
}