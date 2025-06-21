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
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void btnadminlogin_Click(object sender, EventArgs e)
        {
           
                if(adminusername.Text == "Admin" && adminpassword.Text == "Admin@123")
                {
                    MessageBox.Show("SuccessFully Logged in");

                    this.Hide();
                    AdminMenu adminForm = new AdminMenu();
                    adminForm.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Ivalid UserName orb Password");
                }



            
            
            
        }

        private void adminusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adminlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
