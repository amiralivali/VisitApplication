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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Visit.UI
{
    public partial class frmTakhasos : frmStyle
    {
        public frmDoctors FrmDoctors { get; set; }
        HttpClientHelper HttpClientHelper;
        public frmTakhasos()
        {
            InitializeComponent();
            HttpClientHelper= HttpClientHelper.GetInstance();
        }

        private async void frmTakhasos_Load(object sender, EventArgs e)
        {
            var takhasoses = await HttpClientHelper.GetAsync<OprationResult<List<TakhasosInfo>>>(RouteConstants.SelectTakhasos);
            if (takhasoses.IsSuccess)
            {
                ComboBox.DataSource = takhasoses.Data;
                ComboBox.DisplayMember = "Titel";
                ComboBox.ValueMember = "ID";
            }
            else
            {
                ShowError(takhasoses.Message);
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var value = Convert.ToByte(ComboBox.SelectedValue);
            var doctorTakhasos = new Doctor_TakhasosInfo()
            {
                DoctorID = FrmDoctors.Info.DoctorID,
                TakhasosID = value,
            };
            var submitTakhasos= await HttpClientHelper.PostAsync<OprationResult,Doctor_TakhasosInfo>(RouteConstants.InsertTakhasos,doctorTakhasos);
            if (submitTakhasos.IsSuccess)
            {
                var takhasos = new TakhasosInfo()
                {
                    ID = (byte)ComboBox.SelectedValue,
                    Titel = ComboBox.Text
                };
                FrmDoctors.Takhasos=takhasos;
                FrmDoctors.Show();
                this.Close();
            }
        }
    }
}
