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
        public bool isClose = true;
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
            isClose = false;
            this.Close();
        }
        private void NotExist()
        {
            MessageBox.Show("!اطلاعات شما در سیستم زخیره نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtMobile.Text = "";
            txtNcNezam.Text = "";
        }

        private async Task<bool> ExistUser()
        {
            string route;
            if (UserRole.CurrentRole == Role.Bimar)
            {
                route = string.Format(RouteConstants.ExistBimar, txtNcNezam.Text, txtMobile.Text);
            }
            else
            {
                route = string.Format(RouteConstants.ExistDoctor, txtNcNezam.Text, txtMobile.Text);
            }
            bool check = await clientHelper.GetAsync<bool>(route);
            return check;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //if (txtEnterCode.Text == RandomCode)
            //{
            //    if (UserRole.CurrentRole == Role.Bimar)
            //    {
            //        frmBimars frmBimars = new frmBimars()
            //        { 
            //        Info=
            //        }
            //        frmBimars.Show();
            //    }
            //    else
            //    {
            //        frmDoctors frmDoctors = new frmDoctors();
            //        frmDoctors.Show();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("!کد ورود نادرست است","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isClose) 
            frmStart.Show();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            bool check;
            await Task.Run(async () =>
            {
                check = await ExistUser();
                if (check)
                {
                    Random rnd = new Random();
                    int randomCode = rnd.Next(100000, 999999);
                    var result = await SmsKavenegar.Send(randomCode);
                    if (result.IsSuccess)
                    {
                        MessageBox.Show(result.Message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer1.Enabled = true;
                        btnSend.Enabled = false;
                        btnEnter.Enabled = true;
                        txtNcNezam.Enabled = false;
                        txtMobile.Enabled=false;
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        NotExist();
                    }));
                }
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = int.Parse(lbltime.Text) - 1;
            lbltime.Text = time.ToString();
            if (time == 0)
            {
                btnSend.Enabled = true;
                btnEnter.Enabled = false;
                txtNcNezam.Enabled = true;
                txtMobile.Enabled=true;
                timer1.Enabled = false;
            }
        }
    }
}
