using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
        void FillWorkingTime()
        {
            var startTime = timePickerStart.Value.Value.TimeOfDay;
            var endTime = timePickerEnd.Value.Value.TimeOfDay;
            var timeDifference = endTime - startTime;
            if (timeDifference < TimeSpan.Zero)
            {
                var maxTime = new TimeSpan(24, 0, 0);
                timeDifference = maxTime - timeDifference.Negate();
            }
            string text = "شما میخواهید از ساعت {0} تا ساعت {1} به مدت {2} ساعت کار کنید";
            text = string.Format(text, startTime, endTime,timeDifference);
            lblTime.Text = text;
        }
        private void frmWorkingTime_Load(object sender, EventArgs e)
        {
            FillWorkingTime();
        }

        private void timePickerStart_Click(object sender, EventArgs e)
        {

        }

        private void timePickerStart_ValueChanged(object sender, EventArgs e)
        {
            FillWorkingTime();
        }

        private void timePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            FillWorkingTime();
        }
    }
}
