namespace Presentation_layer.Members
{
    partial class frmMemberInfo
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTxtBx = new System.Windows.Forms.TextBox();
            this.CorporateTxtBx = new System.Windows.Forms.TextBox();
            this.MemberIdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Member Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Member Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Corporate Affiliation";
            // 
            // NameTxtBx
            // 
            this.NameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxtBx.Enabled = false;
            this.NameTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBx.Location = new System.Drawing.Point(283, 107);
            this.NameTxtBx.Name = "NameTxtBx";
            this.NameTxtBx.Size = new System.Drawing.Size(287, 38);
            this.NameTxtBx.TabIndex = 7;
            // 
            // CorporateTxtBx
            // 
            this.CorporateTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorporateTxtBx.Enabled = false;
            this.CorporateTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorporateTxtBx.Location = new System.Drawing.Point(283, 185);
            this.CorporateTxtBx.Name = "CorporateTxtBx";
            this.CorporateTxtBx.Size = new System.Drawing.Size(287, 38);
            this.CorporateTxtBx.TabIndex = 8;
            // 
            // MemberIdLbl
            // 
            this.MemberIdLbl.AutoSize = true;
            this.MemberIdLbl.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIdLbl.Location = new System.Drawing.Point(278, 32);
            this.MemberIdLbl.Name = "MemberIdLbl";
            this.MemberIdLbl.Size = new System.Drawing.Size(52, 30);
            this.MemberIdLbl.TabIndex = 10;
            this.MemberIdLbl.Text = "N/A";
            // 
            // frmMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 277);
            this.Controls.Add(this.MemberIdLbl);
            this.Controls.Add(this.CorporateTxtBx);
            this.Controls.Add(this.NameTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 324);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 324);
            this.Name = "frmMemberInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Member Info";
            this.Load += new System.EventHandler(this.frmMemberInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTxtBx;
        private System.Windows.Forms.TextBox CorporateTxtBx;
        private System.Windows.Forms.Label MemberIdLbl;
    }
}