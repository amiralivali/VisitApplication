using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmDoctors : frmStyle
    {
        public DoctorInfo Info { get; set; }
        public List<TakhasosInfo> Takhasos { get; set; }
        public frmStart FrmStart { get; set; }
        public frmDoctors()
        {
            InitializeComponent();
        }
        
        private void frmDoctors_Load(object sender, EventArgs e)
        {
            Takhasos = new List<TakhasosInfo>()
            {
                 new TakhasosInfo()
                 {
                 ID = 6,
                 Titel="روانشناسی"
                 },
                 new TakhasosInfo()
                 {
                 ID = 3,
                 Titel="قلب و عروق"
                 },
                 new TakhasosInfo()
                 {
                 ID = 2,
                 Titel="مغز و اعصاب"
                 },
            };
            Info = new DoctorInfo()
            {
                DoctorID = 6,
                FirstName = "ابوالفضل",
                LastName = "والی",
                CodeNezamPezeshki = "55555",
                MobileNumber = "09131630330",
                Picture = "https://visitapplication.s3.ir-thr-at1.arvanstorage.ir/visitapplication/MqkYBsRLHYdDy8AJPuiGfhunwbkSW2Oocv2ruugs.jpg"
            };
            FillInformation();
        }
        public void FillInformation()
        {
            lblTakhasos.Text = "";
            lblFullName.Text = Info.FirstName + " " + Info.LastName;
            var titles = Takhasos.Select(t => t.Titel).ToList();
            lblTakhasos.Text += string.Join(" , ", titles);
            pictureBoxProfile.LoadAsync(Info.Picture);
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
            FillInformation();
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
