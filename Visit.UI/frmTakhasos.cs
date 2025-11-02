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
            }
            else
            {
                ShowError(takhasoses.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
