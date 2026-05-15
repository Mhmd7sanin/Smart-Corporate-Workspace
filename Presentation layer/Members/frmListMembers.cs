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

namespace Presentation_layer.Members
{
    public partial class frmListMembers : Form
    {
        //DashboardForm MainForm;
        public frmListMembers()
        {
            InitializeComponent();
        }
        private void _LoadDataGrideView()
        {
            MembersDataGrideView.DataSource = ClsMembers.GetMembers();
            RecordLbl.Text = "# Records : " + ClsMembers.CountMembers().ToString();
            // ===== BASIC GRID SETTINGS =====
            MembersDataGrideView.BorderStyle = BorderStyle.None;
            MembersDataGrideView.EnableHeadersVisualStyles = false; // Disable default system styles
            MembersDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MembersDataGrideView.AllowUserToAddRows = false;
            MembersDataGrideView.RowHeadersVisible = false; // Hide row headers
            MembersDataGrideView.BackgroundColor = Color.White;
            MembersDataGrideView.GridColor = Color.FromArgb(230, 230, 230);
            MembersDataGrideView.AllowUserToResizeColumns = false;
            MembersDataGrideView.ReadOnly = true;

            // ===== COLUMN HEADERS =====
            MembersDataGrideView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 55, 60); // Dark blue
            MembersDataGrideView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            MembersDataGrideView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            MembersDataGrideView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MembersDataGrideView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MembersDataGrideView.ColumnHeadersHeight = 35;

            // ===== ROWS =====
            MembersDataGrideView.RowsDefaultCellStyle.BackColor = Color.White;
            MembersDataGrideView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            MembersDataGrideView.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
            MembersDataGrideView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 247, 247); // Light gray
            MembersDataGrideView.RowTemplate.Height = 30;
            MembersDataGrideView.Columns[0].Width = 10;
            MembersDataGrideView.Columns[1].Width = 20;
            MembersDataGrideView.Columns[2].Width = 400;

            // ===== SELECTION STYLING =====
            MembersDataGrideView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Nice blue
            MembersDataGrideView.DefaultCellStyle.SelectionForeColor = Color.White;

            // ===== CELL BORDERS =====
            MembersDataGrideView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // ===== HOVER EFFECTS =====
            MembersDataGrideView.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    MembersDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            MembersDataGrideView.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0 && !MembersDataGrideView.Rows[e.RowIndex].Selected)
                {
                    MembersDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor =
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

        private void MembersDataViewForm_Load(object sender, EventArgs e)
        {
            _RefreshAllControlsPadding();
            _LoadComboBoxAndSearchTextBox();
            _LoadDataGrideView();
        }

        private void MembersDataViewForm_SizeChanged(object sender, EventArgs e)
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
                    MembersDataGrideView.DataSource = ClsMembers.SearchById(id);
                    RecordLbl.Text = "# Records : " + MembersDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 2:
                    MembersDataGrideView.DataSource = ClsMembers.SearchByName(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + MembersDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 3:
                    MembersDataGrideView.DataSource = ClsMembers.SearchByCorporateAffiliation(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + MembersDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;

            }
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            frmAddEditMember AddNewForm = new frmAddEditMember(-1);
            AddNewForm.ShowDialog();
            _LoadDataGrideView();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberInfo Form = new frmMemberInfo((int)MembersDataGrideView.CurrentRow.Cells[0].Value);
            Form.ShowDialog();
            _LoadDataGrideView();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditMember Form = new frmAddEditMember((int)MembersDataGrideView.CurrentRow.Cells[0].Value);
            Form.ShowDialog();
            _LoadDataGrideView();
        }

        private void MembersDataGrideView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                MembersDataGrideView.ClearSelection();
                MembersDataGrideView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                MembersDataGrideView.CurrentCell = MembersDataGrideView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MemberID = (int)MembersDataGrideView.CurrentRow.Cells[0].Value;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete Member [{MemberID}] ?",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result != DialogResult.OK)
                return;

            // STEP 1: check if member has reservations
            DataTable dt = ClsReservations.GetReservationsByMemberID(MemberID);

            if (dt != null && dt.Rows.Count > 0)
            {
                DialogResult deleteReservations = MessageBox.Show(
                    $"This member has {dt.Rows.Count} reservation(s).\n\n" +
                    "Do you want to delete all reservations first?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (deleteReservations == DialogResult.Yes)
                {
                    bool allDeleted = true;

                    foreach (DataRow row in dt.Rows)
                    {
                        int ReservationID = Convert.ToInt32(row["Reservation ID"]);

                        if (!ClsReservations.Delete(ReservationID))
                        {
                            allDeleted = false;
                            break;
                        }
                    }

                    if (!allDeleted)
                    {
                        MessageBox.Show(
                            "Error deleting some reservations. Member not deleted.",
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
                        "Member not deleted because reservations exist.",
                        "Cancelled",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }
            }

            // STEP 2: delete member
            if (ClsMembers.Delete(MemberID))
            {
                MessageBox.Show("Member deleted successfully.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Member was not deleted.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            _LoadDataGrideView();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not Implemented Yet", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not Implemented Yet", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
