using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visit.UI
{
    public partial class frmWorkingTime : Form
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public frmWorkingTime()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StartTime = timePickerStart.Value.Value.TimeOfDay;
            EndTime = timePickerEnd.Value.Value.TimeOfDay;
            this.Close();
        }
    }
}
