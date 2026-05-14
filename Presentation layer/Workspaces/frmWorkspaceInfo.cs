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

namespace Presentation_layer.Workspaces
{
    public partial class frmWorkspaceInfo : Form
    {
        private ClsWorkspaces Workspace {  get; set; }

        private ClsHubs Hub {  get; set; }

        public frmWorkspaceInfo(int id)
        {
            InitializeComponent();
            Workspace = ClsWorkspaces.Find(id);
            Hub = ClsHubs.Find(Workspace.HubID);
        }

        private void frmWorkspaceInfo_Load(object sender, EventArgs e)
        {
            WorkspaceIdLbl.Text= Workspace.WorkspaceID.ToString();
            WorkspaceTypeTxtBx.Text = Workspace.WorkspaceType;
            WorkspaceRateTxtBx.Text = Workspace.WorkspaceRate.ToString();
            LocationTxtBx.Text = Hub.Location;
            LayoutTxtBx.Text = Hub.Layout;  
        }
    }
}
