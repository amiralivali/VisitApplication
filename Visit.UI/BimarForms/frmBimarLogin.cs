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
    public partial class frmBimarLogin : frmStyleHelper
    {
        HttpClientHelper clientHelper;
        private string randomCode;
        private bool isClose;
        private int timeLeft = 60;
        public frmBimarLogin()
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
                    txtNationalCode.Enabled = true;
                    btnSend.Visible = true;
                    btnEnter.Enabled = false;
                    lbltime.Visible = false;
                    TimeProgressBar.Visible = false;
                    timer1.Enabled = false;
                }
                else
                {
                    txtMobile.Enabled = false;
                    txtNationalCode.Enabled = false;
                    btnSend.Visible = false;
                    btnEnter.Enabled = true;
                    TimeProgressBar.Visible = true;
                    lbltime.Visible = true;
                    timeLeft = 60;
                    timer1.Enabled = true;
                }
            }));
        }

        private void frmBimarLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmBimarLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isClose)
            { 
                var frmStart=new frmStart();
                frmStart.Show();
            }
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            var frmSign = new frmBimarSignIn();
            frmSign.Show();
            isClose = true;
            this.Close();
        }

        private async void btnEnter_Click_1(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                if (txtEnterCode.Text == randomCode)
                {
                    StartProgressBar();
                    string route = string.Format(RouteConstants.GetBimar, txtNationalCode.Text, txtMobile.Text);
                    var bimar = await clientHelper.GetAsync<OprationResult<BimarInfo>>(route);
                    if (bimar.IsSuccess)
                    {
                        this.Invoke(new Action(() =>
                        {
                            frmBimars frmBimars = new frmBimars()
                            {
                                Info = bimar.Data,
                            };
                            frmBimars.Show();
                            isClose = true;
                            this.Close();
                        }));
                    }
                    else
                    {
                        ShowError(bimar.Message);
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

        private async void btnSend_Click_1(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                var validator = new MobileValidationAttribute();
                var mobileValid = validator.GetValidationResult(txtMobile.Text, new ValidationContext(new object()));
                ValidationResult ncValid;
                var valid = new NationalCodeValidationAttribute();
                ncValid = valid.GetValidationResult(txtNationalCode.Text, new ValidationContext(new object()));
                if (mobileValid == ValidationResult.Success && ncValid == ValidationResult.Success)
                {
                    Random rnd = new Random();
                    int randomCode = rnd.Next(100000, 999999);
                    this.randomCode = randomCode.ToString();
                    StartProgressBar();
                    MessageBox.Show(this.randomCode);
                    ShowSuccess("debug mode");
                    FixEnableControls(isTimer: false);
                    timer1.Enabled = true;
                    //var smsHandler = new UserCheckSmsHandler();
                    //var result = await smsHandler.SendSmsIfBimarExistsAsync(randomCode.ToString(), txtNationalCode.Text, txtMobile.Text);
                    //if (result.IsSuccess)
                    //{
                    //    ShowSuccess(result.Message);
                    //    FixEnableControls(isTimer: false);
                    //    timer1.Enabled = true;
                    //}
                    //else
                    //{
                    //    ShowError(result.Message);
                    //}
                }
                else
                {
                    string message = ncValid != null ? ncValid.ErrorMessage + Environment.NewLine : "";
                    message += mobileValid != null ? mobileValid.ErrorMessage : "";
                    ShowError(message);
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
                timer1.Enabled = false;
            }
        }
    }
}
