using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmDoctors : frmStyleHelper
    {
        public DoctorInfo Info { get; set; }
        public List<TakhasosInfo> Takhasos { get; set; }
        HttpClientHelper httpClient;
        HubConnection connection;
        public frmDoctors()
        {
            InitializeComponent();
            Takhasos = new List<TakhasosInfo>();
            httpClient=HttpClientHelper.GetInstance();
        }
        
        private void frmDoctors_Load(object sender, EventArgs e)
        {
            StartSignalR();
            ChangeDoctorStatus(isOnline:true);
            FillInformation();
        }

        private void ChangeDoctorStatus(bool isOnline)
        {
            string route = "";
           
        }
        private async void StartSignalR()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost/VisitApi/PresenceHub") 
                .WithAutomaticReconnect() 
                .Build();

            try
            {
                await connection.StartAsync();
                await connection.InvokeAsync("DoctorOnline", Info.DoctorID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در اتصال به SignalR: " + ex.Message);
            }
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
        private async void frmDoctors_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangeDoctorStatus(isOnline: false);
            if (connection != null)
            {
                try
                {
                    await connection.InvokeAsync("DoctorOffline", Info.DoctorID);
                    await connection.StopAsync();
                }
                catch { /* اگر خطایی بود نادیده می‌گیریم */ }
            }
            var frmLogin = new frmDoctorLogin();
            frmLogin.Show();
        }

        private void btnCheckProfile_Click(object sender, EventArgs e)
        {
            var frmCheckProfile = new frmCheckProfileDoctor()
            {
                DoctorInfo = Info,
                FrmDoctors = this
            };
            frmCheckProfile.Show();
        }

        private void btnHistoryes_Click(object sender, EventArgs e)
        {
            var frmDoctorHistory = new frmDoctorHistory()
            {
                ID = Info.DoctorID,
            };
            frmDoctorHistory.Show();
        }

        private async void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("آیا از حذف حساب کاربری خود اطمینان دارید؟", "اخطار", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
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
