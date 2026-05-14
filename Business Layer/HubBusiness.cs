using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class ClsHubs
    {
        private enum enMode { AddNew, Update }

        private enMode Mode;

        public int HubID { get; set; }

        public string Location { get; set; }

        public string Layout { get; set; }


        public ClsHubs()
        {
            HubID = -1;

            Location = "";

            Layout = "";

            Mode = enMode.AddNew;
        }


        private ClsHubs(int HubID, string Location, string Layout)
        {
            this.HubID = HubID;

            this.Location = Location;

            this.Layout = Layout;

            Mode = enMode.Update;
        }


        // Count Hubs
        public static int CountHubs()
        {
            return ClsHubData.TotalHubs();
        }


        // Get All Hubs
        public static DataTable GetHubs()
        {
            return ClsHubData.GetAllHubs();
        }


        // Find Hub
        public static ClsHubs Find(int HubID)
        {
            string Location = "";

            string Layout = "";

            if (ClsHubData.GetHubByID(
                HubID,
                ref Location,
                ref Layout))
            {
                return new ClsHubs(
                    HubID,
                    Location,
                    Layout);
            }

            return null;
        }


        // Add New Hub
        private bool _Add()
        {
            HubID = ClsHubData.InsertNewHub(Location, Layout);

            return (HubID > 0);
        }


        // Update Hub
        private bool _Update()
        {
            return ClsHubData.UpdateHub(
                HubID,
                Location,
                Layout);
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


        // Delete Hub
        public static bool Delete(int HubID)
        {
            return ClsHubData.DeleteHub(HubID);
        }


        // Search By ID
        public static DataTable SearchByID(int HubID)
        {
            return ClsHubData.SearchByID(HubID);
        }


        // Search By Location
        public static DataTable SearchByLocation(string Location)
        {
            return ClsHubData.SearchByDistrictLocation(Location);
        }


        // Search By Layout
        public static DataTable SearchByLayout(string Layout)
        {
            return ClsHubData.SearchByLayout(Layout);
        }


        // Exists
        public static bool Exists(int HubID)
        {
            return ClsHubData.IsHubExist(HubID);
        }
    }
}