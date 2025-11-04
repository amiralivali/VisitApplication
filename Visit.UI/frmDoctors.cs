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
            //Takhasos = new List<TakhasosInfo>()
            //{
            //     new TakhasosInfo()
            //     {
            //     ID = 0,
            //     Titel="مغز و اعصاب"
            //     },
            //};
            //Info = new DoctorInfo()
            //{
            //    DoctorID = 1,
            //    FirstName = "امیرعلی",
            //    LastName = "والی",
            //    CodeNezamPezeshki = "1251039502",
            //    MobileNumber = "09361842050",
            //    Picture = "https://visitapplication.s3.ir-thr-at1.arvanstorage.ir/visitapplication%2FMqkYBsRLHYdDy8AJPuiGfhunwbkSW2Oocv2ruugs.jpg?versionId="
            //};
            FillInformation();
        }
        public void FillInformation()
        {
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
