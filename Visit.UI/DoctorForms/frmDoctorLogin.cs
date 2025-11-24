using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visit.Shared.Attributes;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmDoctorLogin : frmStyleHelper
    {
        HttpClientHelper clientHelper;
        public frmStart frmStart;
        private string randomCode;
        private bool isClose;
        private int timeLeft = 60;
        public frmDoctorLogin()
        {
            InitializeComponent();
            clientHelper = HttpClientHelper.GetInstance();
            TimeProgressBar.Maximum = timeLeft;
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
                if (isTimer)
                {
                    txtMobile.Enabled = true;
                    txtNezam.Enabled = true;
                    btnSend.Visible = true;
                    btnEnter.Enabled = false;
                    lbltime.Visible = false;
                    TimeProgressBar.Visible = false;
                    timer1.Enabled = false;
                }
                else
                {
                    txtMobile.Enabled = false;
                    txtNezam.Enabled = false;
                    btnSend.Visible = false;
                    btnEnter.Enabled = true;
                    TimeProgressBar.Visible = true;
                    lbltime.Visible = true;
                    timeLeft = 60;
                    timer1.Enabled = true;
                }
            }));
        }

        private void frmDoctorLogin_Load(object sender, EventArgs e)
        {

        }

        private async void btnEnter_Click_1(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                if (txtEnterCode.Text == randomCode)
                {
                    StartProgressBar();
                    string route = string.Format(RouteConstants.GetDoctor, txtNezam.Text, txtMobile.Text);
                    var doctor = await clientHelper.GetAsync<OprationResult<DoctorInfo>>(route);
                    if (doctor.IsSuccess)
                    {
                        route = string.Format(RouteConstants.GetTakhasos, doctor.Data.DoctorID);
                        var takhasos = await clientHelper.GetAsync<OprationResult<List<TakhasosInfo>>>(route);
                        if (takhasos.IsSuccess)
                        {
                            this.Invoke(new Action(() =>
                            {
                                var frmDoctors = new frmDoctors()
                                {
                                    Info = doctor.Data,
                                    FrmStart = frmStart,
                                    Takhasos = takhasos.Data,
                                };
                                frmDoctors.Show();
                                isClose = true;
                                this.Close();
                            }));
                        }
                        else
                        {
                            ShowError(takhasos.Message);
                        }
                    }
                    else
                    {
                        ShowError(doctor.Message);
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

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            var frmSign = new frmDoctorSignIn();
            frmSign.frmStart = frmStart;
            frmSign.Show();
            isClose = true;
            this.Close();
        }

        private async void btnSend_Click_1(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                var validator = new MobileValidationAttribute();
                var mobileValid = validator.GetValidationResult(txtMobile.Text, new ValidationContext(new object()));
                ValidationResult NezamValid;
                var valid = new NezamValidationAttribute();
                NezamValid = valid.GetValidationResult(txtNezam.Text, new ValidationContext(new object()));
                if (mobileValid == ValidationResult.Success && NezamValid == ValidationResult.Success)
                {
                    Random rnd = new Random();
                    int randomCode = rnd.Next(100000, 999999);
                    this.randomCode = randomCode.ToString();
                    StartProgressBar();
                    var smsHandler = new UserCheckSmsHandler();
                    var result = await smsHandler.SendSmsIfDoctorExistsAsync(randomCode.ToString(), txtNezam.Text, txtMobile.Text);
                    if (result.IsSuccess)
                    {
                        ShowSuccess(result.Message);
                        FixEnableControls(isTimer: false);
                        timer1.Enabled = true;
                    }
                    else
                    {
                        ShowError(result.Message);
                    }
                }
                else
                {
                    string message = NezamValid != null ? NezamValid.ErrorMessage + Environment.NewLine : "";
                    message += mobileValid != null ? mobileValid.ErrorMessage : "";
                    ShowError(message);
                }
            });
            ProgressBar.Stop();
            ProgressBar.Visible = false;
        }

        private void frmDoctorLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isClose)
                frmStart.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timeLeft--;
            TimeProgressBar.Value = timeLeft;
            lbltime.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                FixEnableControls(isTimer: true);
                timer1.Enabled = false;
            }
        }
    }
}
