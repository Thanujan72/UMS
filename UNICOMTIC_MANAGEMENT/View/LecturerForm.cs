using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UNICOMTIC_MANAGEMENT.Controller;
using UNICOMTIC_MANAGEMENT.Model;
using UNICOMTIC_MANAGEMENT.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class LecturerFrom : Form
    {
        LecturerController controller;
        public LecturerFrom()
        {
            controller = new LecturerController();
            InitializeComponent();
            LoadLecturers();
        }
        private void LoadLecturers()
        {
            lecturergridview.DataSource = null;
            lecturergridview.DataSource = controller.ViewAllLecturer();
            lecturergridview.ClearSelection();
        }

        private void LecturerFrom_Load(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lecbtnupdate_Click(object sender, EventArgs e)
        {
            if (lecturergridview.SelectedRows.Count > 0)
            {
                int lecturerID = Convert.ToInt32(lecturergridview.SelectedRows[0].Cells["LecturerID"].Value);
                Lecturer lecturer = new Lecturer
                {
                    LecturerID = lecturerID,
                    Name = lecname.Text,
                    UserName = lecusername.Text,
                    Password = lecpassword.Text,
                };
                controller.UpdateLecturer(lecturer);
                MessageBox.Show("Updated Successfully","Update Status", MessageBoxButtons.YesNo);
                LoadLecturers();
                lecname.Text = "";
                lecusername.Text = "";
                lecpassword.Text = "";

            }
        }

        private void lecbtnadd_Click(object sender, EventArgs e)
        {
            var lecturer = new Lecturer
            {
                Name = lecname.Text,
                UserName = lecusername.Text,
                Password= lecpassword.Text
            };
            controller.AddLecturer(lecturer);
            MessageBox.Show("Added Successfully", "Added Status", MessageBoxButtons.YesNo);

            LoadLecturers();
            lecname.Text = "";
            lecusername.Text = "";
            lecpassword.Text = "";

            LoadLecturers();

        }

        private void lecturergridview_SelectionChanged(object sender, EventArgs e)
        {
            if (lecturergridview.SelectedRows.Count > 0)
            {

                lecname.Text = lecturergridview.SelectedRows[0].Cells["Name"].Value.ToString();
                lecusername.Text = lecturergridview.SelectedRows[0].Cells["UserName"].Value.ToString();
                lecpassword.Text = lecturergridview.SelectedRows[0].Cells["Password"].Value.ToString();
            }
        }

        private void lecbtndelete_Click(object sender, EventArgs e)
        {
            if (lecturergridview.SelectedRows.Count > 0)
            {
                int lecturerID = Convert.ToInt32(lecturergridview.SelectedRows[0].Cells["LecturerID"].Value);
                Lecturer lecturer = new Lecturer
                {
                    LecturerID = lecturerID,
                    Name = lecname.Text,
                    UserName = lecusername.Text,
                    Password = lecpassword.Text,
                };
                controller.DeleteLecturer(lecturerID);
                MessageBox.Show("Deieted SuccessFully!");
                LoadLecturers();
                lecname.Text = "";
                lecusername.Text = "";
                lecpassword.Text = "";
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            
        }
    }
}
