using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_layer.Members
{
    public partial class frmAddEditMember : Form
    {

        public int ReturnedMemberID
        {
            get
            {
                return MemberId;
            }
        }


        private int MemberId; ClsMembers Member;
        private enum enMode { AddNew = 1, Update = 2 };
        private enMode Mode;


        public frmAddEditMember(int id)
        {
            InitializeComponent();
            MemberId = id;

            if (MemberId == -1) Mode = enMode.AddNew;
            else Mode = enMode.Update;

        }

        private void frmAddEditMember_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                Member = new ClsMembers();
                return;
            }


            if (Mode == enMode.Update)
            {
                if (Member != null)
                    MemberId = Member.MemberID;
                Member = ClsMembers.Find(MemberId); TitleLbl.Text = " Update Member";


                if (Member == null)
                {
                    MessageBox.Show("This form will be closed because No Member with ID = " + MemberId);
                    this.Close(); return;
                }

                MemberIdLbl.Text = MemberId.ToString();
                NameTxtBx.Text = Member.Name;
                CorporateTxtBx.Text = Member.CorporateAffiliation;


                this.Text = "Update Member";
            }
        }



        private bool _AddNewMember()
        {
            Member.Name = NameTxtBx.Text;
            Member.CorporateAffiliation = CorporateTxtBx.Text;


            if (Member.Save())
            {
                MemberId = Member.MemberID;
                MessageBox.Show("Member Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mode = enMode.Update; return true;
            }
            else
                MessageBox.Show("Error :Member Is Not Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void _UpdateMember()
        {
            Member.Name = NameTxtBx.Text;
            Member.CorporateAffiliation = CorporateTxtBx.Text;

            if (Member.Save())
                MessageBox.Show("Member Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error :Member Is Not Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNewMember()) frmAddEditMember_Load(sender, e);
            }
            else _UpdateMember();
        }



        private void ResetBtn_Click(object sender, EventArgs e)
        {
            MemberIdLbl.Text = "N/A";
            Member.Name = string.Empty;
            Member.CorporateAffiliation = string.Empty;
        }


        private void NameTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (NameTxtBx.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(NameTxtBx, "Required");
            }
            else errorProvider1.SetError(NameTxtBx, null);
        }

        private void CorporateTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (CorporateTxtBx.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(CorporateTxtBx, "Required");
            }
            else errorProvider1.SetError(CorporateTxtBx, null);
        }
    }
}
