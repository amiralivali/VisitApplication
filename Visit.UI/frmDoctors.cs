using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmDoctors : frmStyleHelper
    {
        public DoctorInfo Info { get; set; }
        public List<TakhasosInfo> Takhasos { get; set; }
        public frmStart FrmStart { get; set; }
        HttpClientHelper httpClient;
        public frmDoctors()
        {
            InitializeComponent();
            Takhasos = new List<TakhasosInfo>();
            httpClient=HttpClientHelper.GetInstance();
        }
        
        private void frmDoctors_Load(object sender, EventArgs e)
        {
            FillInformation();
        }
        public void FillInformation()
        {
            lblFullName.Text = Info.FirstName + " " + Info.LastName;
            var titles = Takhasos.Select(t => t.Titel).ToList();
            lblTakhasos.Text = Messages.Takhasos + " : " + string.Join(" , ", titles);
            string timeText = string.Format(Messages.WorkingTime,Info.StartTime,Info.EndTime);
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
        }

        private void btnHistoryes_Click(object sender, EventArgs e)
        {
            frmDoctorHistory frmDoctorHistory = new frmDoctorHistory()
            {
                ID = Info.DoctorID,
            };
            frmDoctorHistory.Show();
        }

        private async void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف حساب کاربری خود اطمینان دارید؟", "اخطار", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string route = string.Format(RouteConstants.DeleteDoctor, Info.DoctorID);
                var result = await httpClient.GetAsync<OprationResult>(route);
                if (result.IsSuccess)
                {
                    ShowSuccess(result.Message);
                    this.Close();
                }
                else
                {
                    ShowError(result.Message);
                }
            }
        }
    }
}
