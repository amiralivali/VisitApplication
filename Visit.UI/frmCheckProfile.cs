using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visit.Shared;
using static Visit.Shared.UserRole;

namespace Visit.UI
{
    public partial class frmCheckProfile : Form
    {
        public UserInfo Info { get; set; }
        public frmCheckProfile(int ncNezam)
        {
            InitializeComponent();
            if (UserRole.CurrentRole == Role.Bimar)
            {
                lblNcNezam.Text = "کد ملی";
            }
            else
            {
                lblNcNezam.Text = "کد نظام پزشکی";
            }
            txtNcNezam.Text=ncNezam.ToString();
        }

        private void frmCheckProfile_Load(object sender, EventArgs e)
        {
            txtFirstName.Text=Info.FirstName;
            txtLastName.Text=Info.LastName;
            txtMobile.Text = Info.MobileNumber;
        }
    }
}
