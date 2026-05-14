namespace Presentation_layer.Equipment
{
    partial class frmEquipmentInfo
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
            this.EquipmentIdLbl = new System.Windows.Forms.Label();
            this.EquipmentTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EquipmentIdLbl
            // 
            this.EquipmentIdLbl.AutoSize = true;
            this.EquipmentIdLbl.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentIdLbl.Location = new System.Drawing.Point(281, 43);
            this.EquipmentIdLbl.Name = "EquipmentIdLbl";
            this.EquipmentIdLbl.Size = new System.Drawing.Size(52, 30);
            this.EquipmentIdLbl.TabIndex = 16;
            this.EquipmentIdLbl.Text = "N/A";
            // 
            // EquipmentTxtBx
            // 
            this.EquipmentTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EquipmentTxtBx.Enabled = false;
            this.EquipmentTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentTxtBx.Location = new System.Drawing.Point(286, 118);
            this.EquipmentTxtBx.Name = "EquipmentTxtBx";
            this.EquipmentTxtBx.Size = new System.Drawing.Size(402, 38);
            this.EquipmentTxtBx.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Equipment Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Equipment Type";
            // 
            // frmEquipmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 209);
            this.Controls.Add(this.EquipmentIdLbl);
            this.Controls.Add(this.EquipmentTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(738, 256);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(738, 256);
            this.Name = "frmEquipmentInfo";
            this.ShowIcon = false;
            this.Text = "Equipment Info";
            this.Load += new System.EventHandler(this.frmEquipmentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EquipmentIdLbl;
        private System.Windows.Forms.TextBox EquipmentTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}