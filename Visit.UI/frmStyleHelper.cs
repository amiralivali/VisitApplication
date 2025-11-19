using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visit.UI
{
    public class frmStyleHelper : Form
    {
        public void ShowSuccess(string message)
        {
            MessageBox.Show(message,"پیغام",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
