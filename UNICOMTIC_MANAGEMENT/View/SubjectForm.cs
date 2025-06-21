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
using UNICOMTIC_MANAGEMENT.Model;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class SubjectForm : Form
    {
        SubjectController controller;
        public SubjectForm()
        {
            controller = new SubjectController();
            InitializeComponent();
            LoadSubjects();
        }

        public void LoadSubjects()
        {
            subjectdatagridview.DataSource = null;
            subjectdatagridview.DataSource = controller.GetAllSubjects();
            if (subjectdatagridview.Columns.Contains("CourseID"))
            {
                subjectdatagridview.Columns["CourseID"].Visible = false;
            }
            subjectdatagridview.ClearSelection();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            int courseId = (int)coursename.SelectedValue;

            Subject subject = new Subject
            {
                CourseID = courseId,
                SubjectName = SubjectTxt.Text

            };

            controller.AddSubject(subject);
            MessageBox.Show("Subject Added Success");
            LoadSubjects();
            SubjectTxt.Text = "";
            coursename.Text = "";
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            var courseList = controller.GetAllCourses(); 
            coursename.DataSource = courseList;
            coursename.DisplayMember = "CourseName";
            coursename.ValueMember = "CourseID";

        }

        private void btnSubdeete_Click(object sender, EventArgs e)
        {
            if (subjectdatagridview.SelectedRows.Count > 0)
            {
                int courseId = (int)coursename.SelectedValue;
                int SubjectID = Convert.ToInt32(subjectdatagridview.SelectedRows[0].Cells["SubjectID"].Value);
                Subject subject = new Subject
                {
                    SubjectID = SubjectID,
                    SubjectName = SubjectTxt.Text,
                    CourseID = courseId,


                };
                controller.deleteSubject(SubjectID);
                MessageBox.Show("Subject Deleted SuccessFully");
                LoadSubjects();
                SubjectTxt.Text = "";
                coursename.Text = "";
            }
        }

        private void btnSubUpdate_Click(object sender, EventArgs e)
        {
            if (subjectdatagridview.SelectedRows.Count > 0)
            {
                int courseId = (int)coursename.SelectedValue;
                int SubjectID = Convert.ToInt32(subjectdatagridview.SelectedRows[0].Cells["SubjectID"].Value);
                Subject subject = new Subject
                {
                    SubjectID = SubjectID,
                    SubjectName = SubjectTxt.Text,
                     CourseID = courseId,


                };
                controller.updateSubject(subject);
                MessageBox.Show("Subject Updated SuccessFully");
                LoadSubjects();
                SubjectTxt.Text = "";
                coursename.Text = "";

            }
        }

        private void subjectdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void subjectdatagridview_SelectionChanged(object sender, EventArgs e)
        {
            if (subjectdatagridview.SelectedRows.Count > 0)
            {

                SubjectTxt.Text = subjectdatagridview.SelectedRows[0].Cells["SubjectName"].Value.ToString();

                coursename.Text = subjectdatagridview.SelectedRows[0].Cells["CourseName"].Value.ToString();

            }
        }
    }
    




}
