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
using static Visit.Shared.UserRole;

namespace Visit.UI
{
    public partial class frmSign : Form
    {
        public frmSign()
        {
            InitializeComponent();
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
            ofd.Filter = "Picture*.Png|*.Jpg|*.Jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                guna2CirclePictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void frmSign_Load(object sender, EventArgs e)
        {

        }

        private void btnSendSms_Click(object sender, EventArgs e)
        {
            ValidationLogic validationLogic = new ValidationLogic();
            var check = validationLogic.ValidationNumber(txtMobile.Text);
            if (check)
            { 
            
            }
        }

        private void frmSign_Load_1(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
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
            });
        }
    }
}
