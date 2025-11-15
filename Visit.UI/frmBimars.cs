using System;
using System.Collections.Generic;
using System.Web.ModelBinding;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmBimars : frmStyle
    {
        public BimarInfo Info { get; set; }
        public frmStart FrmStart { get; set; }
        HttpClientHelper httpClient;
        public frmBimars()
        {
            InitializeComponent();
            httpClient = HttpClientHelper.GetInstance();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmCheckProfileBimar frmCheckProfile = new frmCheckProfileBimar()
            {
                BimarInfo = Info,
                FrmBimars=this
            };
            frmCheckProfile.Show();
        }

        private async void frmBimars_Load(object sender, EventArgs e)
        {
            Info = new BimarInfo()
            {
                BimarID = 1,
                FirstName = "امیرعلی",
                LastName = "والی",
                NationalCode = "1251039502",
                MobileNumber = "09361842050",
                Picture= "https://visitapplication.s3.ir-thr-at1.arvanstorage.ir/visitapplication/3f886560-8df2-11ee-b418-512ccd6bd884.jpg"
            };
            lblFullName.Text = Info.FirstName + " " + Info.LastName;
            if (Info.Picture != null)
            {
                pictureBoxProfile.LoadAsync(Info.Picture);
            }
            ShowDoctors();
        }
        private async void ShowDoctors(string search="")
        {
            string route = string.Format(RouteConstants.SelectDoctor, search);
            var result = await httpClient.GetAsync<OprationResult<List<DoctorDto>>>(route);
            if (result.IsSuccess)
            {
                foreach (var doctor in result.Data)
                {
                    UC_Doctors uC_Doctors = new UC_Doctors()
                    {
                        Info = doctor,
                    };
                    flpDoctors.Controls.Add(uC_Doctors);
                }
            }
            else
            {
                ShowError(result.Message);
            }
        }
        private void frmBimars_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.frmStart = FrmStart;
            frmLogin.Show();
        }

        private void btnHistoryes_Click(object sender, EventArgs e)
        {
            frmBimarHistory frmHistory = new frmBimarHistory()
            {
                ID = Info.BimarID,
            };
            frmHistory.Show();
        }

        private async void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف حساب کاربری خود اطمینان دارید؟", "اخطار", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string route = string.Format(RouteConstants.DeleteBimar, Info.BimarID);
                var result = await httpClient.GetAsync<OprationResult>(route);
                if (result.IsSuccess)
                {
                    ShowSuccess(result.Message);
                    this.Close();
                }
                else
                {
                    ShowError(result.Message);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDoctors(txtSearch.Text);
        }
    }
}
