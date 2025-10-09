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
            frmSign.Show();
        }

        

        private async Task btnEnter_Click(object sender, EventArgs e)
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
                        frmSendSms frmSmsCheck = new frmSendSms()
                        {
                            Mobile = txtMobile.Text,
                            RandomCode = randomCode,
                        };
                        frmSmsCheck.Show();
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
    }
}
