using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmDoctorHistory : frmStyle
    {
        HttpClientHelper httpHelper;
        public int ID { private get; set; }
        public frmDoctorHistory()
        {
            InitializeComponent();
            httpHelper = HttpClientHelper.GetInstance();
        }

        private void frmDoctorHistory_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private async void FillDGV(string search="")
        {
            string route =string.Format(RouteConstants.SelectVisit,ID,search);
            var visits = await httpHelper.GetAsync<OprationResult<List<VisitDto>>>(route);
            if (visits.IsSuccess)
            {
                dgvHistorys.DataSource = visits.Data;
            }
            else
            {
                ShowError(visits.Message);
            }
        }

        private void dgvHistorys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDGV(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillDGV(txtSearch.Text);
        }

        private void dgvHistorys_Click(object sender, EventArgs e)
        {

        }
    }
}
