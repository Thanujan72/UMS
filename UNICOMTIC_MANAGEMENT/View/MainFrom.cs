using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void admin_Click(object sender, EventArgs e)
        {

            if (this.panel3.Controls.Count > 0)
            {
                this.panel3.Controls.RemoveAt(0);
            }
            panel3.Controls.Clear();

            Adminlogin adminForm = new Adminlogin();
            adminForm.TopLevel = false; 
            
            adminForm.Dock = DockStyle.Fill;
            adminForm.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(adminForm); 
            adminForm.Show(); 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

          Userlogin userform = new Userlogin();
            userform.TopLevel = false;
            
            userform.Dock = DockStyle.Fill;
            userform.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(userform);
            userform.Show();
        }
    }
}
