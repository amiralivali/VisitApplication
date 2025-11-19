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
using static Visit.Shared.UserRole;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmBimarSignIn : FrmStyleHelpers
    {
        HttpClientHelper clientHelper;
        public frmStart frmStart;
        string randomCode;
        private bool isClose;
        private int timeLeft = 60;
        public frmBimarSignIn()
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
        }
        private void StartProgressBar()
        {
            this.Invoke(new Action(() =>
            {
                ProgressBar.Visible = true;
                ProgressBar.Start();
            }));
        }
        private void frmSign_Load_1(object sender, EventArgs e)
        {
            TimeProgressBar.Maximum = timeLeft;
        }
        private void frmSign_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isClose)
            {
                frmBimarLogin frmLogin = new frmBimarLogin();
                frmLogin.frmStart = frmStart;
                frmLogin.Show();
            }
        }
        private void FixEnableControls(bool isTimer)
        {
            this.Invoke(new Action(() =>
            {
                foreach (object item in panelTexBoxes.Controls)
                {
                    Guna2TextBox p = item as Guna2TextBox;
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
        private OprationResult CheckValidationUser()
        {
            UserInfo userInfo;
            if (UserRole.CurrentRole == Role.Bimar)
            {
                userInfo = new BimarInfo()
                {
                    NationalCode = txtNcNezam.Text
                };
            }
            else
            {
                userInfo = new DoctorInfo()
                {
                    CodeNezamPezeshki = txtNcNezam.Text
                };
            }
            if (txtMobile.Text.StartsWith("9"))
            {
                userInfo.MobileNumber = 0 + txtMobile.Text;
            }
            else
            {
                userInfo.MobileNumber = txtMobile.Text;
            }
            userInfo.FirstName = txtFirstName.Text;
            userInfo.LastName = txtLastName.Text;
            if (userInfo.IsValid)
            {
                return OprationResult.Success();
            }
            else
            {
                return OprationResult.UnSuccess(userInfo.Message);

            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            TimeProgressBar.Value = timeLeft;
            lbltime.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                FixEnableControls(isTimer: true);
            }
        }
    }
}
