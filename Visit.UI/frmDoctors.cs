using System;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmDoctors : frmStyle
    {
        public DoctorInfo Info { get; set; }
        public TakhasosInfo Takhasos { get; set; }
        public frmStart FrmStart { get; set; }
        public frmDoctors()
        {
            InitializeComponent();
        }

        private void frmDoctors_Load(object sender, EventArgs e)
        {

        }

        private void frmDoctors_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.frmStart = FrmStart;
            frmLogin.Show();
        }

        private void btnCheckProfile_Click(object sender, EventArgs e)
        {
            frmCheckProfileDoctor frmCheckProfile = new frmCheckProfileDoctor()
            {
                DoctorInfo = Info,
                FrmDoctors = this
            };
            frmCheckProfile.Show();
        }

        private void btnHistoryes_Click(object sender, EventArgs e)
        {
            frmDoctorHistory frmDoctorHistory = new frmDoctorHistory()
            {
                ID = Info.DoctorID,
            };
            frmDoctorHistory.Show();
        }
    }
}
