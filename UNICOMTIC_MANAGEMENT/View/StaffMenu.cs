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
            this.Hide();
            TimebletableForm timebletableForm = new TimebletableForm();
            timebletableForm.ShowDialog();
        }

        private void btnexam_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamForm examForm = new ExamForm();
            examForm.ShowDialog();
        }

        private void btnmark_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarkForm markForm = new MarkForm(); 
            markForm.ShowDialog();
        }
    }
}
