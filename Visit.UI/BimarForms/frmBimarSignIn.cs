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
    public partial class frmBimarSignIn : frmStyleHelper
    {
        HttpClientHelper clientHelper;
        string randomCode;
        private bool isClose;
        private int timeLeft = 60;
        public frmBimarSignIn()
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
        private void frmSign_Load_1(object sender, EventArgs e)
        {
            TimeProgressBar.Maximum = timeLeft;
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
        private OprationResult CheckValidationUser()
        {
            var bimarInfo = new BimarInfo()
            {
                NationalCode = txtNationalCode.Text
            };
            if (txtMobile.Text.StartsWith("9"))
            {
                bimarInfo.MobileNumber = 0 + txtMobile.Text;
            }
            else
            {
                bimarInfo.MobileNumber = txtMobile.Text;
            }
            bimarInfo.FirstName = txtFirstName.Text;
            bimarInfo.LastName = txtLastName.Text;
            if (bimarInfo.IsValid)
            {
                return OprationResult.Success();
            }
            else
            {
                return OprationResult.UnSuccess(bimarInfo.Message);

            };
        }

        private async void btnEnter_Click_1(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                if (txtEnterCode.Text == randomCode)
                {
                    StartProgressBar();
                    timer1.Enabled = false;
                    var bimarInfo = new BimarInfo()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        NationalCode = txtNationalCode.Text,
                        MobileNumber = txtMobile.Text,
                    };
                    if (PictureBoxProfile.ImageLocation != null)
                    {
                        var check = await SavePicture.Save(PictureBoxProfile.ImageLocation);
                        if (check.IsSuccess)
                        {
                            bimarInfo.Picture = check.Data;
                        }
                        else
                        {
                            ShowError(check.Message);
                            return;
                        }
                    }
                    var result = await clientHelper.PostAsync<OprationResult, BimarInfo>(RouteConstants.InsertBimar, bimarInfo);
                    if (result.IsSuccess)
                    {
                        string route = string.Format(RouteConstants.GetBimar, txtNationalCode.Text, txtMobile.Text);
                        bimarInfo = (await clientHelper.GetAsync<OprationResult<BimarInfo>>(route)).Data;
                        this.Invoke(new Action(() =>
                        {
                            ShowSuccess(result.Message);
                            frmBimars frmBimars = new frmBimars()
                            {
                                Info = bimarInfo,
                            };
                            frmBimars.Show();
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
                var valid = CheckValidationUser();
                if (valid.IsSuccess)
                {
                    Random rnd = new Random();
                    int randomCode = rnd.Next(100000, 999999);
                    this.randomCode = randomCode.ToString();
                    MessageBox.Show(this.randomCode);
                    ShowSuccess("debug mode");
                    FixEnableControls(isTimer: false);
                    timer1.Enabled = true;
                    //var smsHandler = new UserCheckSmsHandler();
                    //StartProgressBar();
                    //var result = await smsHandler.SendSmsAsync(randomCode.ToString());
                    //if (result.IsSuccess)
                    //{
                    //    ShowSuccess(result.Message);
                    //    FixEnableControls(isTimer: false);
                    //}
                    //else
                    //{
                    //    ShowError(result.Message);
                    //}
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

        private void frmBimarSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isClose)
            {
                var frmLogin = new frmBimarLogin();
                frmLogin.Show();
            }
        }

        private void frmBimarSignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
