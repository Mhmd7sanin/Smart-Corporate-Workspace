using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Business_Layer;
using Presentation_layer.Members;
using Presentation_layer.Workspaces;

namespace Presentation_layer.Reservations
{
    public partial class frmAddEditReservation : Form
    {
        private int ReservationID;

        private int WorkspaceID = -1;

        private int MemberID = -1;

        private ClsReservations Reservation;

        private enum enMode { AddNew = 1, Update = 2 };

        private enMode Mode;

        public frmAddEditReservation(int id)
        {
            InitializeComponent();

            ReservationID = id;

            if (ReservationID == -1)
                Mode = enMode.AddNew;
            else
                Mode = enMode.Update;
        }

        private void frmAddEditReservation_Load(object sender, EventArgs e)
        {
            _LoadEquipmentComboBox();

            WorkspacesFilterComboBox.SelectedIndex = 0;

            MembersFilterComboBox.SelectedIndex = 0;

            if (Mode == enMode.AddNew)
            {
                Reservation = new ClsReservations();

                MemberIdLbl.Text = "N/A";

                return;
            }

            Reservation = ClsReservations.Find(ReservationID);

            TitleLbl.Text = "Update Reservation";

            this.Text = "Update Reservation";

            if (Reservation == null)
            {
                MessageBox.Show("This form will be closed because No Reservation with ID = "
                    + ReservationID);

                this.Close();

                return;
            }

            MemberIdLbl.Text = Reservation.ReservationID.ToString();

            WorkspaceID = Reservation.WorkspaceID;

            MemberID = Reservation.MemberID;

            _LoadWorkspaceInfo(WorkspaceID);

            _LoadMemberInfo(MemberID);

            WorkSpaceRateTxtBx.Text = Reservation.Rate.ToString();

            EquipmentComboBox.SelectedValue = Reservation.EquipmentID;
        }

        private void _LoadEquipmentComboBox()
        {
            DataTable dt = ClsEquipments.GetEquipments();

            EquipmentComboBox.Items.Clear();

            foreach (DataRow Row in dt.Rows)
            {
                EquipmentComboBox.Items.Add(Row["Equipment Type"].ToString());
            }

            if (EquipmentComboBox.Items.Count > 0)
            {
                EquipmentComboBox.SelectedIndex = 0;
            }
        }

        private void _LoadWorkspaceInfo(int WorkspaceID)
        {
            DataTable dt = ClsWorkspaces.SearchByID(WorkspaceID);

            if (dt != null && dt.Rows.Count > 0)
            {
                this.WorkspaceID = Convert.ToInt32(dt.Rows[0]["Workspace ID"]);

                WorkSpaceTypeTxtBx.Text =
                    dt.Rows[0]["Workspace Type"].ToString();

                LocationTxtBx.Text =
                    dt.Rows[0]["District Location"].ToString();

                LayoutTxtBx.Text =
                    dt.Rows[0]["Layout"].ToString();
            }
            else
            {
                this.WorkspaceID = -1;

                WorkSpaceTypeTxtBx.Text = string.Empty;

                LocationTxtBx.Text = string.Empty;

                LayoutTxtBx.Text = string.Empty;
            }
        }

        private void _LoadMemberInfo(int MemberID)
        {
            DataTable dt = ClsMembers.SearchById(MemberID);

            if (dt != null && dt.Rows.Count > 0)
            {
                this.MemberID = Convert.ToInt32(dt.Rows[0]["Member ID"]);

                NameTxtBx.Text =
                    dt.Rows[0]["Member Name"].ToString();

                CorporateTxtBx.Text =
                    dt.Rows[0]["Corporate Affiliation"].ToString();
            }
            else
            {
                this.MemberID = -1;

                NameTxtBx.Text = string.Empty;

                CorporateTxtBx.Text = string.Empty;
            }
        }

        private void WorkspacesFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WorkspacesFilterComboBox.SelectedIndex == 0)
            {
                WorkspaceSearchTextBox.Visible = false;
            }
            else
            {
                WorkspaceSearchTextBox.Visible = true;
            }
        }

        private void WorkspaceSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = null;

            switch (WorkspacesFilterComboBox.SelectedIndex)
            {
                case 1:

                    int id = 0;

                    int.TryParse(WorkspaceSearchTextBox.Text, out id);

                    dt = ClsWorkspaces.SearchByID(id);

                    break;
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                WorkspaceID =
                    Convert.ToInt32(dt.Rows[0]["Workspace ID"]);

                WorkSpaceTypeTxtBx.Text =
                    dt.Rows[0]["Workspace Type"].ToString();

                LocationTxtBx.Text =
                    dt.Rows[0]["District Location"].ToString();

                LayoutTxtBx.Text =
                    dt.Rows[0]["Layout"].ToString();
            }
            else
            {
                WorkspaceID = -1;

                WorkSpaceTypeTxtBx.Text = string.Empty;

                LocationTxtBx.Text = string.Empty;

                LayoutTxtBx.Text = string.Empty;
            }

            if (WorkspaceSearchTextBox.Text == string.Empty)
            {
                WorkspaceID = -1;

                WorkSpaceTypeTxtBx.Text = string.Empty;

                LocationTxtBx.Text = string.Empty;

                LayoutTxtBx.Text = string.Empty;
            }
        }

        private void MembersFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MembersFilterComboBox.SelectedIndex == 0)
            {
                MemberSearchTextBox.Visible = false;
            }
            else
            {
                MemberSearchTextBox.Visible = true;
            }
        }

        private void MemberSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = null;

            switch (MembersFilterComboBox.SelectedIndex)
            {
                case 1:

                    int id = 0;

                    int.TryParse(MemberSearchTextBox.Text, out id);

                    dt = ClsMembers.SearchById(id);

                    break;

                case 2:

                    dt = ClsMembers.SearchByName(MemberSearchTextBox.Text);

                    break;
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                MemberID = Convert.ToInt32(dt.Rows[0]["Member ID"]);

                NameTxtBx.Text = dt.Rows[0]["Member Name"].ToString();

                CorporateTxtBx.Text = dt.Rows[0]["Corporate Affiliation"].ToString();
            }
            else
            {
                MemberID = -1;

                NameTxtBx.Text = string.Empty;

                CorporateTxtBx.Text = string.Empty;
            }

            if (MemberSearchTextBox.Text == string.Empty)
            {
                MemberID = -1;

                NameTxtBx.Text = string.Empty;

                CorporateTxtBx.Text = string.Empty;
            }
        }

        private bool _AddNewReservation()
        {
            Reservation.WorkspaceID = WorkspaceID;

            Reservation.MemberID = MemberID;

            Reservation.EquipmentID = ClsEquipments.SearchByType(EquipmentComboBox.Text).EquipmentID;



            decimal Rate = 0;

            decimal.TryParse(WorkSpaceRateTxtBx.Text, out Rate);

            Reservation.Rate = Rate;

            if (Reservation.Save())
            {
                MessageBox.Show("Reservation Added Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Mode = enMode.Update;

                ReservationID = Reservation.ReservationID;

                MemberIdLbl.Text = ReservationID.ToString();

                return true;
            }
            else
            {
                MessageBox.Show("Error : Reservation Is Not Added Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
        }

        private void _UpdateReservation()
        {
            Reservation.WorkspaceID = WorkspaceID;

            Reservation.MemberID = MemberID;

            Reservation.EquipmentID =
                Convert.ToInt32(EquipmentComboBox.SelectedValue);

            decimal Rate = 0;

            decimal.TryParse(WorkSpaceRateTxtBx.Text, out Rate);

            Reservation.Rate = Rate;

            if (Reservation.Save())
            {
                MessageBox.Show("Reservation Updated Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error : Reservation Is Not Updated Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (WorkspaceID == -1)
            {
                MessageBox.Show("Please Select Workspace First");

                return;
            }

            if (MemberID == -1)
            {
                MessageBox.Show("Please Select Member First");

                return;
            }

            if (Mode == enMode.AddNew)
            {
                if (_AddNewReservation())
                    frmAddEditReservation_Load(sender, e);
            }
            else
            {
                _UpdateReservation();
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            MemberIdLbl.Text = "N/A";

            WorkSpaceRateTxtBx.Text = string.Empty;

            WorkspaceSearchTextBox.Text = string.Empty;

            MemberSearchTextBox.Text = string.Empty;

            WorkSpaceTypeTxtBx.Text = string.Empty;

            LocationTxtBx.Text = string.Empty;

            LayoutTxtBx.Text = string.Empty;

            NameTxtBx.Text = string.Empty;

            CorporateTxtBx.Text = string.Empty;

            WorkspaceID = -1;

            MemberID = -1;

            EquipmentComboBox.SelectedIndex = 0;
        }

        private void AddNewWorkspaceBtn_Click(object sender, EventArgs e)
        {
            frmAddEditWorkspace Form =
                new frmAddEditWorkspace(-1);

            Form.ShowDialog();

            if (Form.ReturnedWorkspaceID > 0)
            {
                WorkspaceID = Form.ReturnedWorkspaceID;

                _LoadWorkspaceInfo(WorkspaceID);
            }
        }

        private void AddNewMemberBtn_Click(object sender, EventArgs e)
        {
            frmAddEditMember Form =
                new frmAddEditMember(-1);

            Form.ShowDialog();

            if (Form.ReturnedMemberID > 0)
            {
                MemberID = Form.ReturnedMemberID;

                _LoadMemberInfo(MemberID);
            }
        }

        private void WorkSpaceRateTxtBx_Validating(object sender,
            CancelEventArgs e)
        {
            if (WorkSpaceRateTxtBx.Text == string.Empty)
            {
                e.Cancel = true;

                errorProvider1.SetError(WorkSpaceRateTxtBx,
                    "Required");
            }
            else
            {
                decimal Rate = 0;

                if (!decimal.TryParse(WorkSpaceRateTxtBx.Text,
                    out Rate))
                {
                    e.Cancel = true;

                    errorProvider1.SetError(WorkSpaceRateTxtBx,
                        "Invalid Rate");
                }
                else
                {
                    errorProvider1.SetError(WorkSpaceRateTxtBx,
                        null);
                }
            }
        }
    }
}