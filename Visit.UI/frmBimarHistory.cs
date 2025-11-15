using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmBimarHistory : FrmStyleHelpers
    {
        HttpClientHelper httpHelper;
        public int ID { private get; set; }
        public frmBimarHistory()
        {
            InitializeComponent();
            httpHelper=HttpClientHelper.GetInstance();
        }
        private async void FillDGV(string search = "")
        {
            string route = string.Format(RouteConstants.SelectVisit, ID, search);
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

        private void frmBimarHistory_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDGV(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillDGV(txtSearch.Text);
        }
    }
}
