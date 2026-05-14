namespace Presentation_layer.Members
{
    partial class frmListMembers
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
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MembersDataGrideView = new System.Windows.Forms.DataGridView();
            this.MembersMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchAndAddPanel = new System.Windows.Forms.Panel();
            this.AddNewBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RecordLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridePanel = new System.Windows.Forms.Panel();
            this.panelPeopleManagement = new System.Windows.Forms.Panel();
            this.TitlePanel.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MembersDataGrideView)).BeginInit();
            this.MembersMenuStrip.SuspendLayout();
            this.SearchAndAddPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DataGridePanel.SuspendLayout();
            this.panelPeopleManagement.SuspendLayout();
            this.SuspendLayout();
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
            this.TitleLbl.Size = new System.Drawing.Size(823, 61);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "      Manage Members";
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
            "Member ID",
            "Name",
            "Corporate Affiliation"});
            this.FilterComboBox.Location = new System.Drawing.Point(192, 57);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(248, 39);
            this.FilterComboBox.TabIndex = 1;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.MembersDataGrideView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(33, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1300, 447);
            this.panel6.TabIndex = 4;
            // 
            // MembersDataGrideView
            // 
            this.MembersDataGrideView.AllowUserToAddRows = false;
            this.MembersDataGrideView.AllowUserToDeleteRows = false;
            this.MembersDataGrideView.AllowUserToOrderColumns = true;
            this.MembersDataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembersDataGrideView.ContextMenuStrip = this.MembersMenuStrip;
            this.MembersDataGrideView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembersDataGrideView.Location = new System.Drawing.Point(0, 0);
            this.MembersDataGrideView.Name = "MembersDataGrideView";
            this.MembersDataGrideView.ReadOnly = true;
            this.MembersDataGrideView.RowHeadersWidth = 51;
            this.MembersDataGrideView.RowTemplate.Height = 24;
            this.MembersDataGrideView.Size = new System.Drawing.Size(1300, 447);
            this.MembersDataGrideView.TabIndex = 0;
            this.MembersDataGrideView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MembersDataGrideView_CellMouseDown);
            // 
            // MembersMenuStrip
            // 
            this.MembersMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MembersMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.MembersMenuStrip.Name = "contextMenuStrip1";
            this.MembersMenuStrip.Size = new System.Drawing.Size(225, 124);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.showDetailsToolStripMenuItem.Text = "Show Member Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
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
            this.AddNewBtn.BackgroundImage = global::Presentation_layer.Properties.Resources.add_user__1_;
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
            // panelPeopleManagement
            // 
            this.panelPeopleManagement.Controls.Add(this.DataGridePanel);
            this.panelPeopleManagement.Controls.Add(this.SearchAndAddPanel);
            this.panelPeopleManagement.Controls.Add(this.TitlePanel);
            this.panelPeopleManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPeopleManagement.Location = new System.Drawing.Point(0, 0);
            this.panelPeopleManagement.Name = "panelPeopleManagement";
            this.panelPeopleManagement.Size = new System.Drawing.Size(1366, 703);
            this.panelPeopleManagement.TabIndex = 2;
            // 
            // frmListMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 703);
            this.Controls.Add(this.panelPeopleManagement);
            this.Name = "frmListMembers";
            this.Text = "frmListMembers";
            this.Load += new System.EventHandler(this.MembersDataViewForm_Load);
            this.SizeChanged += new System.EventHandler(this.MembersDataViewForm_SizeChanged);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MembersDataGrideView)).EndInit();
            this.MembersMenuStrip.ResumeLayout(false);
            this.SearchAndAddPanel.ResumeLayout(false);
            this.SearchAndAddPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DataGridePanel.ResumeLayout(false);
            this.panelPeopleManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView MembersDataGrideView;
        private System.Windows.Forms.ContextMenuStrip MembersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button AddNewBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SearchAndAddPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RecordLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DataGridePanel;
        private System.Windows.Forms.Panel panelPeopleManagement;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}