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
    public partial class frmDoctors : Form
    {
        public DoctorInfo Info { get; set; }
        public frmStart FrmStart { get; set; }
        public frmDoctors()
        {
            InitializeComponent();
        }

        private void frmDoctors_Load(object sender, EventArgs e)
        {

        }

        private void frmDoctors_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.frmStart = FrmStart;
            frmLogin.Show();
        }
    }
}
