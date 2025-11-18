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
    public partial class UC_Doctors : UserControl
    {
        public DoctorDto Info { get; set; }
        public bool IsPresentTime
        {
            get => btnVisit.Enabled; set => btnVisit.Enabled = value;
        }
        public UC_Doctors()
        {
            InitializeComponent();
        }

        private void UC_Doctors_Load(object sender, EventArgs e)
        {
            if (Info != null)
            {
                lblFullName.Text = Info.FullName;
                var titles = Info.Takhasos.Select(t => t.Titel).ToList();
                lblTakhasos.Text = Messages.Takhasos + " : " + string.Join(" , ", titles);
                string timeText = string.Format(Messages.WorkingTime, Info.StartTime, Info.EndTime);
                lblTime.Text = timeText;
                if (Info.Picture != null)
                {
                    pictureBoxProfile.LoadAsync(Info.Picture);
                }
            }
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmDoctorTurn frmDoctorTurn = new frmDoctorTurn();
            frmDoctorTurn.Show();
        }
    }
}
