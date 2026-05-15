using Business_Layer;
using Presentation_layer.Members;
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
    public partial class frmListHubs : Form
    {
        public frmListHubs()
        {
            InitializeComponent();
        }

        private void _LoadDataGrideView()
        {
            HubsDataGrideView.DataSource = ClsHubs.GetHubs();
            RecordLbl.Text = "# Records : " + ClsHubs.CountHubs().ToString();
            // ===== BASIC GRID SETTINGS =====
            HubsDataGrideView.BorderStyle = BorderStyle.None;
            HubsDataGrideView.EnableHeadersVisualStyles = false; // Disable default system styles
            HubsDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HubsDataGrideView.AllowUserToAddRows = false;
            HubsDataGrideView.RowHeadersVisible = false; // Hide row headers
            HubsDataGrideView.BackgroundColor = Color.White;
            HubsDataGrideView.GridColor = Color.FromArgb(230, 230, 230);
            HubsDataGrideView.AllowUserToResizeColumns = false;
            HubsDataGrideView.ReadOnly = true;

            // ===== COLUMN HEADERS =====
            HubsDataGrideView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 55, 60); // Dark blue
            HubsDataGrideView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            HubsDataGrideView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            HubsDataGrideView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            HubsDataGrideView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            HubsDataGrideView.ColumnHeadersHeight = 35;

            // ===== ROWS =====
            HubsDataGrideView.RowsDefaultCellStyle.BackColor = Color.White;
            HubsDataGrideView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            HubsDataGrideView.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
            HubsDataGrideView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 247, 247); // Light gray
            HubsDataGrideView.RowTemplate.Height = 30;
            HubsDataGrideView.Columns[0].Width = 10;
            HubsDataGrideView.Columns[1].Width = 20;
            HubsDataGrideView.Columns[2].Width = 400;

            // ===== SELECTION STYLING =====
            HubsDataGrideView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Nice blue
            HubsDataGrideView.DefaultCellStyle.SelectionForeColor = Color.White;

            // ===== CELL BORDERS =====
            HubsDataGrideView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // ===== HOVER EFFECTS =====
            HubsDataGrideView.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    HubsDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            HubsDataGrideView.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0 && !HubsDataGrideView.Rows[e.RowIndex].Selected)
                {
                    HubsDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                        e.RowIndex % 2 == 0 ? Color.White : Color.FromArgb(247, 247, 247);
                }
            };
        }

        private void _RefreshAllControlsPadding()
        {
            TitleLbl.Padding = new Padding(((short)(TitlePanel.Size.Width / 2.6)), (short)(TitlePanel.Size.Height / 4.2), 0, 0);
        }

        private void _LoadComboBoxAndSearchTextBox()
        {
            FilterComboBox.SelectedIndex = 0; FilterComboBox.ForeColor = Color.FromArgb(64, 64, 64);
            if (FilterComboBox.SelectedIndex == 0) SearchTextBox.Visible = false;

        }

        private void HubsDataViewForm_Load(object sender, EventArgs e)
        {
            _RefreshAllControlsPadding();
            _LoadComboBoxAndSearchTextBox();
            _LoadDataGrideView();
        }

        private void HubsDataViewForm_SizeChanged(object sender, EventArgs e)
        {
            _RefreshAllControlsPadding();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedIndex == 0)
            {
                SearchTextBox.Visible = false; _LoadDataGrideView();
            }
            else SearchTextBox.Visible = true;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            switch (FilterComboBox.SelectedIndex)
            {
                case 1:
                    int id = 0; int.TryParse(SearchTextBox.Text, out id);
                    HubsDataGrideView.DataSource = ClsHubs.SearchByID(id);
                    RecordLbl.Text = "# Records : " + HubsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 2:
                    HubsDataGrideView.DataSource = ClsHubs.SearchByLocation(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + HubsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 3:
                    HubsDataGrideView.DataSource = ClsHubs.SearchByLayout(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + HubsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;

            }
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            frmAddEditHub AddNewForm = new frmAddEditHub(-1);
            AddNewForm.ShowDialog();
            _LoadDataGrideView();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHubInfo Form = new frmHubInfo((int)HubsDataGrideView.CurrentRow.Cells[0].Value);
            Form.ShowDialog();
            _LoadDataGrideView();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditHub Form = new frmAddEditHub((int)HubsDataGrideView.CurrentRow.Cells[0].Value);
            Form.ShowDialog();
            _LoadDataGrideView();
        }

        private void MembersDataGrideView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                HubsDataGrideView.ClearSelection();
                HubsDataGrideView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                HubsDataGrideView.CurrentCell = HubsDataGrideView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int HubID =
                (int)HubsDataGrideView.CurrentRow.Cells[0].Value;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete Hub [{HubID}] ?",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result != DialogResult.OK)
                return;

            // Check workspaces linked to hub
            DataTable dt = ClsWorkspaces.GetWorkspacesByHubID(HubID);

            if (dt != null && dt.Rows.Count > 0)
            {
                DialogResult deleteWorkspaces = MessageBox.Show(
                    $"This hub has {dt.Rows.Count} workspace(s).\n\n" +
                    "Do you want to delete all workspaces and reservations first?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (deleteWorkspaces == DialogResult.Yes)
                {
                    bool allDeleted = true;

                    foreach (DataRow workspaceRow in dt.Rows)
                    {
                        int WorkspaceID =
                            Convert.ToInt32(workspaceRow["Workspace ID"]);

                        // Delete reservations first
                        DataTable dtReservations =
                            ClsReservations.GetReservationsByWorkspaceID(WorkspaceID);

                        if (dtReservations != null &&
                            dtReservations.Rows.Count > 0)
                        {
                            foreach (DataRow reservationRow in dtReservations.Rows)
                            {
                                int ReservationID =
                                    Convert.ToInt32(reservationRow["Reservation ID"]);

                                if (!ClsReservations.Delete(ReservationID))
                                {
                                    allDeleted = false;
                                    break;
                                }
                            }
                        }

                        if (!allDeleted)
                            break;

                        // Delete workspace
                        if (!ClsWorkspaces.Delete(WorkspaceID))
                        {
                            allDeleted = false;
                            break;
                        }
                    }

                    if (!allDeleted)
                    {
                        MessageBox.Show(
                            "Error deleting workspaces or reservations. Hub not deleted.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        _LoadDataGrideView();

                        return;
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Hub not deleted because workspaces exist.",
                        "Cancelled",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }
            }

            // Delete hub
            if (ClsHubs.Delete(HubID))
            {
                MessageBox.Show(
                    "Hub deleted successfully.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Error: Hub was not deleted.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            _LoadDataGrideView();
        }

    }
}
