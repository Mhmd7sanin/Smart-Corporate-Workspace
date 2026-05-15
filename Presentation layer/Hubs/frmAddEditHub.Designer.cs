namespace Presentation_layer.Hubs
{
    partial class frmAddEditHub
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.HubIdLbl = new System.Windows.Forms.Label();
            this.LayoutTxtBx = new System.Windows.Forms.TextBox();
            this.LocationTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.TitleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 61);
            this.panel1.TabIndex = 47;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(224, 14);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(150, 30);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Add New Hub";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(188, 316);
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
            this.SaveBtn.Location = new System.Drawing.Point(407, 316);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(141, 49);
            this.SaveBtn.TabIndex = 41;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // HubIdLbl
            // 
            this.HubIdLbl.AutoSize = true;
            this.HubIdLbl.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HubIdLbl.Location = new System.Drawing.Point(200, 92);
            this.HubIdLbl.Name = "HubIdLbl";
            this.HubIdLbl.Size = new System.Drawing.Size(52, 30);
            this.HubIdLbl.TabIndex = 45;
            this.HubIdLbl.Text = "N/A";
            // 
            // LayoutTxtBx
            // 
            this.LayoutTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LayoutTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutTxtBx.Location = new System.Drawing.Point(188, 245);
            this.LayoutTxtBx.Name = "LayoutTxtBx";
            this.LayoutTxtBx.Size = new System.Drawing.Size(360, 38);
            this.LayoutTxtBx.TabIndex = 40;
            this.LayoutTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.LayoutTxtBx_Validating);
            // 
            // LocationTxtBx
            // 
            this.LocationTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTxtBx.Location = new System.Drawing.Point(188, 167);
            this.LocationTxtBx.Name = "LocationTxtBx";
            this.LocationTxtBx.Size = new System.Drawing.Size(360, 38);
            this.LocationTxtBx.TabIndex = 39;
            this.LocationTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.LocationTxtBx_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 44;
            this.label2.Text = "Layout";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 43;
            this.label1.Text = "Hubs Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 31);
            this.label4.TabIndex = 42;
            this.label4.Text = "Location";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.HubIdLbl);
            this.Controls.Add(this.LayoutTxtBx);
            this.Controls.Add(this.LocationTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 455);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(620, 455);
            this.Name = "frmAddEditHub";
            this.ShowIcon = false;
            this.Text = "Add Edit Hub";
            this.Load += new System.EventHandler(this.frmAddEditHub_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label HubIdLbl;
        private System.Windows.Forms.TextBox LayoutTxtBx;
        private System.Windows.Forms.TextBox LocationTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}