using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visit.Shared;
using static Visit.Shared.UserRole;

namespace Visit.UI
{
    public partial class frmCheckProfileDoctor : frmStyle
    {
        public DoctorInfo DoctorInfo { get; set; }
        public frmDoctors FrmDoctors { get; set; }
        HttpClientHelper HttpClient;
        public frmCheckProfileDoctor()
        {
            InitializeComponent();
            HttpClient = HttpClientHelper.GetInstance();
        }

        private void frmCheckProfile_Load(object sender, EventArgs e)
        {
            txtFirstName.Text=DoctorInfo.FirstName;
            txtLastName.Text=DoctorInfo.LastName;
            txtMobile.Text = DoctorInfo.MobileNumber;
            txtNezam.Text = DoctorInfo.CodeNezamPezeshki;
            if (DoctorInfo.Picture != null)
            {
               pbProfile.LoadAsync(DoctorInfo.Picture);
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            // شرط برای این است که در صورتی که تغییر اعمال شد به دیتابیس درخواست بدم
            if (txtFirstName.Text != DoctorInfo.FirstName || txtLastName.Text != DoctorInfo.LastName || txtMobile.Text != DoctorInfo.MobileNumber || txtNezam.Text != DoctorInfo.CodeNezamPezeshki)
            {
                DoctorInfo = new DoctorInfo()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MobileNumber = txtMobile.Text,
                    CodeNezamPezeshki = txtNezam.Text,
                };
                if (pbProfile.Image != Properties.Resources.Profile && pbProfile.ImageLocation!=DoctorInfo.Picture)
                {
                    DoctorInfo.Picture = await SavePicture.Save(pbProfile.ImageLocation);
                }
                if (DoctorInfo.IsValid)
                {
                    var result = await HttpClient.PostAsync<OprationResult, DoctorInfo>(RouteConstants.UpdateDoctor, DoctorInfo);
                    if (result.IsSuccess)
                    {
                        ShowSuccess(result.Message);
                        FrmDoctors.Info = DoctorInfo;
                        this.Close();
                    }
                    else
                    {
                        ShowError(result.Message);
                    }
                }
                else
                {
                    ShowError(DoctorInfo.Message);
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
