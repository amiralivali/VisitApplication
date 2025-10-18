using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visit.Shared;

namespace Visit.UI
{
    public partial class frmBimars : Form
    {
        public BimarInfo Info { get; set; }
        public frmBimars()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //frmCheckProfile frmCheckProfile = new frmCheckProfile();
            //frmCheckProfile.Show();
        }

        private void frmBimars_Load(object sender, EventArgs e)
        {

        }
    }
}
