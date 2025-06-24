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
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
        }

        private void btntimbletable_Click(object sender, EventArgs e)
        {
            if (this.staffpanal.Controls.Count > 0)
            {
                this.staffpanal.Controls.RemoveAt(0);
            }
            staffpanal.Controls.Clear();
            TimebletableForm timebletableForm = new TimebletableForm();
            timebletableForm.TopLevel = false;

            timebletableForm.Dock = DockStyle.Fill;
            timebletableForm.FormBorderStyle = FormBorderStyle.None;
            staffpanal.Controls.Add(timebletableForm);
            timebletableForm.Show();
        }

        private void btnexam_Click(object sender, EventArgs e)
        {
            if (this.staffpanal.Controls.Count > 0)
            {
                this.staffpanal.Controls.RemoveAt(0);
            }
            staffpanal.Controls.Clear();
           ExamForm examForm = new ExamForm();
            examForm.TopLevel = false;

            examForm.Dock = DockStyle.Fill;
            examForm.FormBorderStyle = FormBorderStyle.None;
            staffpanal.Controls.Add(examForm);
            examForm.Show();
        }

        private void btnmark_Click(object sender, EventArgs e)
        {
            if (this.staffpanal.Controls.Count > 0)
            {
                this.staffpanal.Controls.RemoveAt(0);
            }
            staffpanal.Controls.Clear();
            MarkForm markForm = new MarkForm();
            markForm.TopLevel = false;

            markForm.Dock = DockStyle.Fill;
            markForm.FormBorderStyle = FormBorderStyle.None;
            staffpanal.Controls.Add(markForm);
            markForm.Show();
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            if (this.staffpanal.Controls.Count > 0)
            {
                this.staffpanal.Controls.RemoveAt(0);
            }
            staffpanal.Controls.Clear();
            RoomForm roomForm = new RoomForm();
            roomForm.TopLevel = false;

            roomForm.Dock = DockStyle.Fill;
            roomForm.FormBorderStyle = FormBorderStyle.None;
            staffpanal.Controls.Add(roomForm);
            roomForm.Show();
        }

        private void piback_Click(object sender, EventArgs e)
        {
            MainFrom mainFrom = new MainFrom();
            mainFrom.Show();
            this.Hide();
        }
    }
}
