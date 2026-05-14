using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class ClsWorkspaces
    {
        private enum enMode { AddNew, Update }

        private enMode Mode;

        public int WorkspaceID { get; set; }

        public int HubID { get; set; }

        public string WorkspaceType { get; set; }

        public decimal WorkspaceRate { get; set; }


        public ClsWorkspaces()
        {
            WorkspaceID = -1;

            HubID = -1;

            WorkspaceType = "";

            WorkspaceRate = 0;

            Mode = enMode.AddNew;
        }


        private ClsWorkspaces(
            int WorkspaceID,
            int HubID,
            string WorkspaceType,
            decimal WorkspaceRate)
        {
            this.WorkspaceID = WorkspaceID;

            this.HubID = HubID;

            this.WorkspaceType = WorkspaceType;

            this.WorkspaceRate = WorkspaceRate;

            Mode = enMode.Update;
        }


        // Count Workspaces
        public static int CountWorkspaces()
        {
            return ClsWorkspaceData.TotalWorkspaces();
        }


        // Get All Workspaces
        public static DataTable GetWorkspaces()
        {
            return ClsWorkspaceData.GetAllWorkspaces();
        }


        // Find Workspace
        public static ClsWorkspaces Find(int WorkspaceID)
        {
            int HubID = -1;

            string WorkspaceType = "";

            decimal WorkspaceRate = 0;

            if (ClsWorkspaceData.GetWorkspaceByID(
                WorkspaceID,
                ref HubID,
                ref WorkspaceType,
                ref WorkspaceRate))
            {
                return new ClsWorkspaces(
                    WorkspaceID,
                    HubID,
                    WorkspaceType,
                    WorkspaceRate);
            }

            return null;
        }


        // Add Workspace
        private bool _Add()
        {
            WorkspaceID =
                ClsWorkspaceData.InsertNewWorkspace(
                    HubID,
                    WorkspaceType,
                    WorkspaceRate);

            return (WorkspaceID > 0);
        }


        // Update Workspace
        private bool _Update()
        {
            return ClsWorkspaceData.UpdateWorkspace(
                WorkspaceID,
                HubID,
                WorkspaceType,
                WorkspaceRate);
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


        // Delete Workspace
        public static bool Delete(int WorkspaceID)
        {
            return ClsWorkspaceData.DeleteWorkspace(
                WorkspaceID);
        }


        // Search By ID
        public static DataTable SearchByID(int ID)
        {
            return ClsWorkspaceData.SearchByID(ID);
        }


        // Search By Workspace Type
        public static DataTable SearchByWorkspaceType(string WorkspaceType)
        {
            return ClsWorkspaceData.SearchByWorkspaceType(
                WorkspaceType);
        }


        // Search By District Location
        public static DataTable SearchByHubDistrictLocation(string DistrictLocation)
        {
            return ClsWorkspaceData.SearchByHubDistrictLocation(
                DistrictLocation);
        }


        // Search By Layout
        public static DataTable SearchByHubLayout(string Layout)
        {
            return ClsWorkspaceData.SearchByHubLayout(
                Layout);
        }


        // Search By Rate
        public static DataTable SearchByRate(decimal Rate)
        {
            return ClsWorkspaceData.SearchByRate(
                Rate);
        }


        // Check If Workspace Exists
        public static bool Exists(int WorkspaceID)
        {
            return ClsWorkspaceData.IsWorkspaceExist(
                WorkspaceID);
        }

    }
}