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
            if (this.menupanal.Controls.Count > 0)
            {
                this.menupanal.Controls.RemoveAt(0);
            }
            menupanal.Controls.Clear();

            frm_Staff staffForm = new frm_Staff();
            staffForm.TopLevel = false;

            staffForm.Dock = DockStyle.Fill;
            staffForm.FormBorderStyle = FormBorderStyle.None;
            menupanal.Controls.Add(staffForm);
            staffForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.menupanal.Controls.Count > 0)
            {
                this.menupanal.Controls.RemoveAt(0);
            }
            menupanal.Controls.Clear();

            LecturerFrom lectuerForm = new LecturerFrom();
            lectuerForm.TopLevel = false;

            lectuerForm.Dock = DockStyle.Fill;
            lectuerForm.FormBorderStyle = FormBorderStyle.None;
            menupanal.Controls.Add(lectuerForm);
            lectuerForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.menupanal.Controls.Count > 0)
            {
                this.menupanal.Controls.RemoveAt(0);
            }
            menupanal.Controls.Clear();

            StudentFrom studentForm = new StudentFrom();
            studentForm.TopLevel = false;

            studentForm.Dock = DockStyle.Fill;
            studentForm.FormBorderStyle = FormBorderStyle.None;
            menupanal.Controls.Add(studentForm);
            studentForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.menupanal.Controls.Count > 0)
            {
                this.menupanal.Controls.RemoveAt(0);
            }
            menupanal.Controls.Clear();

            Courseform CourseForm = new Courseform();
            CourseForm.TopLevel = false;

            CourseForm.Dock = DockStyle.Fill;
            CourseForm.FormBorderStyle = FormBorderStyle.None;
            menupanal.Controls.Add(CourseForm);
            CourseForm.Show();

        }

        private void stuupdate_Click(object sender, EventArgs e)
        {
            this .Hide();
            MainFrom mainFrom = new MainFrom();
            mainFrom.ShowDialog();
        }
    }
}
