using System;
using System.Windows.Forms;
using Visit.Shared;
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
            frmBimarLogin frmLogin = new frmBimarLogin();
            frmLogin.frmStart = this;
            this.Hide();
            frmLogin.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            frmDoctorLogin frmLogin = new frmDoctorLogin();
            frmLogin.frmStart = this;
            this.Hide();
            frmLogin.Show();
        }

        private void frmStart_Load_1(object sender, EventArgs e)
        {

        }
    }
}
