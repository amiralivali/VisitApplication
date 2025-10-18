using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visit.Shared;
using static Visit.Shared.UserRole;

namespace Visit.UI
{
    public partial class frmSign : Form
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
                guna2CirclePictureBox1.ImageLocation = ofd.FileName;
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
                            //Picture
                        };
                        var result = await clientHelper.PostAsync<OprationResult,BimarInfo>(RouteConstants.InsertBimar,bimarInfo);
                        if (result.IsSuccess)
                        {
                            frmBimars frmBimars = new frmBimars()
                            {
                                Info = bimarInfo
                            };
                            frmBimars.Show();
                        }
                        else 
                        {
                            MessageBox.Show(result.Message,"خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                        var result = await clientHelper.PostAsync<OprationResult, DoctorInfo>(RouteConstants.InsertDoctor, doctorInfo);
                        if (result.IsSuccess)
                        {
                            frmDoctors frmDoctors = new frmDoctors()
                            {
                                Info = doctorInfo
                            };
                            frmDoctors.Show();
                        }
                        else
                        {
                            MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("!کد ورود نادرست است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Isclose = true;
                this.Close();
            });
        }
        private void FixEnableControls(bool isTimer)
        {
            foreach (object item in this.Controls)
            {
                TextBox p = item as TextBox;
                p.Enabled = isTimer;
            }
            if (isTimer)
            {
                btnSend.Enabled = true;
                btnEnter.Enabled = false;
                lbltime.Visible = false;
            }
            else
            {
                btnSend.Enabled = false;
                btnEnter.Enabled = true;
                lbltime.Visible = true;
                lbltime.Text = "120";
            }
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
                var res = CheckValidationUser();
                if (res.IsSuccess)
                {
                    Random rnd = new Random();
                    int randomCode = rnd.Next(100000, 999999);
                    RandomCode = randomCode.ToString();
                    var smsHandler = new UserCheckSmsHandler();
                    var result = await smsHandler.SendSmsIfUserExistsAsync(randomCode.ToString(), txtNcNezam.Text, txtMobile.Text);
                    if (result.IsSuccess)
                    {
                        MessageBox.Show(result.Message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FixEnableControls(isTimer: false);
                        timer1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(res.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                timer1.Enabled = false;
            }
        }
    }
}
