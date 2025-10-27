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
               // PictureBoxProfile.Image = Info.Picture;
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
                if (PictureBoxProfile.Image != Properties.Resources.Profile)
                {
                    //bimarInfo.Picture=PictureBoxProfile.Image;
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
                    PictureBoxProfile.ImageLocation = ofd.FileName;
                }
            }
        }
    }
}
