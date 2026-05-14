namespace Presentation_layer.Hubs
{
    partial class frmHubInfo
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
            this.HubIdLbl = new System.Windows.Forms.Label();
            this.LayoutTxtBx = new System.Windows.Forms.TextBox();
            this.LocationTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HubIdLbl
            // 
            this.HubIdLbl.AutoSize = true;
            this.HubIdLbl.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HubIdLbl.Location = new System.Drawing.Point(178, 29);
            this.HubIdLbl.Name = "HubIdLbl";
            this.HubIdLbl.Size = new System.Drawing.Size(52, 30);
            this.HubIdLbl.TabIndex = 16;
            this.HubIdLbl.Text = "N/A";
            // 
            // LayoutTxtBx
            // 
            this.LayoutTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LayoutTxtBx.Enabled = false;
            this.LayoutTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutTxtBx.Location = new System.Drawing.Point(178, 183);
            this.LayoutTxtBx.Name = "LayoutTxtBx";
            this.LayoutTxtBx.Size = new System.Drawing.Size(393, 38);
            this.LayoutTxtBx.TabIndex = 15;
            // 
            // LocationTxtBx
            // 
            this.LocationTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationTxtBx.Enabled = false;
            this.LocationTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTxtBx.Location = new System.Drawing.Point(178, 105);
            this.LocationTxtBx.Name = "LocationTxtBx";
            this.LocationTxtBx.Size = new System.Drawing.Size(393, 38);
            this.LocationTxtBx.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Layout";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hub Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Location";
            // 
            // frmHubInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 266);
            this.Controls.Add(this.HubIdLbl);
            this.Controls.Add(this.LayoutTxtBx);
            this.Controls.Add(this.LocationTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(652, 313);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 313);
            this.Name = "frmHubInfo";
            this.ShowIcon = false;
            this.Text = "Hub Info";
            this.Load += new System.EventHandler(this.frmHubInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HubIdLbl;
        private System.Windows.Forms.TextBox LayoutTxtBx;
        private System.Windows.Forms.TextBox LocationTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}