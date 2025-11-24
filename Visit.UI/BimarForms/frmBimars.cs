using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.ModelBinding;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmBimars : frmStyleHelper
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
            var frmCheckProfile = new frmCheckProfileBimar()
            {
                BimarInfo = Info,
                FrmBimars=this
            };
            frmCheckProfile.Show();
        }
        private void frmBimars_Load(object sender, EventArgs e)
        {
            ShowInformation();
            ShowDoctors();
        }
        private async void ShowDoctors(string search="",bool isFilter=false)
        {
            flpDoctors.Controls.Clear();
            string route = string.Format(RouteConstants.SelectDoctor, search);
            var result = await httpClient.GetAsync<OprationResult<List<DoctorDto>>>(route);
            if (result.IsSuccess)
            {
                var realTime = await TehranTimeProvider.GetTimeSpanAsync();
                if (isFilter)
                {
                    if (cbFilter.SelectedIndex == 0) //Online Doctors 
                    {
                        result.Data = result.Data.Where(x => x.StartTime < x.EndTime
                        ? realTime >= x.StartTime && realTime < x.EndTime
                        : realTime >= x.StartTime || realTime < x.EndTime).ToList();
                    }
                    else //Ofline Doctors
                    {
                        result.Data = result.Data.Where(x => x.StartTime < x.EndTime ?
                        !(realTime >= x.StartTime && realTime < x.EndTime)
                        : realTime < x.StartTime && realTime > x.EndTime).ToList();
                    }
                }
                foreach (var doctor in result.Data)
                {
                    bool isPresent = true;
                    if (doctor.StartTime < doctor.EndTime)
                    {
                        if (!(realTime >= doctor.StartTime && realTime < doctor.EndTime))
                        {
                            isPresent = false;
                        }
                    }
                    else
                    {
                        if (realTime < doctor.StartTime && realTime > doctor.EndTime)
                        {
                            isPresent = true;
                        }
                    }
                    UC_Doctors uC_Doctors = new UC_Doctors()
                    {
                        Info = doctor,
                        IsPresentTime = isPresent,
                    };
                    flpDoctors.Controls.Add(uC_Doctors);
                }
            }
            else
            {
                ShowError(result.Message);
            }
        }
        public void ShowInformation()
        {
            lblFullName.Text = $"{Info.FirstName} {Info.LastName}";
            if (Info.Picture != null)
            {
                pictureBoxProfile.LoadAsync(Info.Picture);
            }
        }
        private void frmBimars_FormClosing(object sender, FormClosingEventArgs e)
        {
            var frmLogin = new frmBimarLogin();
            frmLogin.frmStart = FrmStart;
            frmLogin.Show();
        }

        private void btnHistoryes_Click(object sender, EventArgs e)
        {
            var frmHistory = new frmBimarHistory()
            {
                ID = Info.BimarID,
            };
            frmHistory.Show();
        }

        private async void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("آیا از حذف حساب کاربری خود اطمینان دارید؟", "اخطار", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
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
            bool isFilter = cbFilter.SelectedIndex != -1;
            ShowDoctors(txtSearch.Text,isFilter);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            cbFilter.SelectedItem = null;
            btnDeleteFilter.Enabled = false;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem != null)
            {
                btnDeleteFilter.Enabled = true;
                ShowDoctors(txtSearch.Text, true);
            }
            else
            {
                ShowDoctors(txtSearch.Text, false);
            }
        }
    }
}
