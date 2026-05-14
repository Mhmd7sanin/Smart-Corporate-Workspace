using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class ClsMembers
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;

        public int MemberID { get; set; }
        public string Name { get; set; }
        public string CorporateAffiliation { get; set; }

        public ClsMembers()
        {
            MemberID = -1;
            Name = "";
            CorporateAffiliation = "";
            Mode = enMode.AddNew;
        }

        private ClsMembers(int id, string name, string corp)
        {
            MemberID = id;
            Name = name;
            CorporateAffiliation = corp;
            Mode = enMode.Update;
        }

        public static int CountMembers()
        {
            return ClsMemberData.TotalMembers();
        }

        public static DataTable GetMembers()
        {
            return ClsMemberData.GetAllMembers();
        }

        public static ClsMembers Find(int ID)
        {
            string name = "", corp = "";

            if (ClsMemberData.GetMemberByID(ID, ref name, ref corp))
                return new ClsMembers(ID, name, corp);

            return null;
        }

        private bool _Add()
        {
            MemberID = ClsMemberData.InsertNewMember(Name, CorporateAffiliation);
            return MemberID > 0;
        }

        private bool _Update()
        {
            return ClsMemberData.UpdateMember(MemberID, Name, CorporateAffiliation);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add()) { Mode = enMode.Update; return true; }
                    return false;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static bool Delete(int ID)
        {
            return ClsMemberData.DeleteMember(ID);
        }


        public static DataTable SearchById(int id)
        {
            return ClsMemberData.SearchById(id);
        }

        public static DataTable SearchByName(string name)
        {
            return ClsMemberData.SearchByName(name);
        }


        public static DataTable SearchByCorporateAffiliation(string CorporateAffiliation)
        {
            return ClsMemberData.SearchByCorporateAffiliation(CorporateAffiliation);
        }

        public static bool Exists(int ID)
        {
            return ClsMemberData.IsMemberExist(ID);
        }
    }
}