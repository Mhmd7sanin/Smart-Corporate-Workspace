namespace Presentation_layer.Workspaces
{
    partial class frmListWorkspaces
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelPeopleManagement = new System.Windows.Forms.Panel();
            this.DataGridePanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.WorkspacesDataGrideView = new System.Windows.Forms.DataGridView();
            this.WorkspacesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RecordLbl = new System.Windows.Forms.Label();
            this.SearchAndAddPanel = new System.Windows.Forms.Panel();
            this.AddNewBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.panelPeopleManagement.SuspendLayout();
            this.DataGridePanel.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkspacesDataGrideView)).BeginInit();
            this.WorkspacesMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SearchAndAddPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPeopleManagement
            // 
            this.panelPeopleManagement.Controls.Add(this.DataGridePanel);
            this.panelPeopleManagement.Controls.Add(this.SearchAndAddPanel);
            this.panelPeopleManagement.Controls.Add(this.TitlePanel);
            this.panelPeopleManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPeopleManagement.Location = new System.Drawing.Point(0, 0);
            this.panelPeopleManagement.Name = "panelPeopleManagement";
            this.panelPeopleManagement.Size = new System.Drawing.Size(1366, 703);
            this.panelPeopleManagement.TabIndex = 3;
            // 
            // DataGridePanel
            // 
            this.DataGridePanel.Controls.Add(this.panel6);
            this.DataGridePanel.Controls.Add(this.flowLayoutPanel1);
            this.DataGridePanel.Controls.Add(this.panel5);
            this.DataGridePanel.Controls.Add(this.panel1);
            this.DataGridePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridePanel.Location = new System.Drawing.Point(0, 200);
            this.DataGridePanel.Name = "DataGridePanel";
            this.DataGridePanel.Size = new System.Drawing.Size(1366, 503);
            this.DataGridePanel.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.WorkspacesDataGrideView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(33, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1300, 447);
            this.panel6.TabIndex = 4;
            // 
            // WorkspacesDataGrideView
            // 
            this.WorkspacesDataGrideView.AllowUserToAddRows = false;
            this.WorkspacesDataGrideView.AllowUserToDeleteRows = false;
            this.WorkspacesDataGrideView.AllowUserToOrderColumns = true;
            this.WorkspacesDataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkspacesDataGrideView.ContextMenuStrip = this.WorkspacesMenuStrip;
            this.WorkspacesDataGrideView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkspacesDataGrideView.Location = new System.Drawing.Point(0, 0);
            this.WorkspacesDataGrideView.Name = "WorkspacesDataGrideView";
            this.WorkspacesDataGrideView.ReadOnly = true;
            this.WorkspacesDataGrideView.RowHeadersWidth = 51;
            this.WorkspacesDataGrideView.RowTemplate.Height = 24;
            this.WorkspacesDataGrideView.Size = new System.Drawing.Size(1300, 447);
            this.WorkspacesDataGrideView.TabIndex = 0;
            this.WorkspacesDataGrideView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WorkspacesDataGrideView_CellMouseDown);
            // 
            // WorkspacesMenuStrip
            // 
            this.WorkspacesMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.WorkspacesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.WorkspacesMenuStrip.Name = "contextMenuStrip1";
            this.WorkspacesMenuStrip.Size = new System.Drawing.Size(247, 76);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.showDetailsToolStripMenuItem.Text = "Show Workspaces Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1333, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(33, 447);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(33, 447);
            this.panel5.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.RecordLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 56);
            this.panel1.TabIndex = 1;
            // 
            // RecordLbl
            // 
            this.RecordLbl.AutoSize = true;
            this.RecordLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordLbl.Location = new System.Drawing.Point(16, 13);
            this.RecordLbl.Name = "RecordLbl";
            this.RecordLbl.Size = new System.Drawing.Size(132, 31);
            this.RecordLbl.TabIndex = 0;
            this.RecordLbl.Text = "# Records : ";
            // 
            // SearchAndAddPanel
            // 
            this.SearchAndAddPanel.BackColor = System.Drawing.Color.White;
            this.SearchAndAddPanel.Controls.Add(this.AddNewBtn);
            this.SearchAndAddPanel.Controls.Add(this.panel4);
            this.SearchAndAddPanel.Controls.Add(this.panel3);
            this.SearchAndAddPanel.Controls.Add(this.panel2);
            this.SearchAndAddPanel.Controls.Add(this.SearchTextBox);
            this.SearchAndAddPanel.Controls.Add(this.FilterComboBox);
            this.SearchAndAddPanel.Controls.Add(this.label1);
            this.SearchAndAddPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchAndAddPanel.Location = new System.Drawing.Point(0, 80);
            this.SearchAndAddPanel.Name = "SearchAndAddPanel";
            this.SearchAndAddPanel.Size = new System.Drawing.Size(1366, 120);
            this.SearchAndAddPanel.TabIndex = 1;
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.BackgroundImage = global::Presentation_layer.Properties.Resources.credit_card;
            this.AddNewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddNewBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.AddNewBtn.Location = new System.Drawing.Point(1244, 50);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Size = new System.Drawing.Size(65, 52);
            this.AddNewBtn.TabIndex = 7;
            this.AddNewBtn.UseVisualStyleBackColor = true;
            this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1309, 18);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1309, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 70);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 50);
            this.panel2.TabIndex = 4;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(470, 56);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(233, 41);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.BackColor = System.Drawing.Color.White;
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FilterComboBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "None",
            "Workspaces ID",
            "Type",
            "Location",
            "Layout",
            "Rate"});
            this.FilterComboBox.Location = new System.Drawing.Point(192, 57);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(248, 39);
            this.FilterComboBox.TabIndex = 1;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtar By:        ";
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TitlePanel.Controls.Add(this.TitleLbl);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1366, 80);
            this.TitlePanel.TabIndex = 0;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(0, 0);
            this.TitleLbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Padding = new System.Windows.Forms.Padding(515, 20, 0, 0);
            this.TitleLbl.Size = new System.Drawing.Size(840, 61);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "    Manage Workspaces";
            // 
            // frmListWorkspaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 703);
            this.Controls.Add(this.panelPeopleManagement);
            this.Name = "frmListWorkspaces";
            this.Text = "frmListWorkspaces";
            this.Load += new System.EventHandler(this.WorkspacesDataViewForm_Load);
            this.SizeChanged += new System.EventHandler(this.WorkspacesDataViewForm_SizeChanged);
            this.panelPeopleManagement.ResumeLayout(false);
            this.DataGridePanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkspacesDataGrideView)).EndInit();
            this.WorkspacesMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SearchAndAddPanel.ResumeLayout(false);
            this.SearchAndAddPanel.PerformLayout();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPeopleManagement;
        private System.Windows.Forms.Panel DataGridePanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView WorkspacesDataGrideView;
        private System.Windows.Forms.ContextMenuStrip WorkspacesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RecordLbl;
        private System.Windows.Forms.Panel SearchAndAddPanel;
        private System.Windows.Forms.Button AddNewBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLbl;
    }
}