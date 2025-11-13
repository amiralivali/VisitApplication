using System;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmBimars : frmStyle
    {
        public BimarInfo Info { get; set; }
        public frmStart FrmStart { get; set; }
        public frmBimars()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmCheckProfileBimar frmCheckProfile = new frmCheckProfileBimar()
            {
                BimarInfo = Info,
                FrmBimars=this
            };
            frmCheckProfile.Show();
        }

        private void frmBimars_Load(object sender, EventArgs e)
        {
            Info = new BimarInfo()
            {
                BimarID = 1,
                FirstName = "امیرعلی",
                LastName = "والی",
                NationalCode = "1251039502",
                MobileNumber = "09361842050",
                Picture= "https://visitapplication.s3.ir-thr-at1.arvanstorage.ir/visitapplication/3f886560-8df2-11ee-b418-512ccd6bd884.jpg"
            };
            lblFullName.Text = Info.FirstName + " " + Info.LastName;
            pictureBoxProfile.LoadAsync(Info.Picture);
        }

        private void frmBimars_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.frmStart = FrmStart;
            frmLogin.Show();
        }

        private void btnHistoryes_Click(object sender, EventArgs e)
        {
            frmBimarHistory frmHistory = new frmBimarHistory()
            {
                ID = Info.BimarID,
            };
            frmHistory.Show();
        }
    }
}
