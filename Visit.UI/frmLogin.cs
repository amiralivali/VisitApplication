using System;
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

        }

        private async void btnSendSms_Click(object sender, EventArgs e)
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
            if (check == false)
            {
                Random rnd = new Random();
                int randomCode = rnd.Next(100000, 999999);
                string text = "کد ورود به سامانه ویزیت24" + Environment.NewLine + randomCode;
                route = string.Format(RouteConstants.SendSms, text);
                var checkSms = await clientHelper.PostAsync<OprationResult, string>(route, text);
            }
            else
            {
                MessageBox.Show("!اطلاعات شما در سیستم زخیره نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobile.Text = "";
                txtNcNezam.Text = "";
            }

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
