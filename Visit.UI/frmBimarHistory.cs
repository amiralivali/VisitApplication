using System;
using System.Windows.Forms;

namespace Visit.UI
{
    public partial class frmBimarHistory : frmStyle
    {
        HttpClientHelper httpHelper;
        public int ID { private get; set; }
        public frmBimarHistory()
        {
            InitializeComponent();
            httpHelper=HttpClientHelper.GetInstance();
        }

        private void frmBimarHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
