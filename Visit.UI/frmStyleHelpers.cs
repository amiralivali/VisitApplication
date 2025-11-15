using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visit.UI
{
    public class FrmStyleHelpers : Form
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
