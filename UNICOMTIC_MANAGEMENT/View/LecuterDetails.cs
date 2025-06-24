using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNICOMTIC_MANAGEMENT.Controller;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class LecuterDetails : Form
    {
        LecturerController controller;
        public LecuterDetails()
        {
            controller = new LecturerController();
            InitializeComponent();
            LecuterLoad();
        }
        public void LecuterLoad()
        {
            dettalis.DataSource = controller.ViewAllLecturer();
        }

        private void LecuterDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void dettalis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
