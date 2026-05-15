using Business_Layer;
using Presentation_layer.Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_layer.Reservations
{
    public partial class frmListReservations : Form
    {
        public frmListReservations()
        {
            InitializeComponent();
        }

        private void _LoadDataGrideView()
        {
            ReservationsDataGrideView.DataSource = ClsReservations.GetReservations();
            RecordLbl.Text = "# Records : " + ClsReservations.CountReservations().ToString();
            // ===== BASIC GRID SETTINGS =====
            ReservationsDataGrideView.BorderStyle = BorderStyle.None;
            ReservationsDataGrideView.EnableHeadersVisualStyles = false; // Disable default system styles
            ReservationsDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReservationsDataGrideView.AllowUserToAddRows = false;
            ReservationsDataGrideView.RowHeadersVisible = false; // Hide row headers
            ReservationsDataGrideView.BackgroundColor = Color.White;
            ReservationsDataGrideView.GridColor = Color.FromArgb(230, 230, 230);
            ReservationsDataGrideView.AllowUserToResizeColumns = false;
            ReservationsDataGrideView.ReadOnly = true;

            // ===== COLUMN HEADERS =====
            ReservationsDataGrideView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 55, 60); // Dark blue
            ReservationsDataGrideView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ReservationsDataGrideView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            ReservationsDataGrideView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ReservationsDataGrideView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ReservationsDataGrideView.ColumnHeadersHeight = 50;

            // ===== ROWS =====
            ReservationsDataGrideView.RowsDefaultCellStyle.BackColor = Color.White;
            ReservationsDataGrideView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            ReservationsDataGrideView.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
            ReservationsDataGrideView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 247, 247); // Light gray
            ReservationsDataGrideView.RowTemplate.Height = 30;
            ReservationsDataGrideView.Columns[0].Width = 22;
            ReservationsDataGrideView.Columns[1].Width = 35;
            ReservationsDataGrideView.Columns[2].Width = 35;
            ReservationsDataGrideView.Columns[3].Width = 40;
            //ReservationsDataGrideView.Columns[4].Width = 25;
            ReservationsDataGrideView.Columns[4].Width = 40;
            ReservationsDataGrideView.Columns[5].Width = 50;
            ReservationsDataGrideView.Columns[6].Width = 50;
            ReservationsDataGrideView.Columns[7].Width = 22;
            ReservationsDataGrideView.Columns[8].Width = 70;


            // ===== SELECTION STYLING =====
            ReservationsDataGrideView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Nice blue
            ReservationsDataGrideView.DefaultCellStyle.SelectionForeColor = Color.White;

            // ===== CELL BORDERS =====
            ReservationsDataGrideView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // ===== HOVER EFFECTS =====
            ReservationsDataGrideView.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    ReservationsDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            ReservationsDataGrideView.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0 && !ReservationsDataGrideView.Rows[e.RowIndex].Selected)
                {
                    ReservationsDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor =
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

        private void ReservationsDataViewForm_Load(object sender, EventArgs e)
        {
            _RefreshAllControlsPadding();
            _LoadComboBoxAndSearchTextBox();
            _LoadDataGrideView();
        }

        private void ReservationsDataViewForm_SizeChanged(object sender, EventArgs e)
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
                    ReservationsDataGrideView.DataSource = ClsReservations.SearchByID(id);
                    RecordLbl.Text = "# Records : " + ReservationsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 2:
                    ReservationsDataGrideView.DataSource = ClsReservations.SearchByMemberName(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + ReservationsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 3:
                    ReservationsDataGrideView.DataSource = ClsReservations.SearchByCorporateAffiliation(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + ReservationsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 4:
                    ReservationsDataGrideView.DataSource = ClsReservations.SearchByWorkspaceType(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + ReservationsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 5:
                    ReservationsDataGrideView.DataSource = ClsReservations.SearchByEquipmentType(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + ReservationsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 6:
                    ReservationsDataGrideView.DataSource = ClsReservations.SearchByHubLocation(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + ReservationsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 7:
                    ReservationsDataGrideView.DataSource = ClsReservations.SearchByHubLayout(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + ReservationsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
            }
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            frmAddEditReservation AddNewForm = new frmAddEditReservation(-1);
            AddNewForm.ShowDialog();
            _LoadDataGrideView();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationInfo Form = new frmReservationInfo((int)ReservationsDataGrideView.CurrentRow.Cells[0].Value);
            Form.ShowDialog();
            _LoadDataGrideView();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditReservation Form = new frmAddEditReservation((int)ReservationsDataGrideView.CurrentRow.Cells[0].Value);
            Form.ShowDialog();
            _LoadDataGrideView();

        }

        private void ReservationsDataGrideView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                ReservationsDataGrideView.ClearSelection();
                ReservationsDataGrideView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                ReservationsDataGrideView.CurrentCell = ReservationsDataGrideView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete Reservation[" + ReservationsDataGrideView.CurrentRow.Cells[0].Value + "]", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ClsReservations.Delete((int)ReservationsDataGrideView.CurrentRow.Cells[0].Value))
                    MessageBox.Show("Reservation Deleted Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error:Reservation Does Not Deleted Successfully.\nDue to User Constrant", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            _LoadDataGrideView();
        }
    }
}
