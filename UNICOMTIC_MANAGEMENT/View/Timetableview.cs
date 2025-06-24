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
    public partial class Timetableview : Form
    {
        TimetableController controller;
        public Timetableview()
        {
            controller = new TimetableController();
            
            InitializeComponent();
            TimetableLoad();
        }

        private void view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void TimetableLoad()
        {
            view.DataSource = controller.GetTimetableList();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
          
        }
    }
}
