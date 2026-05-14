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

namespace Presentation_layer.Hubs
{
    public partial class frmHubInfo : Form
    {
        private ClsHubs Hub { get; set; }


        public frmHubInfo(int Id)
        {
            InitializeComponent();

            Hub = ClsHubs.Find(Id);
        }

        private void frmHubInfo_Load(object sender, EventArgs e)
        {
            HubIdLbl.Text = Hub.HubID.ToString();
            LocationTxtBx.Text = Hub.Location;
            LayoutTxtBx.Text = Hub.Layout;
        }
    }
}
