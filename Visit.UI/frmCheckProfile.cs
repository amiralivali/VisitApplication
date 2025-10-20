using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visit.Shared;
using static Visit.Shared.UserRole;

namespace Visit.UI
{
    public partial class frmCheckProfile : frmStyle
    {
        public UserInfo Info { get; set; }
        public frmBimars FrmBimars { get; set; }
        public frmDoctors FrmDoctors { get; set; }
        private string NcNezam { get; set; }
        HttpClientHelper HttpClient;
        OprationResult result;
        public frmCheckProfile(string ncNezam)
        {
            InitializeComponent();
            if (UserRole.CurrentRole == Role.Bimar)
            {
                lblNcNezam.Text = "کد ملی";
            }
            else
            {
                lblNcNezam.Text = "کد نظام پزشکی";
            }
            NcNezam = ncNezam;
            HttpClient = new HttpClientHelper();
            result = new OprationResult();
        }

        private void frmCheckProfile_Load(object sender, EventArgs e)
        {
            txtFirstName.Text=Info.FirstName;
            txtLastName.Text=Info.LastName;
            txtMobile.Text = Info.MobileNumber;
            txtNcNezam.Text = NcNezam;
            if (Info.Picture != null)
            {
               // PictureBoxProfile.Image = Info.Picture;
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            // شرط برای این است که در صورتی که تغییر اعمال شد به دیتابیس درخواست بدم
            if (txtFirstName.Text != Info.FirstName || txtLastName.Text != Info.LastName || txtMobile.Text != Info.MobileNumber || txtNcNezam.Text != NcNezam)
            {
                if (UserRole.CurrentRole == Role.Bimar)
                {
                    BimarInfo bimarInfo = new BimarInfo()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        MobileNumber = txtMobile.Text,
                        NationalCode = txtNcNezam.Text,
                        Picture = Info.Picture,
                    };
                    if (PictureBoxProfile.Image != Properties.Resources.Profile)
                    {
                        //bimarInfo.Picture=PictureBoxProfile.Image;
                    }
                    if (bimarInfo.IsValid)
                    {
                        await Task.Run(async() =>
                        {
                             result = await HttpClient.PostAsync<OprationResult, BimarInfo>(RouteConstants.UpdateBimar,bimarInfo);
                        });
                        if (result.IsSuccess)
                        {
                            ShowSuccess(result.Message);
                            FrmBimars.Info = bimarInfo;
                            this.Close();
                        }
                        else
                        {
                            ShowError(result.Message);
                        }
                    }
                    else
                    {
                        ShowError(bimarInfo.Message);
                    }
                }
                else
                {
                    DoctorInfo doctorInfo = new DoctorInfo()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        MobileNumber = txtMobile.Text,
                        CodeNezamPezeshki = txtNcNezam.Text,
                        Picture = Info.Picture,
                    };
                    if (PictureBoxProfile.Image != Properties.Resources.Profile)
                    {
                        //bimarInfo.Picture=PictureBoxProfile.Image;
                    }
                    if (doctorInfo.IsValid)
                    {
                        await Task.Run(async () =>
                        {
                            result = await HttpClient.PostAsync<OprationResult, DoctorInfo>(RouteConstants.UpdateDoctor, doctorInfo);
                        });
                        if (result.IsSuccess)
                        {
                            ShowSuccess(result.Message);
                            FrmDoctors.Info = doctorInfo;
                            this.Close();
                        }
                        else
                        {
                            ShowError(result.Message);
                        }
                    }
                    else
                    {
                        ShowError(doctorInfo.Message);
                    }
                }
            }
            else 
            {
                this.Close();
            }
        }

        private void PictureBoxProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture|*.png;*.jpg;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBoxProfile.ImageLocation = ofd.FileName;
            }
        }
    }
}
