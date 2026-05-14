using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_layer
{
    public partial class frmMain : Form
    {
        bool CurrentUserCollapsed = true;
        bool ManageAppCollapsed = true;
        bool ApplicationsCollapsed = true;


        public frmMain()
        {
            InitializeComponent();
            this.TopLevel = true;
        }


        private void _RefreshDataGrideView()
        {
            //dataGridView1.DataSource = ClsPeople.GetPeople();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _RefreshDataGrideView();
            OpenChildForm(new Members.frmListMembers());
            this.WindowState = FormWindowState.Maximized;
        }
        private void OpenChildForm(Form ChildForm)
        {
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(ChildForm);
            this.panelDesktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }


        private void MembersBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Members.frmListMembers());
        }

        private void HubsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Hubs.frmListHubs());
        }

        private void WorkspacesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Workspaces.frmListWorkspaces());
        }

        private void EquipmentBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Equipment.frmListEquipment());
        }

        private void ReservationsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reservations.frmListReservations());
        }


    }
}
