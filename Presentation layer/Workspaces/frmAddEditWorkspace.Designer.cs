namespace Presentation_layer.Workspaces
{
    partial class frmAddEditWorkspace
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
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.MemberIdLbl = new System.Windows.Forms.Label();
            this.WorkSpaceRateTxtBx = new System.Windows.Forms.TextBox();
            this.WorkspaceTypeTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNewHubBtn = new System.Windows.Forms.Button();
            this.LayoutTxtBx = new System.Windows.Forms.TextBox();
            this.LocationTxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(350, 391);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(141, 49);
            this.ResetBtn.TabIndex = 46;
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
            this.SaveBtn.Location = new System.Drawing.Point(615, 391);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(141, 49);
            this.SaveBtn.TabIndex = 41;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MemberIdLbl
            // 
            this.MemberIdLbl.AutoSize = true;
            this.MemberIdLbl.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIdLbl.Location = new System.Drawing.Point(224, 110);
            this.MemberIdLbl.Name = "MemberIdLbl";
            this.MemberIdLbl.Size = new System.Drawing.Size(52, 30);
            this.MemberIdLbl.TabIndex = 45;
            this.MemberIdLbl.Text = "N/A";
            // 
            // WorkSpaceRateTxtBx
            // 
            this.WorkSpaceRateTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkSpaceRateTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkSpaceRateTxtBx.Location = new System.Drawing.Point(207, 302);
            this.WorkSpaceRateTxtBx.Name = "WorkSpaceRateTxtBx";
            this.WorkSpaceRateTxtBx.Size = new System.Drawing.Size(318, 38);
            this.WorkSpaceRateTxtBx.TabIndex = 1;
            this.WorkSpaceRateTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.WorkSpaceRateTxtBx_Validating);
            // 
            // WorkspaceTypeTxtBx
            // 
            this.WorkspaceTypeTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkspaceTypeTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkspaceTypeTxtBx.Location = new System.Drawing.Point(207, 224);
            this.WorkspaceTypeTxtBx.Name = "WorkspaceTypeTxtBx";
            this.WorkspaceTypeTxtBx.Size = new System.Drawing.Size(318, 38);
            this.WorkspaceTypeTxtBx.TabIndex = 0;
            this.WorkspaceTypeTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.WorkspaceTypeTxtBx_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 43;
            this.label1.Text = "Workspace Id";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.TitleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 61);
            this.panel1.TabIndex = 47;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(426, 14);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(216, 30);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Add New Workspace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 44;
            this.label2.Text = "Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 42;
            this.label4.Text = "Type";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(709, 148);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(234, 41);
            this.SearchTextBox.TabIndex = 3;
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
            "Hub Id",
            "Location",
            "Layout"});
            this.FilterComboBox.Location = new System.Drawing.Point(709, 100);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(248, 39);
            this.FilterComboBox.TabIndex = 2;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 35);
            this.label3.TabIndex = 49;
            this.label3.Text = "Find Hub";
            // 
            // AddNewHubBtn
            // 
            this.AddNewHubBtn.BackgroundImage = global::Presentation_layer.Properties.Resources.credit_card;
            this.AddNewHubBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddNewHubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewHubBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.AddNewHubBtn.Location = new System.Drawing.Point(994, 100);
            this.AddNewHubBtn.Name = "AddNewHubBtn";
            this.AddNewHubBtn.Size = new System.Drawing.Size(50, 40);
            this.AddNewHubBtn.TabIndex = 52;
            this.AddNewHubBtn.UseVisualStyleBackColor = true;
            this.AddNewHubBtn.Click += new System.EventHandler(this.AddNewHubBtn_Click);
            // 
            // LayoutTxtBx
            // 
            this.LayoutTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LayoutTxtBx.Enabled = false;
            this.LayoutTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutTxtBx.Location = new System.Drawing.Point(709, 302);
            this.LayoutTxtBx.Name = "LayoutTxtBx";
            this.LayoutTxtBx.Size = new System.Drawing.Size(335, 38);
            this.LayoutTxtBx.TabIndex = 5;
            // 
            // LocationTxtBx
            // 
            this.LocationTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationTxtBx.Enabled = false;
            this.LocationTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTxtBx.Location = new System.Drawing.Point(709, 224);
            this.LocationTxtBx.Name = "LocationTxtBx";
            this.LocationTxtBx.Size = new System.Drawing.Size(335, 38);
            this.LocationTxtBx.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 31);
            this.label5.TabIndex = 56;
            this.label5.Text = "Layout";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 31);
            this.label6.TabIndex = 55;
            this.label6.Text = "Location";
            // 
            // frmAddEditWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 475);
            this.Controls.Add(this.LayoutTxtBx);
            this.Controls.Add(this.LocationTxtBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddNewHubBtn);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.MemberIdLbl);
            this.Controls.Add(this.WorkSpaceRateTxtBx);
            this.Controls.Add(this.WorkspaceTypeTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditWorkspace";
            this.ShowIcon = false;
            this.Text = "Add Edit Workspace";
            this.Load += new System.EventHandler(this.frmAddEditWorkspace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label MemberIdLbl;
        private System.Windows.Forms.TextBox WorkSpaceRateTxtBx;
        private System.Windows.Forms.TextBox WorkspaceTypeTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddNewHubBtn;
        private System.Windows.Forms.TextBox LayoutTxtBx;
        private System.Windows.Forms.TextBox LocationTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}