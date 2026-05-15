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
    public partial class frmAddEditEquipment : Form
    {
        private int EquipmentId; ClsEquipments Equipment;
        private enum enMode { AddNew = 1, Update = 2 };
        private enMode Mode;


        public frmAddEditEquipment(int id)
        {
            InitializeComponent();
            EquipmentId = id;

            if (EquipmentId == -1) Mode = enMode.AddNew;
            else Mode = enMode.Update;

        }

        private void frmAddEditEquipment_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                Equipment = new ClsEquipments();
                return;
            }


            if (Mode == enMode.Update)
            {
                if (Equipment != null)
                    EquipmentId = Equipment.EquipmentID;
                Equipment = ClsEquipments.Find(EquipmentId); TitleLbl.Text = " Update Equipment";


                if (Equipment == null)
                {
                    MessageBox.Show("This form will be closed because No Equipment with ID = " + EquipmentId);
                    this.Close(); return;
                }

                EquipmentIdLbl.Text = EquipmentId.ToString();
                EquipmentTypeTxtBx.Text = Equipment.EquipmentType;


                this.Text = "Update Equipment";
            }
        }



        private bool _AddNewEquipment()
        {
            Equipment.EquipmentType = EquipmentTypeTxtBx.Text;


            if (Equipment.Save())
            {
                MessageBox.Show("Equipment Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mode = enMode.Update; return true;
            }
            else
                MessageBox.Show("Error :Equipment Is Not Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void _UpdateEquipment()
        {
            Equipment.EquipmentType = EquipmentTypeTxtBx.Text;

            if (Equipment.Save())
                MessageBox.Show("Equipment Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error :Equipment Is Not Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNewEquipment()) frmAddEditEquipment_Load(sender, e);
            }
            else _UpdateEquipment();
        }



        private void ResetBtn_Click(object sender, EventArgs e)
        {
            EquipmentIdLbl.Text = "N/A";
            Equipment.EquipmentType = string.Empty;
        }


        private void EquipmentTypeTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (EquipmentTypeTxtBx.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(EquipmentTypeTxtBx, "Required");
            }
            else errorProvider1.SetError(EquipmentTypeTxtBx, null);
        }


    }
}
