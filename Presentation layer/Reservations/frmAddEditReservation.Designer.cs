namespace Presentation_layer.Reservations
{
    partial class frmAddEditReservation
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
            this.LayoutTxtBx = new System.Windows.Forms.TextBox();
            this.LocationTxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WorkspaceSearchTextBox = new System.Windows.Forms.TextBox();
            this.WorkspacesFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.MemberIdLbl = new System.Windows.Forms.Label();
            this.WorkSpaceRateTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.AddNewWorkspaceBtn = new System.Windows.Forms.Button();
            this.WorkSpaceTypeTxtBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EquipmentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTxtBx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CorporateTxtBx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AddNewMemberBtn = new System.Windows.Forms.Button();
            this.MemberSearchTextBox = new System.Windows.Forms.TextBox();
            this.MembersFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutTxtBx
            // 
            this.LayoutTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LayoutTxtBx.Enabled = false;
            this.LayoutTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutTxtBx.Location = new System.Drawing.Point(749, 375);
            this.LayoutTxtBx.Name = "LayoutTxtBx";
            this.LayoutTxtBx.Size = new System.Drawing.Size(335, 38);
            this.LayoutTxtBx.TabIndex = 62;
            // 
            // LocationTxtBx
            // 
            this.LocationTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationTxtBx.Enabled = false;
            this.LocationTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTxtBx.Location = new System.Drawing.Point(749, 297);
            this.LocationTxtBx.Name = "LocationTxtBx";
            this.LocationTxtBx.Size = new System.Drawing.Size(335, 38);
            this.LocationTxtBx.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(594, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 31);
            this.label5.TabIndex = 74;
            this.label5.Text = "Layout";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(594, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 31);
            this.label6.TabIndex = 73;
            this.label6.Text = "Location";
            // 
            // WorkspaceSearchTextBox
            // 
            this.WorkspaceSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkspaceSearchTextBox.Location = new System.Drawing.Point(749, 143);
            this.WorkspaceSearchTextBox.Name = "WorkspaceSearchTextBox";
            this.WorkspaceSearchTextBox.Size = new System.Drawing.Size(234, 41);
            this.WorkspaceSearchTextBox.TabIndex = 2;
            this.WorkspaceSearchTextBox.TextChanged += new System.EventHandler(this.WorkspaceSearchTextBox_TextChanged);
            // 
            // WorkspacesFilterComboBox
            // 
            this.WorkspacesFilterComboBox.BackColor = System.Drawing.Color.White;
            this.WorkspacesFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkspacesFilterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WorkspacesFilterComboBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkspacesFilterComboBox.FormattingEnabled = true;
            this.WorkspacesFilterComboBox.Items.AddRange(new object[] {
            "None",
            "Workspace Id"});
            this.WorkspacesFilterComboBox.Location = new System.Drawing.Point(749, 95);
            this.WorkspacesFilterComboBox.Name = "WorkspacesFilterComboBox";
            this.WorkspacesFilterComboBox.Size = new System.Drawing.Size(248, 39);
            this.WorkspacesFilterComboBox.TabIndex = 1;
            this.WorkspacesFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.WorkspacesFilterComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 35);
            this.label3.TabIndex = 70;
            this.label3.Text = "Find Workspace";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(732, 559);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(141, 49);
            this.ResetBtn.TabIndex = 68;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(912, 559);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(141, 49);
            this.SaveBtn.TabIndex = 63;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MemberIdLbl
            // 
            this.MemberIdLbl.AutoSize = true;
            this.MemberIdLbl.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIdLbl.Location = new System.Drawing.Point(264, 114);
            this.MemberIdLbl.Name = "MemberIdLbl";
            this.MemberIdLbl.Size = new System.Drawing.Size(52, 30);
            this.MemberIdLbl.TabIndex = 67;
            this.MemberIdLbl.Text = "N/A";
            // 
            // WorkSpaceRateTxtBx
            // 
            this.WorkSpaceRateTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkSpaceRateTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkSpaceRateTxtBx.Location = new System.Drawing.Point(245, 219);
            this.WorkSpaceRateTxtBx.Name = "WorkSpaceRateTxtBx";
            this.WorkSpaceRateTxtBx.Size = new System.Drawing.Size(318, 38);
            this.WorkSpaceRateTxtBx.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "Reservation Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.TitleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 61);
            this.panel1.TabIndex = 69;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(459, 14);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(221, 30);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Add New Reservation";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 31);
            this.label4.TabIndex = 64;
            this.label4.Text = "Rate";
            // 
            // AddNewWorkspaceBtn
            // 
            this.AddNewWorkspaceBtn.BackgroundImage = global::Presentation_layer.Properties.Resources.hotel;
            this.AddNewWorkspaceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddNewWorkspaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewWorkspaceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.AddNewWorkspaceBtn.Location = new System.Drawing.Point(1034, 92);
            this.AddNewWorkspaceBtn.Name = "AddNewWorkspaceBtn";
            this.AddNewWorkspaceBtn.Size = new System.Drawing.Size(50, 40);
            this.AddNewWorkspaceBtn.TabIndex = 72;
            this.AddNewWorkspaceBtn.UseVisualStyleBackColor = true;
            this.AddNewWorkspaceBtn.Click += new System.EventHandler(this.AddNewWorkspaceBtn_Click);
            // 
            // WorkSpaceTypeTxtBx
            // 
            this.WorkSpaceTypeTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkSpaceTypeTxtBx.Enabled = false;
            this.WorkSpaceTypeTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkSpaceTypeTxtBx.Location = new System.Drawing.Point(749, 219);
            this.WorkSpaceTypeTxtBx.Name = "WorkSpaceTypeTxtBx";
            this.WorkSpaceTypeTxtBx.Size = new System.Drawing.Size(335, 38);
            this.WorkSpaceTypeTxtBx.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 31);
            this.label7.TabIndex = 76;
            this.label7.Text = "Type";
            // 
            // EquipmentComboBox
            // 
            this.EquipmentComboBox.BackColor = System.Drawing.Color.White;
            this.EquipmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EquipmentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EquipmentComboBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentComboBox.FormattingEnabled = true;
            this.EquipmentComboBox.Items.AddRange(new object[] {
            "None",
            "Workspace Id"});
            this.EquipmentComboBox.Location = new System.Drawing.Point(245, 293);
            this.EquipmentComboBox.Name = "EquipmentComboBox";
            this.EquipmentComboBox.Size = new System.Drawing.Size(318, 39);
            this.EquipmentComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 35);
            this.label2.TabIndex = 78;
            this.label2.Text = "Equipment";
            // 
            // NameTxtBx
            // 
            this.NameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxtBx.Enabled = false;
            this.NameTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBx.Location = new System.Drawing.Point(245, 493);
            this.NameTxtBx.Name = "NameTxtBx";
            this.NameTxtBx.Size = new System.Drawing.Size(318, 38);
            this.NameTxtBx.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 31);
            this.label8.TabIndex = 89;
            this.label8.Text = "Name";
            // 
            // CorporateTxtBx
            // 
            this.CorporateTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorporateTxtBx.Enabled = false;
            this.CorporateTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorporateTxtBx.Location = new System.Drawing.Point(245, 571);
            this.CorporateTxtBx.Name = "CorporateTxtBx";
            this.CorporateTxtBx.Size = new System.Drawing.Size(318, 38);
            this.CorporateTxtBx.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 577);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 31);
            this.label10.TabIndex = 86;
            this.label10.Text = "Corporate";
            // 
            // AddNewMemberBtn
            // 
            this.AddNewMemberBtn.BackgroundImage = global::Presentation_layer.Properties.Resources.add_user__1_;
            this.AddNewMemberBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddNewMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewMemberBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.AddNewMemberBtn.Location = new System.Drawing.Point(513, 366);
            this.AddNewMemberBtn.Name = "AddNewMemberBtn";
            this.AddNewMemberBtn.Size = new System.Drawing.Size(50, 40);
            this.AddNewMemberBtn.TabIndex = 85;
            this.AddNewMemberBtn.UseVisualStyleBackColor = true;
            this.AddNewMemberBtn.Click += new System.EventHandler(this.AddNewMemberBtn_Click);
            // 
            // MemberSearchTextBox
            // 
            this.MemberSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberSearchTextBox.Location = new System.Drawing.Point(245, 417);
            this.MemberSearchTextBox.Name = "MemberSearchTextBox";
            this.MemberSearchTextBox.Size = new System.Drawing.Size(318, 41);
            this.MemberSearchTextBox.TabIndex = 4;
            this.MemberSearchTextBox.TextChanged += new System.EventHandler(this.MemberSearchTextBox_TextChanged);
            // 
            // MembersFilterComboBox
            // 
            this.MembersFilterComboBox.BackColor = System.Drawing.Color.White;
            this.MembersFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MembersFilterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MembersFilterComboBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembersFilterComboBox.FormattingEnabled = true;
            this.MembersFilterComboBox.Items.AddRange(new object[] {
            "None",
            "Member Id",
            "Name"});
            this.MembersFilterComboBox.Location = new System.Drawing.Point(245, 367);
            this.MembersFilterComboBox.Name = "MembersFilterComboBox";
            this.MembersFilterComboBox.Size = new System.Drawing.Size(248, 39);
            this.MembersFilterComboBox.TabIndex = 3;
            this.MembersFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.MembersFilterComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 35);
            this.label11.TabIndex = 83;
            this.label11.Text = "Find Member";
            // 
            // frmAddEditReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.NameTxtBx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CorporateTxtBx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AddNewMemberBtn);
            this.Controls.Add(this.MemberSearchTextBox);
            this.Controls.Add(this.MembersFilterComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EquipmentComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WorkSpaceTypeTxtBx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LayoutTxtBx);
            this.Controls.Add(this.LocationTxtBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddNewWorkspaceBtn);
            this.Controls.Add(this.WorkspaceSearchTextBox);
            this.Controls.Add(this.WorkspacesFilterComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.MemberIdLbl);
            this.Controls.Add(this.WorkSpaceRateTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1150, 700);
            this.Name = "frmAddEditReservation";
            this.ShowIcon = false;
            this.Text = "Add Edit Reservation";
            this.Load += new System.EventHandler(this.frmAddEditReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LayoutTxtBx;
        private System.Windows.Forms.TextBox LocationTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddNewWorkspaceBtn;
        private System.Windows.Forms.TextBox WorkspaceSearchTextBox;
        private System.Windows.Forms.ComboBox WorkspacesFilterComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label MemberIdLbl;
        private System.Windows.Forms.TextBox WorkSpaceRateTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WorkSpaceTypeTxtBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameTxtBx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CorporateTxtBx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddNewMemberBtn;
        private System.Windows.Forms.TextBox MemberSearchTextBox;
        private System.Windows.Forms.ComboBox MembersFilterComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox EquipmentComboBox;
        private System.Windows.Forms.Label label2;
    }
}