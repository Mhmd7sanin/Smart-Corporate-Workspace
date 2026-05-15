using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_layer.Hubs
{
    public partial class frmAddEditHub : Form
    {

        public delegate void DataBackEventHandler(object sender, int HubID);

        public event DataBackEventHandler DataBack;

        private int HubId; ClsHubs Hub;

        public int ReturnedHubId
        {
            get
            {
                return HubId;
            }
        }

        private enum enMode { AddNew = 1, Update = 2 };
        private enMode Mode;


        public frmAddEditHub(int id)
        {
            InitializeComponent();
            HubId = id;

            if (HubId == -1) Mode = enMode.AddNew;
            else Mode = enMode.Update;

        }

        private void frmAddEditHub_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                Hub = new ClsHubs();
                return;
            }


            if (Mode == enMode.Update)
            {
                Hub = ClsHubs.Find(HubId);
                TitleLbl.Text = "   Update Hub";

                if (Hub == null)
                {
                    MessageBox.Show("This form will be closed because No Hub with ID = " + HubId);
                    this.Close();
                    return;
                }

                HubIdLbl.Text = HubId.ToString();
                LocationTxtBx.Text = Hub.Location;
                LayoutTxtBx.Text = Hub.Layout;

                this.Text = "Update Hub";
            }
        }



        private bool _AddNewHub()
        {
            Hub.Location = LocationTxtBx.Text;
            Hub.Layout = LayoutTxtBx.Text;

            if (Hub.Save())
            {
                HubId = Hub.HubID;
                HubIdLbl.Text = HubId.ToString();

                MessageBox.Show("Hub Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mode = enMode.Update;
                return true;
            }
            else
                MessageBox.Show("Error :Hub Is Not Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return false;
        }

        private void _UpdateHub()
        {
            Hub.Location = LocationTxtBx.Text;
            Hub.Layout = LayoutTxtBx.Text;

            if (Hub.Save())
                MessageBox.Show("Hub Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error :Hub Is Not Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNewHub()) frmAddEditHub_Load(sender, e);
            }
            else _UpdateHub();
        }



        private void ResetBtn_Click(object sender, EventArgs e)
        {
            HubIdLbl.Text = "N/A";
            Hub.Location = string.Empty;
            Hub.Layout = string.Empty;
        }


        private void LocationTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (LocationTxtBx.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(LocationTxtBx, "Required");
            }
            else errorProvider1.SetError(LocationTxtBx, null);
        }

        private void LayoutTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (LayoutTxtBx.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(LayoutTxtBx, "Required");
            }
            else errorProvider1.SetError(LayoutTxtBx, null);
        }
    }
}
