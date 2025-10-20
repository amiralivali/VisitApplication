using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Visit.Shared;
using static Visit.Shared.UserRole;

namespace Visit.UI
{
    public partial class frmSign : frmStyle
    {
        HttpClientHelper clientHelper;
        public frmStart frmStart;
        private string RandomCode { get; set; }
        private bool Isclose { get; set; }
        public frmSign()
        {
            InitializeComponent();
            clientHelper = new HttpClientHelper();
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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture|*.png;*.jpg;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBoxProfile.ImageLocation = ofd.FileName;
            }
        }
        private void frmSign_Load_1(object sender, EventArgs e)
        {

        }
        private void frmSign_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Isclose)
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
                if (txtEnterCode.Text == RandomCode)
                {
                    if (UserRole.CurrentRole == Role.Bimar)
                    {
                        BimarInfo bimarInfo = new BimarInfo()
                        {
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            NationalCode = txtNcNezam.Text,
                            MobileNumber = txtMobile.Text,
                        };
                        if (PictureBoxProfile.Image !=Properties.Resources.Profile)
                        {
                            //bimarInfo.Picture=PictureBoxProfile.Image;
                        }
                        var result = await clientHelper.PostAsync<OprationResult,BimarInfo>(RouteConstants.InsertBimar,bimarInfo);
                        if (result.IsSuccess)
                        {
                            this.Invoke(new Action(() =>
                            {
                                ShowSuccess(result.Message);
                                frmBimars frmBimars = new frmBimars()
                                {
                                    Info = bimarInfo,
                                    FrmStart = frmStart,
                                };
                                frmBimars.Show();
                                Isclose = true;
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
                            //Picture
                        };
                        if (PictureBoxProfile.Image != Properties.Resources.Profile)
                        {
                            //doctorInfo.Picture=PictureBoxProfile.Image;
                        }
                        var result = await clientHelper.PostAsync<OprationResult, DoctorInfo>(RouteConstants.InsertDoctor, doctorInfo);
                        if (result.IsSuccess)
                        {
                            this.Invoke(new Action(() =>
                            {
                                frmDoctors frmDoctors = new frmDoctors()
                                {
                                    Info = doctorInfo,
                                    FrmStart = frmStart,
                                };
                                frmDoctors.Show();
                                Isclose = true;
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
                    btnSend.Enabled = true;
                    btnEnter.Enabled = false;
                    lbltime.Visible = false;
                    timer1.Enabled = false;
                }
                else
                {
                    btnSend.Enabled = false;
                    btnEnter.Enabled = true;
                    lbltime.Visible = true;
                    lbltime.Text = "120";
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
            //userInfo.Picture = guna2CirclePictureBox1.Image;
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
                    RandomCode = randomCode.ToString();
                    var smsHandler = new UserCheckSmsHandler();
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = int.Parse(lbltime.Text) - 1;
            lbltime.Text = time.ToString();
            if (time == 0)
            {
                FixEnableControls(isTimer: true);
            }
        }
    }
}
