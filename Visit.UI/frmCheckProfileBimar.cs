using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmCheckProfileBimar : frmStyle
    {
        public frmBimars FrmBimars { get; set; }
        public BimarInfo BimarInfo { get; set; }
        HttpClientHelper httpClient;
        public frmCheckProfileBimar()
        {
            InitializeComponent();
            httpClient = HttpClientHelper.GetInstance();
        }

        private void frmCheckProfileBimar_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = BimarInfo.FirstName;
            txtLastName.Text = BimarInfo.LastName;
            txtMobile.Text = BimarInfo.MobileNumber;
            txtNc.Text = BimarInfo.NationalCode;
            if (BimarInfo.Picture != null)
            {
                pbProfile.LoadAsync(BimarInfo.Picture);
            }
        }

        private async void btnRecordinformation_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != BimarInfo.FirstName || txtLastName.Text != BimarInfo.LastName ||
                txtMobile.Text != BimarInfo.MobileNumber || txtNc.Text != BimarInfo.NationalCode||
                pbProfile.ImageLocation != null || pbProfile.ImageLocation != BimarInfo.Picture)
            {
                ProgressBar.Visible = true;
                ProgressBar.Start();
                if (pbProfile.ImageLocation != null && pbProfile.ImageLocation != BimarInfo.Picture)
                {
                    var result = await SavePicture.Save(pbProfile.ImageLocation);
                    if (result.IsSuccess)
                    {
                        BimarInfo.Picture = result.Data;
                    }
                    else
                    {
                        ProgressBar.Stop();
                        ProgressBar.Visible = false;
                        ShowError(result.Message);
                        return;
                    }
                }
                BimarInfo.FirstName = txtFirstName.Text;
                BimarInfo.LastName = txtLastName.Text;
                BimarInfo.MobileNumber = txtMobile.Text;
                BimarInfo.NationalCode = txtNc.Text;
                if (BimarInfo.IsValid)
                {
                    var result = await httpClient.PostAsync<OprationResult, BimarInfo>(RouteConstants.UpdateBimar, BimarInfo);
                    ProgressBar.Stop();
                    if (result.IsSuccess)
                    {
                        ShowSuccess(result.Message);
                        FrmBimars.Info = BimarInfo;
                        this.Close();
                    }
                    else
                    {
                        ShowError(result.Message);
                        ProgressBar.Visible = false;
                    }
                }
                else
                {
                    ShowError(BimarInfo.Message);
                    ProgressBar.Stop();
                    ProgressBar.Visible=false;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void PictureBoxProfile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Picture|*.png;*.jpg;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbProfile.ImageLocation = ofd.FileName;
                }
            }
        }
    }
}
