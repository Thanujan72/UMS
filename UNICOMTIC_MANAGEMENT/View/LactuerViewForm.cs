using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNICOMTIC_MANAGEMENT.Session;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class LactuerViewForm : Form
    {
        public LactuerViewForm()
        {
            InitializeComponent();
        }

        private void Timetable_Click(object sender, EventArgs e)
        {
            if (this.lecpanal.Controls.Count > 0)
            {
                this.lecpanal.Controls.RemoveAt(0);
            }
            lecpanal.Controls.Clear();

            Timetableview timetableview = new Timetableview();
            timetableview.TopLevel = false;

            timetableview.Dock = DockStyle.Fill;
            timetableview.FormBorderStyle = FormBorderStyle.None;
            lecpanal.Controls.Add(timetableview);
            timetableview.Show();
        }

        private void Details_Click(object sender, EventArgs e)
        {
            if (this.lecpanal.Controls.Count > 0)
            {
                this.lecpanal.Controls.RemoveAt(0);
            }
            lecpanal.Controls.Clear();

            LecuterDetails lecuterDetails = new LecuterDetails();
            lecuterDetails.TopLevel = false;

            lecuterDetails.Dock = DockStyle.Fill;
            lecuterDetails.FormBorderStyle = FormBorderStyle.None;
            lecpanal.Controls.Add(lecuterDetails);
            lecuterDetails.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MainFrom frm = new MainFrom();
            frm.ShowDialog();
            this.Hide();
        }

        private void lepanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LactuerViewForm_Load(object sender, EventArgs e)
        {
            lblusername.Text = UserSession.UserName;
        }
    }
}
