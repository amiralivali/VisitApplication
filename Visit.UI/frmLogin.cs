using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Design;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Telerik.WinControls;
using Visit.Shared;
using Visit.Shared.Attributes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static Visit.Shared.UserRole;

namespace Visit.UI
{
    public partial class frmLogin : FrmStyleHelpers
    {
        HttpClientHelper clientHelper;
        public frmStart frmStart;
        private string randomCode;
        private bool isClose;
        private int timeLeft = 60;
        public frmLogin()
        {
            InitializeComponent();
            clientHelper = HttpClientHelper.GetInstance();
            if (UserRole.CurrentRole == Role.Bimar)
            {
                lblNcNezam.Text = "کدملی";
            }
            else
            {
                lblNcNezam.Text = "کد نظام پزشکی";
            }
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

        private void frmBimar_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSign frmSign = new frmSign();
            frmSign.frmStart = frmStart;
            frmSign.Show();
            isClose = true;
            this.Close();
        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                if (txtEnterCode.Text == randomCode)
                {
                    StartProgressBar();
                    if (UserRole.CurrentRole == Role.Bimar)
                    {
                        string route = string.Format(RouteConstants.GetBimar, txtNcNezam.Text, txtMobile.Text);
                        var bimar = await clientHelper.GetAsync<OprationResult<BimarInfo>>(route);
                        if (bimar.IsSuccess)
                        {
                            this.Invoke(new Action(() =>
                            {
                                frmBimars frmBimars = new frmBimars()
                                {
                                    Info = bimar.Data,
                                    FrmStart = frmStart,

                                };
                                frmBimars.Show();
                                isClose = true;
                                this.Close();
                            }));
                        }
                    }
                    else
                    {
                        string route = string.Format(RouteConstants.GetDoctor, txtNcNezam.Text, txtMobile.Text);
                        var doctor = await clientHelper.GetAsync<OprationResult<DoctorInfo>>(route);
                        if (doctor.IsSuccess)
                        {
                            route = string.Format(RouteConstants.GetTakhasos, doctor.Data.DoctorID);
                            var takhasos = await clientHelper.GetAsync<OprationResult<List<TakhasosInfo>>>(route);
                            if (takhasos.IsSuccess)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    frmDoctors frmDoctors = new frmDoctors()
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
                }
                else
                {
                    ShowError(Messages.WrongCode);
                }
            });
            ProgressBar.Stop();
            ProgressBar.Visible = false;
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!isClose) 
               frmStart.Show();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                var validator = new MobileValidationAttribute();
                var mobileValid = validator.GetValidationResult(txtMobile.Text, new ValidationContext(new object()));
                ValidationResult ncNezamValid;
                if (UserRole.CurrentRole == Role.Bimar)
                {
                    var valid = new NationalCodeValidationAttribute();
                    ncNezamValid = valid.GetValidationResult(txtNcNezam.Text, new ValidationContext(new object()));
                }
                else
                {
                    var valid = new NezamValidationAttribute();
                    ncNezamValid = valid.GetValidationResult(txtNcNezam.Text, new ValidationContext(new object()));
                }
                if (mobileValid == ValidationResult.Success && ncNezamValid == ValidationResult.Success)
                {
                    Random rnd = new Random();
                    int randomCode = rnd.Next(100000, 999999);
                    this.randomCode = randomCode.ToString();
                    StartProgressBar();
                    var smsHandler = new UserCheckSmsHandler();
                    var result = await smsHandler.SendSmsIfUserExistsAsync(randomCode.ToString(), txtNcNezam.Text, txtMobile.Text);
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
                    string message = ncNezamValid!= null ? ncNezamValid.ErrorMessage+Environment.NewLine : "";
                    message += mobileValid != null ? mobileValid.ErrorMessage : "";
                    ShowError(message);
                }
            });
            ProgressBar.Stop();
            ProgressBar.Visible = false;
        }

        private void FixEnableControls(bool isTimer)
        {
            this.Invoke(new Action(() =>
            {
                if (isTimer)
                {
                    txtMobile.Enabled = true;
                    txtNcNezam.Enabled = true;
                    btnSend.Visible = true;
                    btnEnter.Enabled = false;
                    lbltime.Visible = false;
                    TimeProgressBar.Visible = false;
                    timer1.Enabled = false;
                }
                else
                {
                    txtMobile.Enabled = false;
                    txtNcNezam.Enabled = false;
                    btnSend.Visible = false;
                    btnEnter.Enabled = true;
                    TimeProgressBar.Visible = true;
                    lbltime.Visible = true;
                    timeLeft = 60;
                    timer1.Enabled = true;
                }
            }));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            TimeProgressBar.Value = timeLeft;
            lbltime.Text= timeLeft.ToString();
            if (timeLeft == 0)
            {
                FixEnableControls(isTimer: true);
                timer1.Enabled = false;
            }
        }
    }
}
