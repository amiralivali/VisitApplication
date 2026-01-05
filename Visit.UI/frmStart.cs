using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Visit.Shared;
namespace Visit.UI
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }
        private void btnBimar_Click(object sender, EventArgs e)
        {
            frmBimarLogin frmLogin = new frmBimarLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            frmDoctorLogin frmLogin = new frmDoctorLogin();
            this.Hide();
            frmLogin.Show();
        }

        private async void frmStart_Load_1(object sender, EventArgs e)
        {

            var c = new HubConnectionBuilder().WithUrl("http://localhost/VisitApi/PresenceHub").Build();

            c.On<Dictionary<string, int>>("UpdateOnlineDoctors", (d) =>
            {
                listBox1.Items.Clear();
                foreach (var x in d)
                    listBox1.Items.Add(x.Value);
            });

            await c.StartAsync();
        }
    }
}
