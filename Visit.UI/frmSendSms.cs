using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmSendSms : Form
    {
        public string Mobile { get; set; }
        public int RandomCode { get; set; }
        public frmSendSms()
        {
            InitializeComponent();
        }

        private void frmSendSms_Load(object sender, EventArgs e)
        {
            lblMobile.Text = Mobile;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = int.Parse(lbltime.Text) - 1;
            lbltime.Text = time.ToString();
            if (time == 0)
            {
                btnRetry.Visible = true;
                btnEnter.Enabled = false;
                timer1.Enabled = false;
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (lblCode.Text == RandomCode.ToString())
            {
                //
            }
            else
            {
                MessageBox.Show("!کد وارد شده نادرست است","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private async Task btnRetry_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                Random rnd = new Random();
                int randomCode = rnd.Next(100000, 999999);
                var result = await SmsKavenegar.Send(randomCode);
                RandomCode = randomCode;
            }
            );
            lbltime.Text = "120";
            timer1.Enabled = true;
            btnEnter.Enabled = true;
            btnRetry.Visible = false;
        }
    }
}
