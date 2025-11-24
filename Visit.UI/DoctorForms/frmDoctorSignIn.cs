using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmDoctorSignIn : frmStyleHelper
    {
        HttpClientHelper clientHelper;
        public frmStart frmStart;
        string randomCode;
        private bool isClose;
        private int timeLeft = 60;
        public frmDoctorSignIn()
        {
            InitializeComponent();
            clientHelper = HttpClientHelper.GetInstance();
        }

        private void StartProgressBar()
        {
            this.Invoke(new Action(() =>
            {
                ProgressBar.Visible = true;
                ProgressBar.Start();
            }));
        }

        private void FixEnableControls(bool isTimer)
        {
            this.Invoke(new Action(() =>
            {
                foreach (object item in panelTexBoxes.Controls)
                {
                    var p = item as Guna2TextBox;
                    p.Enabled = isTimer;
                }
                if (isTimer)
                {
                    btnSend.Visible = true;
                    TimeProgressBar.Visible = false;
                    btnEnter.Enabled = false;
                    lbltime.Visible = false;
                    timer1.Enabled = false;
                }
                else
                {
                    btnSend.Visible = false;
                    btnEnter.Enabled = true;
                    TimeProgressBar.Visible = true;
                    lbltime.Visible = true;
                    timeLeft = 60;
                    timer1.Enabled = true;
                }
            }));
        }
        private OprationResult CheckValidationDoctor()
        {
            var doctorInfo = new DoctorInfo()
            {
                CodeNezamPezeshki = txtNezam.Text
            };
            if (txtMobile.Text.StartsWith("9"))
            {
                doctorInfo.MobileNumber = 0 + txtMobile.Text;
            }
            else
            {
                doctorInfo.MobileNumber = txtMobile.Text;
            }
            doctorInfo.FirstName = txtFirstName.Text;
            doctorInfo.LastName = txtLastName.Text;
            if (doctorInfo.IsValid)
            {
                return OprationResult.Success();
            }
            else
            {
                return OprationResult.UnSuccess(doctorInfo.Message);
            };
        }

        private void frmDoctorSignIn_Load(object sender, EventArgs e)
        {
            TimeProgressBar.Maximum = timeLeft;
        }

        private async void btnEnter_Click_1(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                if (txtEnterCode.Text == randomCode)
                {
                    StartProgressBar();
                    timer1.Enabled = false;
                    var doctorInfo = new DoctorInfo()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        CodeNezamPezeshki = txtNezam.Text,
                        MobileNumber = txtMobile.Text,
                    };
                    var frmWorkingTime = new frmWorkingTime();
                    frmWorkingTime.ShowDialog();
                    if (frmWorkingTime.StartTime == null || frmWorkingTime.EndTime == null)
                    {
                        ShowError("ساعت کاری رو بایستی حتما وارد کنید");
                        return;
                    }
                    doctorInfo.StartTime = frmWorkingTime.StartTime;
                    doctorInfo.EndTime = frmWorkingTime.EndTime;
                    if (PictureBoxProfile.ImageLocation != null)
                    {
                        var check = await SavePicture.Save(PictureBoxProfile.ImageLocation);
                        if (check.IsSuccess)
                        {
                            doctorInfo.Picture = check.Data;
                        }
                        else
                        {
                            ShowError(check.Message);
                            return;
                        }
                    }
                    var result = await clientHelper.PostAsync<OprationResult, DoctorInfo>(RouteConstants.InsertDoctor, doctorInfo);
                    if (result.IsSuccess)
                    {
                        string route = string.Format(RouteConstants.GetDoctor, txtNezam.Text, txtMobile.Text);
                        doctorInfo = (await clientHelper.GetAsync<OprationResult<DoctorInfo>>(route)).Data;
                        this.Invoke(new Action(() =>
                        {
                            var frmDoctors = new frmDoctors()
                            {
                                Info = doctorInfo,
                                FrmStart = frmStart,
                            };
                            var frmTakhasos = new frmTakhasos()
                            {
                                FrmDoctors = frmDoctors
                            };
                            frmTakhasos.Show();
                            isClose = true;
                            this.Close();
                        }));
                    }
                    else
                    {
                        ShowError(result.Message);
                    }
                }
                else
                {
                    ShowError(Messages.WrongCode);
                }
            });
            ProgressBar.Stop();
            ProgressBar.Visible = false;
        }

        private void PictureBoxProfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Picture|*.png;*.jpg;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PictureBoxProfile.ImageLocation = ofd.FileName;
                }
            }
        }

        private async void btnSend_Click_1(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                var valid = CheckValidationDoctor();
                if (valid.IsSuccess)
                {
                    Random rnd = new Random();
                    int randomCode = rnd.Next(100000, 999999);
                    this.randomCode = randomCode.ToString();
                    var smsHandler = new UserCheckSmsHandler();
                    StartProgressBar();
                    var result = await smsHandler.SendSmsAsync(randomCode.ToString());
                    if (result.IsSuccess)
                    {
                        ShowSuccess(result.Message);
                        FixEnableControls(isTimer: false);
                    }
                    else
                    {
                        ShowError(result.Message);
                    }
                }
                else
                {
                    ShowError(valid.Message);
                }
            });
            ProgressBar.Stop();
            ProgressBar.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timeLeft--;
            TimeProgressBar.Value = timeLeft;
            lbltime.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                FixEnableControls(isTimer: true);
            }
        }

        private void frmDoctorSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isClose)
            {
                var frmLogin = new frmDoctorLogin();
                frmLogin.frmStart = frmStart;
                frmLogin.Show();
            }
        }
    }
}
