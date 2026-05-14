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

namespace Presentation_layer.Workspaces
{
    public partial class frmListWorkspaces : Form
    {
        public frmListWorkspaces()
        {
            InitializeComponent();
        }

        private void _LoadDataGrideView()
        {
            WorkspacesDataGrideView.DataSource = ClsWorkspaces.GetWorkspaces();
            RecordLbl.Text = "# Records : " + ClsWorkspaces.CountWorkspaces().ToString();
            // ===== BASIC GRID SETTINGS =====
            WorkspacesDataGrideView.BorderStyle = BorderStyle.None;
            WorkspacesDataGrideView.EnableHeadersVisualStyles = false; // Disable default system styles
            WorkspacesDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WorkspacesDataGrideView.AllowUserToAddRows = false;
            WorkspacesDataGrideView.RowHeadersVisible = false; // Hide row headers
            WorkspacesDataGrideView.BackgroundColor = Color.White;
            WorkspacesDataGrideView.GridColor = Color.FromArgb(230, 230, 230);
            WorkspacesDataGrideView.AllowUserToResizeColumns = false;
            WorkspacesDataGrideView.ReadOnly = true;

            // ===== COLUMN HEADERS =====
            WorkspacesDataGrideView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 55, 60); // Dark blue
            WorkspacesDataGrideView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            WorkspacesDataGrideView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            WorkspacesDataGrideView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            WorkspacesDataGrideView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            WorkspacesDataGrideView.ColumnHeadersHeight = 35;

            // ===== ROWS =====
            WorkspacesDataGrideView.RowsDefaultCellStyle.BackColor = Color.White;
            WorkspacesDataGrideView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            WorkspacesDataGrideView.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
            WorkspacesDataGrideView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 247, 247); // Light gray
            WorkspacesDataGrideView.RowTemplate.Height = 30;
            WorkspacesDataGrideView.Columns[0].Width = 40;
            WorkspacesDataGrideView.Columns[1].Width = 80;
            WorkspacesDataGrideView.Columns[2].Width = 100;
            WorkspacesDataGrideView.Columns[3].Width = 100;
            WorkspacesDataGrideView.Columns[4].Width = 100;

            // ===== SELECTION STYLING =====
            WorkspacesDataGrideView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Nice blue
            WorkspacesDataGrideView.DefaultCellStyle.SelectionForeColor = Color.White;

            // ===== CELL BORDERS =====
            WorkspacesDataGrideView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // ===== HOVER EFFECTS =====
            WorkspacesDataGrideView.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    WorkspacesDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            };

            WorkspacesDataGrideView.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0 && !WorkspacesDataGrideView.Rows[e.RowIndex].Selected)
                {
                    WorkspacesDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor =
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

        private void WorkspacesDataViewForm_Load(object sender, EventArgs e)
        {
            _RefreshAllControlsPadding();
            _LoadComboBoxAndSearchTextBox();
            _LoadDataGrideView();
        }

        private void WorkspacesDataViewForm_SizeChanged(object sender, EventArgs e)
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
                    WorkspacesDataGrideView.DataSource = ClsWorkspaces.SearchByID(id);
                    RecordLbl.Text = "# Records : " + WorkspacesDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 2:
                    WorkspacesDataGrideView.DataSource = ClsWorkspaces.SearchByWorkspaceType(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + WorkspacesDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 3:
                    WorkspacesDataGrideView.DataSource = ClsWorkspaces.SearchByHubDistrictLocation(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + WorkspacesDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 4:
                    WorkspacesDataGrideView.DataSource = ClsWorkspaces.SearchByHubLayout(SearchTextBox.Text);
                    RecordLbl.Text = "# Records : " + WorkspacesDataGrideView.RowCount;
                    if (SearchTextBox.Text == string.Empty) _LoadDataGrideView(); break;
                case 5:
                    decimal Rate = 0; decimal.TryParse(SearchTextBox.Text, out Rate);
                    WorkspacesDataGrideView.DataSource = ClsWorkspaces.SearchByRate(Rate);
                    RecordLbl.Text = "# Records : " + WorkspacesDataGrideView.RowCount;
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
            frmWorkspaceInfo Form = new frmWorkspaceInfo((int)WorkspacesDataGrideView.CurrentRow.Cells[0].Value);
            Form.ShowDialog();
            _LoadDataGrideView();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddAndUpdatePerson Form = new AddAndUpdatePerson((int)PeopleDataGrideView.CurrentRow.Cells[0].Value);
            //Form.ShowDialog();
            //_LoadDataGrideView();

        }

        private void WorkspacesDataGrideView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                WorkspacesDataGrideView.ClearSelection();
                WorkspacesDataGrideView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                WorkspacesDataGrideView.CurrentCell = WorkspacesDataGrideView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete Person[" + WorkspacesDataGrideView.CurrentRow.Cells[0].Value + "]", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ClsEquipments.Delete((int)WorkspacesDataGrideView.CurrentRow.Cells[0].Value))
                    MessageBox.Show("Person Deleted Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error:Person Does Not Deleted Successfully.\nDue to User Constrant", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            _LoadDataGrideView();
        }

    }
}
