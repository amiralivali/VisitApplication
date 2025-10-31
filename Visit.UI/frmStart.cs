using System;
using System.Windows.Forms;
using Visit.Shared;
using static Visit.Shared.UserRole;

namespace Visit.UI
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }
        private void btnBimar_Click(object sender, EventArgs e)
        {
            UserRole.CurrentRole = Role.Bimar;
            frmLogin frmLogin = new frmLogin();
            frmLogin.frmStart = this;
            this.Hide();
            frmLogin.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            UserRole.CurrentRole = Role.Doctor;
            frmLogin frmLogin = new frmLogin();
            frmLogin.frmStart = this;
            this.Hide();
            frmLogin.Show();
        }

        private void frmStart_Load_1(object sender, EventArgs e)
        {

        }
    }
}
