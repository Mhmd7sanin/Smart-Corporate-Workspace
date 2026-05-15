using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Business_Layer;
using Presentation_layer.Hubs;

namespace Presentation_layer.Workspaces
{
    public partial class frmAddEditWorkspace : Form
    {

        public int ReturnedWorkspaceID
        {
            get
            {
                return WorkspaceID;
            }
        }

        private int WorkspaceID;
        private int HubID = -1;

        private ClsWorkspaces Workspace;

        private enum enMode { AddNew = 1, Update = 2 };
        private enMode Mode;

        public frmAddEditWorkspace(int id)
        {
            InitializeComponent();

            WorkspaceID = id;

            if (WorkspaceID == -1)
                Mode = enMode.AddNew;
            else
                Mode = enMode.Update;
        }

        private void frmAddEditWorkspace_Load(object sender, EventArgs e)
        {
            FilterComboBox.SelectedIndex = 0;

            if (Mode == enMode.AddNew)
            {
                Workspace = new ClsWorkspaces();

                MemberIdLbl.Text = "N/A";

                return;
            }

            Workspace = ClsWorkspaces.Find(WorkspaceID);

            TitleLbl.Text = "Update Workspace";

            this.Text = "Update Workspace";

            if (Workspace == null)
            {
                MessageBox.Show("This form will be closed because No Workspace with ID = " + WorkspaceID);

                this.Close();

                return;
            }

            MemberIdLbl.Text = Workspace.WorkspaceID.ToString();

            WorkspaceTypeTxtBx.Text = Workspace.WorkspaceType;

            WorkSpaceRateTxtBx.Text = Workspace.WorkspaceRate.ToString();

            HubID = Workspace.HubID;

            _LoadHubInfo(HubID);
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedIndex == 0)
            {
                SearchTextBox.Visible = false;
            }
            else
            {
                SearchTextBox.Visible = true;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = null;

            switch (FilterComboBox.SelectedIndex)
            {
                case 1:

                    int id = 0;

                    int.TryParse(SearchTextBox.Text, out id);

                    dt = ClsHubs.SearchByID(id);

                    break;

                case 2:

                    dt = ClsHubs.SearchByLocation(SearchTextBox.Text);

                    break;

                case 3:

                    dt = ClsHubs.SearchByLayout(SearchTextBox.Text);

                    break;
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                HubID = Convert.ToInt32(dt.Rows[0]["Hub ID"]);

                LocationTxtBx.Text = dt.Rows[0]["District Location"].ToString();

                LayoutTxtBx.Text = dt.Rows[0]["Layout"].ToString();
            }
            else
            {
                HubID = -1;

                LocationTxtBx.Text = string.Empty;

                LayoutTxtBx.Text = string.Empty;
            }

            if (SearchTextBox.Text == string.Empty)
            {
                HubID = -1;

                LocationTxtBx.Text = string.Empty;

                LayoutTxtBx.Text = string.Empty;
            }
        }


        private void _LoadHubInfo(int HubID)
        {
            DataTable dt = ClsHubs.SearchByID(HubID);

            if (dt != null && dt.Rows.Count > 0)
            {
                this.HubID = Convert.ToInt32(dt.Rows[0]["Hub ID"]);

                LocationTxtBx.Text = dt.Rows[0]["District Location"].ToString();

                LayoutTxtBx.Text = dt.Rows[0]["Layout"].ToString();
            }
            else
            {
                this.HubID = -1;

                LocationTxtBx.Text = string.Empty;

                LayoutTxtBx.Text = string.Empty;
            }
        }

        private bool _AddNewWorkspace()
        {
            Workspace.HubID = HubID;

            Workspace.WorkspaceType = WorkspaceTypeTxtBx.Text;

            decimal Rate = 0;

            decimal.TryParse(WorkSpaceRateTxtBx.Text, out Rate);

            Workspace.WorkspaceRate = Rate;

            if (Workspace.Save())
            {
                MessageBox.Show("Workspace Added Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Mode = enMode.Update;

                WorkspaceID = Workspace.WorkspaceID;

                MemberIdLbl.Text = WorkspaceID.ToString();

                return true;
            }
            else
            {
                MessageBox.Show("Error : Workspace Is Not Added Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
        }

        private void _UpdateWorkspace()
        {
            Workspace.HubID = HubID;

            Workspace.WorkspaceType = WorkspaceTypeTxtBx.Text;

            decimal Rate = 0;

            decimal.TryParse(WorkSpaceRateTxtBx.Text, out Rate);

            Workspace.WorkspaceRate = Rate;

            if (Workspace.Save())
            {
                MessageBox.Show("Workspace Updated Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error : Workspace Is Not Updated Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (HubID == -1)
            {
                MessageBox.Show("Please Select Hub First",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (Mode == enMode.AddNew)
            {
                if (_AddNewWorkspace())
                    frmAddEditWorkspace_Load(sender, e);
            }
            else
            {
                _UpdateWorkspace();
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            MemberIdLbl.Text = "N/A";

            WorkspaceTypeTxtBx.Text = string.Empty;

            WorkSpaceRateTxtBx.Text = string.Empty;

            SearchTextBox.Text = string.Empty;

            LocationTxtBx.Text = string.Empty;

            LayoutTxtBx.Text = string.Empty;

            HubID = -1;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Select Search Filter First",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            switch (FilterComboBox.SelectedIndex)
            {
                case 1:

                    int id = 0;

                    int.TryParse(SearchTextBox.Text, out id);

                    _LoadHubInfo(id);

                    break;

                case 2:
                case 3:

                    _LoadHubInfo(-1);

                    break;
            }

            if (HubID == -1)
            {
                MessageBox.Show("No Hub Found",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void AddNewHubBtn_Click(object sender, EventArgs e)
        {
            frmAddEditHub Form = new frmAddEditHub(-1);

            Form.ShowDialog();

            if (Form.ReturnedHubId > 0)
            {
                HubID = Form.ReturnedHubId;

                _LoadHubInfo(HubID);
            }
        }

        private void WorkspaceTypeTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (WorkspaceTypeTxtBx.Text == string.Empty)
            {
                e.Cancel = true;

                errorProvider1.SetError(WorkspaceTypeTxtBx, "Required");
            }
            else
            {
                errorProvider1.SetError(WorkspaceTypeTxtBx, null);
            }
        }

        private void WorkSpaceRateTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (WorkSpaceRateTxtBx.Text == string.Empty)
            {
                e.Cancel = true;

                errorProvider1.SetError(WorkSpaceRateTxtBx, "Required");
            }
            else
            {
                decimal Rate = 0;

                if (!decimal.TryParse(WorkSpaceRateTxtBx.Text, out Rate))
                {
                    e.Cancel = true;

                    errorProvider1.SetError(WorkSpaceRateTxtBx, "Invalid Rate");
                }
                else
                {
                    errorProvider1.SetError(WorkSpaceRateTxtBx, null);
                }
            }
        }
    }
}