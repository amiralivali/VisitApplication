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
            Takhasos = new List<TakhasosInfo>();
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
                 ID = 2,
                 Titel="مغز و اعصاب"
                 },
            };
            Info = new DoctorInfo()
            {
                DoctorID = 1008,
                FirstName = "شهرام",
                LastName = "شپره",
                CodeNezamPezeshki = "85236",
                MobileNumber = "09005868412",
                Picture = "https://visitapplication.s3.ir-thr-at1.arvanstorage.ir/visitapplication/000048168.png",
                StartTime=new TimeSpan(8,0,0),
                EndTime=new TimeSpan(13,0,0),
            };
            FillInformation();
        }
        public void FillInformation()
        {
            lblFullName.Text = Info.FirstName + " " + Info.LastName;
            var titles = Takhasos.Select(t => t.Titel).ToList();
            lblTakhasos.Text = Messages.Takhasos + " : " + string.Join(" , ", titles);
            string timeText = string.Format("ساعت کاری : از {0} تا {1}",Info.StartTime,Info.EndTime);
            lblTime.Text = timeText;
            if (Info.Picture != null)
            {
                pictureBoxProfile.LoadAsync(Info.Picture);
            }
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
