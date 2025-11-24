using System;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmCheckProfileDoctor : frmStyleHelper
    {
        public DoctorInfo DoctorInfo { get; set; }
        public frmDoctors FrmDoctors { get; set; }
        HttpClientHelper HttpClient;
        private TimeSpan? startTime;
        private TimeSpan? endTime;
        public frmCheckProfileDoctor()
        {
            InitializeComponent();
            HttpClient = HttpClientHelper.GetInstance();
        }

        private void frmCheckProfile_Load(object sender, EventArgs e)
        {
            txtFirstName.Text=DoctorInfo.FirstName;
            txtLastName.Text=DoctorInfo.LastName;
            txtMobile.Text = DoctorInfo.MobileNumber;
            txtNezam.Text = DoctorInfo.CodeNezamPezeshki;
            if (DoctorInfo.Picture != null)
            {
               pbProfile.LoadAsync(DoctorInfo.Picture);
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            // شرط برای این است که در صورتی که تغییر اعمال شد به دیتابیس درخواست بدم
            if (txtFirstName.Text != DoctorInfo.FirstName || txtLastName.Text != DoctorInfo.LastName ||
                txtMobile.Text != DoctorInfo.MobileNumber || txtNezam.Text != DoctorInfo.CodeNezamPezeshki ||
                pbProfile.ImageLocation != null || pbProfile.ImageLocation != DoctorInfo.Picture ||
                startTime != DoctorInfo.StartTime || endTime != DoctorInfo.EndTime) 
            {
                ProgressBar.Visible = false;
                ProgressBar.Start();
                if (pbProfile.ImageLocation != null && pbProfile.ImageLocation != DoctorInfo.Picture)
                {
                    var result = await SavePicture.Save(pbProfile.ImageLocation);
                    if (result.IsSuccess)
                    {
                        DoctorInfo.Picture = result.Data;
                    }
                    else
                    {
                        ShowError(result.Message);
                        ProgressBar.Stop();
                        ProgressBar.Visible = false;
                        return;
                    }
                }
                DoctorInfo.FirstName = txtFirstName.Text;
                DoctorInfo.LastName = txtLastName.Text;
                DoctorInfo.MobileNumber = txtMobile.Text;
                DoctorInfo.CodeNezamPezeshki = txtNezam.Text;
                DoctorInfo.StartTime=startTime;
                DoctorInfo.EndTime=endTime;
                if (DoctorInfo.IsValid)
                {
                    var result = await HttpClient.PostAsync<OprationResult, DoctorInfo>(RouteConstants.UpdateDoctor, DoctorInfo);
                    ProgressBar.Stop();
                    if (result.IsSuccess)
                    {
                        ShowSuccess(result.Message);
                        FrmDoctors.Info = DoctorInfo;
                        FrmDoctors.FillInformation();
                        this.Close();
                    }
                    else
                    {
                        ProgressBar.Visible = false;
                        ShowError(result.Message);
                    }
                }
                else
                {
                    ProgressBar.Stop();
                    ProgressBar.Visible = false;
                    ShowError(DoctorInfo.Message);
                }

            }
            else
            {
                this.Close();
            }
        }

        private void PictureBoxProfile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Picture|*.png;*.jpg;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbProfile.ImageLocation = ofd.FileName;
                }
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            var frmTakhasos = new frmTakhasos()
            {
                FrmDoctors = FrmDoctors
            };
            frmTakhasos.Show();
            this.Close();
        }

        private void btnChangeTime_Click(object sender, EventArgs e)
        {
            var frmWorkingTime = new frmWorkingTime()
            {
                StartTime = DoctorInfo.StartTime,
                EndTime = DoctorInfo.EndTime,
            };
            frmWorkingTime.ShowDialog();
            startTime = frmWorkingTime.StartTime;
            endTime = frmWorkingTime.EndTime;
        }
    }
}
