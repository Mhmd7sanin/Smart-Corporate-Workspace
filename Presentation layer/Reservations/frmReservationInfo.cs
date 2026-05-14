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

namespace Presentation_layer.Reservations
{
    public partial class frmReservationInfo : Form
    {
        private ClsReservations reservation;
        private ClsMembers member;
        private ClsHubs hub;
        private ClsWorkspaces workspace;
        private ClsEquipments equipment;
        public frmReservationInfo(int id)
        {
            InitializeComponent();

            reservation = ClsReservations.Find(id);
            member = ClsMembers.Find(reservation.MemberID);
            workspace = ClsWorkspaces.Find(reservation.WorkspaceID);
            hub = ClsHubs.Find(workspace.HubID);
            equipment = ClsEquipments.Find(reservation.EquipmentID);
        }

        private void frmReservationInfo_Load(object sender, EventArgs e)
        {
            ReservationIdLbl.Text = reservation.ReservationID.ToString();
            NameTxtBx.Text = member.Name;
            CorporateTxtBx.Text = member.CorporateAffiliation;
            EquipmentTypeTxtBx.Text = equipment.EquipmentType;
            ReservationRateTxtBx.Text = reservation.Rate.ToString();
            WorkspaceTypeTxtBx.Text = workspace.WorkspaceType;
            LocationTxtBx.Text = hub.Location;
            LayoutTxtBx.Text = hub.Layout;
            ReservationDateTimePicker.Value = reservation.ReservationDate;
        }
    }
}
