using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Visit.Shared;
using static Visit.Shared.UserRole;

namespace Visit.UI
{
    public partial class frmSign : FrmStyleHelpers
    {
        HttpClientHelper clientHelper;
        public frmStart frmStart;
        string randomCode;
        private bool isClose;
        private int timeLeft = 60;
        public frmSign()
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

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
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
                frmLogin frmLogin = new frmLogin();
                frmLogin.frmStart = frmStart;
                frmLogin.Show();
            }
        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                if (txtEnterCode.Text == randomCode)
                {
                    StartProgressBar();
                    timer1.Enabled = false;
                    if (UserRole.CurrentRole == Role.Bimar)
                    {
                        BimarInfo bimarInfo = new BimarInfo()
                        {
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            NationalCode = txtNcNezam.Text,
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
                        var result = await clientHelper.PostAsync<OprationResult,BimarInfo>(RouteConstants.InsertBimar,bimarInfo);
                        if (result.IsSuccess)
                        {
                            string route = string.Format(RouteConstants.GetBimar, txtNcNezam.Text, txtMobile.Text);
                            bimarInfo = (await clientHelper.GetAsync<OprationResult<BimarInfo>>(route)).Data;
                            this.Invoke(new Action(() =>
                            {
                                ShowSuccess(result.Message);
                                frmBimars frmBimars = new frmBimars()
                                {
                                    Info = bimarInfo,
                                    FrmStart = frmStart,
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
                        DoctorInfo doctorInfo = new DoctorInfo()
                        {
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            CodeNezamPezeshki = txtNcNezam.Text,
                            MobileNumber = txtMobile.Text,
                        };
                        frmWorkingTime frmWorkingTime = new frmWorkingTime();
                        frmWorkingTime.ShowDialog();
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
                            string route = string.Format(RouteConstants.GetDoctor, txtNcNezam.Text, txtMobile.Text);
                            doctorInfo = (await clientHelper.GetAsync<OprationResult<DoctorInfo>>(route)).Data;
                            this.Invoke(new Action(() =>
                            {
                                frmDoctors frmDoctors = new frmDoctors()
                                {
                                    Info = doctorInfo,
                                    FrmStart = frmStart,
                                };
                                frmTakhasos frmTakhasos = new frmTakhasos()
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
                }
                else
                {
                    ShowError(Messages.WrongCode);
                }
            });
            ProgressBar.Stop();
            ProgressBar.Visible = false;
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
                    TimeProgressBar.Visible= true;
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
        private async void btnSend_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                var valid = CheckValidationUser();
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
