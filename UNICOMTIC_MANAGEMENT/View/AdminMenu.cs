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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Staff staff = new frm_Staff();
            staff.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerFrom lecturer = new LecturerFrom();
            lecturer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentFrom studentFrom = new StudentFrom();
            studentFrom.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courseform courseform = new Courseform();
            courseform.ShowDialog();

        }

        private void stuupdate_Click(object sender, EventArgs e)
        {
            this .Hide();
            MainFrom mainFrom = new MainFrom();
            mainFrom.ShowDialog();
        }
    }
}
