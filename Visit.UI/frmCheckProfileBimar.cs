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
            if (txtFirstName.Text != BimarInfo.FirstName || txtLastName.Text != BimarInfo.LastName || txtMobile.Text != BimarInfo.MobileNumber || txtNc.Text != BimarInfo.NationalCode)
            {
                BimarInfo = new BimarInfo()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MobileNumber = txtMobile.Text,
                    NationalCode = txtNc.Text,
                };
                if (pbProfile.Image != Properties.Resources.Profile && pbProfile.ImageLocation != BimarInfo.Picture)
                {
                    BimarInfo.Picture = await SavePicture.Save(pbProfile.ImageLocation);
                }
                if (BimarInfo.IsValid)
                {
                    var result = await httpClient.PostAsync<OprationResult, BimarInfo>(RouteConstants.UpdateBimar, BimarInfo);
                    if (result.IsSuccess)
                    {
                        ShowSuccess(result.Message);
                        FrmBimars.Info = BimarInfo;
                        this.Close();
                    }
                    else
                    {
                        ShowError(result.Message);
                    }
                }
                else
                {
                    ShowError(BimarInfo.Message);
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
