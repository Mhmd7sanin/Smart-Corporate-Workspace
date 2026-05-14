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

namespace Presentation_layer.Equipment
{
    public partial class frmListEquipment : Form
    {
        public frmListEquipment()
        {
            InitializeComponent();
        }

        private void _LoadDataGrideView()
        {
            EquipmentsDataGrideView.DataSource = ClsEquipments.GetEquipments();
            RecordLbl.Text = "# Records : " + ClsEquipments.CountEquipments().ToString();
            // ===== BASIC GRID SETTINGS =====
            EquipmentsDataGrideView.BorderStyle = BorderStyle.None;
            EquipmentsDataGrideView.EnableHeadersVisualStyles = false; // Disable default system styles
            EquipmentsDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EquipmentsDataGrideView.AllowUserToAddRows = false;
            EquipmentsDataGrideView.RowHeadersVisible = false; // Hide row headers
            EquipmentsDataGrideView.BackgroundColor = Color.White;
            EquipmentsDataGrideView.GridColor = Color.FromArgb(230, 230, 230);
            EquipmentsDataGrideView.AllowUserToResizeColumns = false;
            EquipmentsDataGrideView.ReadOnly = true;

            // ===== COLUMN HEADERS =====
            EquipmentsDataGrideView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 55, 60); // Dark blue
            EquipmentsDataGrideView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            EquipmentsDataGrideView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            EquipmentsDataGrideView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EquipmentsDataGrideView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            EquipmentsDataGrideView.ColumnHeadersHeight = 35;

            // ===== ROWS =====
            EquipmentsDataGrideView.RowsDefaultCellStyle.BackColor = Color.White;
            EquipmentsDataGrideView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            EquipmentsDataGrideView.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
            EquipmentsDataGrideView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 247, 247); // Light gray
            EquipmentsDataGrideView.RowTemplate.Height = 30;
            EquipmentsDataGrideView.Columns[0].Width = 2;
            EquipmentsDataGrideView.Columns[1].Width = 1000;

            // ===== SELECTION STYLING =====
            EquipmentsDataGrideView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Nice blue
            EquipmentsDataGrideView.DefaultCellStyle.SelectionForeColor = Color.White;

            // ===== CELL BORDERS =====
            EquipmentsDataGrideView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // ===== HOVER EFFECTS =====
            EquipmentsDataGrideView.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    EquipmentsDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            EquipmentsDataGrideView.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0 && !EquipmentsDataGrideView.Rows[e.RowIndex].Selected)
                {
                    EquipmentsDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor =
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

        private void EquipmentsDataViewForm_Load(object sender, EventArgs e)
        {
            _RefreshAllControlsPadding();
            _LoadComboBoxAndSearchTextBox();
            _LoadDataGrideView();
        }

        private void EquipmentsDataViewForm_SizeChanged(object sender, EventArgs e)
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
                    EquipmentsDataGrideView.DataSource = ClsEquipments.SearchByID(id);
                    RecordLbl.Text = "# Records : " + EquipmentsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 2:
                    EquipmentsDataGrideView.DataSource = ClsEquipments.SearchByEquipmentType(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + EquipmentsDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;

            }
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            //AddAndUpdatePerson AddNewForm = new AddAndUpdatePerson(-1);
            //AddNewForm.ShowDialog();
            //_LoadDataGrideView();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipmentInfo Form = new frmEquipmentInfo((int)EquipmentsDataGrideView.CurrentRow.Cells[0].Value);
            Form.ShowDialog();
            _LoadDataGrideView();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddAndUpdatePerson Form = new AddAndUpdatePerson((int)PeopleDataGrideView.CurrentRow.Cells[0].Value);
            //Form.ShowDialog();
            //_LoadDataGrideView();

        }

        private void MembersDataGrideView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                EquipmentsDataGrideView.ClearSelection();
                EquipmentsDataGrideView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                EquipmentsDataGrideView.CurrentCell = EquipmentsDataGrideView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete Person[" + EquipmentsDataGrideView.CurrentRow.Cells[0].Value + "]", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ClsEquipments.Delete((int)EquipmentsDataGrideView.CurrentRow.Cells[0].Value))
                    MessageBox.Show("Person Deleted Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error:Person Does Not Deleted Successfully.\nDue to User Constrant", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            _LoadDataGrideView();
        }



    }
}

