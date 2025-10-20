using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visit.Shared;
using static Visit.Shared.UserRole;

namespace Visit.UI
{
    public partial class frmLogin : Form
    {
        HttpClientHelper clientHelper;
        public frmStart frmStart;
        public string RandomCode { get; set; }
        private bool isClose { get; set; }
        public frmLogin()
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
                if (txtEnterCode.Text == RandomCode)
                {
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
                            this.Invoke(new Action(() =>
                            {
                                frmDoctors frmDoctors = new frmDoctors()
                                {
                                    Info = doctor.Data,
                                    FrmStart = frmStart,
                                };
                                frmDoctors.Show();
                                isClose = true;
                                this.Close();
                            }));
                        }
                        else
                        {
                            MessageBox.Show(doctor.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
        }
                }
                else
                {
                    MessageBox.Show("!کد ورود نادرست است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
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
            });
        }

        private void FixEnableControls(bool isTimer)
        {
            this.Invoke(new Action(() =>
            {
                if (isTimer)
                {
                    txtMobile.Enabled = true;
                    txtNcNezam.Enabled = true;
                    btnSend.Enabled = true;
                    btnEnter.Enabled = false;
                    lbltime.Visible = false;
                }
                else
                {
                    txtMobile.Enabled = false;
                    txtNcNezam.Enabled = false;
                    btnSend.Enabled = false;
                    btnEnter.Enabled = true;
                    lbltime.Visible = true;
                    lbltime.Text = "120";
                }
            }));
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
