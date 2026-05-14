using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class ClsEquipments
    {
        private enum enMode { AddNew, Update }

        private enMode Mode;

        public int EquipmentID { get; set; }

        public string EquipmentType { get; set; }


        public ClsEquipments()
        {
            EquipmentID = -1;
            EquipmentType = "";
            Mode = enMode.AddNew;
        }


        private ClsEquipments(int EquipmentID, string EquipmentType)
        {
            this.EquipmentID = EquipmentID;
            this.EquipmentType = EquipmentType;

            Mode = enMode.Update;
        }


        // Count Equipments
        public static int CountEquipments()
        {
            return ClsEquipmentData.TotalEquipments();
        }


        // Get All Equipments
        public static DataTable GetEquipments()
        {
            return ClsEquipmentData.GetAllEquipments();
        }


        // Find Equipment
        public static ClsEquipments Find(int EquipmentID)
        {
            string EquipmentType = "";

            if (ClsEquipmentData.GetEquipmentByID(EquipmentID, ref EquipmentType))
            {
                return new ClsEquipments(EquipmentID, EquipmentType);
            }

            return null;
        }


        // Add Equipment
        private bool _Add()
        {
            EquipmentID = ClsEquipmentData.InsertNewEquipment(EquipmentType);

            return (EquipmentID > 0);
        }


        // Update Equipment
        private bool _Update()
        {
            return ClsEquipmentData.UpdateEquipment(EquipmentID, EquipmentType);
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


        // Delete Equipment
        public static bool Delete(int EquipmentID)
        {
            return ClsEquipmentData.DeleteEquipment(EquipmentID);
        }


        // Search By ID
        public static DataTable SearchByID(int EquipmentID)
        {
            return ClsEquipmentData.SearchByID(EquipmentID);
        }


        // Search By Equipment Type
        public static DataTable SearchByEquipmentType(string EquipmentType)
        {
            return ClsEquipmentData.SearchByEquipmentType(EquipmentType);
        }


        // Exists
        public static bool Exists(int EquipmentID)
        {
            return ClsEquipmentData.IsEquipmentExist(EquipmentID);
        }
    }
}