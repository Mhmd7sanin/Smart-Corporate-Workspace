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

namespace Presentation_layer.Members
{
    public partial class frmMemberInfo : Form
    {
        private int MemberId {  get; set; }

        private ClsMembers Member { get; set; }
        public frmMemberInfo(int ID)
        {
            InitializeComponent();

            this.MemberId = ID;
            Member = ClsMembers.Find(ID);
        }

        private void frmMemberInfo_Load(object sender, EventArgs e)
        {
            MemberIdLbl.Text = Member.MemberID.ToString();
            NameTxtBx.Text = Member.Name;
            CorporateTxtBx.Text = Member.CorporateAffiliation;
        }
    }
}
