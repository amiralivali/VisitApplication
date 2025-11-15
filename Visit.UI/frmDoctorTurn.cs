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
    public partial class frmDoctorTurn : Form
    {
        public DoctorDto Info { get; set; }
        public frmDoctorTurn()
        {
            InitializeComponent();
        }

        private void frmDoctorTurn_Load(object sender, EventArgs e)
        {

        }
    }
}
