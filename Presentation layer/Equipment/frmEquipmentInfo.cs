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
    public partial class frmEquipmentInfo : Form
    {
        private ClsEquipments Equipment { get; set; }


        public frmEquipmentInfo(int id)
        {
            InitializeComponent();

            Equipment = ClsEquipments.Find(id);
        }

        private void frmEquipmentInfo_Load(object sender, EventArgs e)
        {
            EquipmentIdLbl.Text = Equipment.EquipmentID.ToString();
            EquipmentTxtBx.Text = Equipment.EquipmentType;
        }
    }
}
