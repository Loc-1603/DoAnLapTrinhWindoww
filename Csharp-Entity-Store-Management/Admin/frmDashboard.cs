using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Entity_Store_Management
{
    public partial class frmDashboard : Form
    {
        private User user;
        private int index = 1;
        public User User { get => user; set => user = value; }

        public frmDashboard()
        {
            InitializeComponent();
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            clickedButton(index);
            lblUsername.Text = "Xin chào: " + user.fullname + " !";

            panel.Visible = false;

            loadPanel();
            frmStatistics frm = new frmStatistics();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            //panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
