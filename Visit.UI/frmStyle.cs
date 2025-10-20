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
    public partial class frmStyle : Form
    {
        public frmStyle()
        {
            InitializeComponent();
        }
        protected void ShowError(string message)
        {
            MessageBox.Show(message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        protected void ShowSuccess(string message)
        {
            MessageBox.Show(message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmStyle_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStyle
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmStyle";
            this.Load += new System.EventHandler(this.frmStyle_Load_1);
            this.ResumeLayout(false);

        }

        private void frmStyle_Load_1(object sender, EventArgs e)
        {

        }
    }
}
