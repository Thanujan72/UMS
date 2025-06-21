using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNICOMTIC_MANAGEMENT.Controller;
using UNICOMTIC_MANAGEMENT.Model;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class MarkForm : Form
    {
        MarkController markController;
        public MarkForm()
        {
            markController = new MarkController();
            InitializeComponent();
            MarkLoad();

        }

        public void MarkLoad()
        {
            markGridView.DataSource = null;
            markGridView.DataSource =markController.GetMarkList();
            if (markGridView.Columns.Contains("StudentID"))
            {
                markGridView.Columns["StudentID"].Visible = false;
            }
            if (markGridView.Columns.Contains("ExamID"))
            {
                markGridView.Columns["ExamID"].Visible = false;
            }

            markGridView.ClearSelection();
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {
            studentname.DataSource = markController.GetStudentList();
            studentname.DisplayMember = "Name";
            studentname.ValueMember = "StudentID";


            examname.DataSource = markController.GetExamList();
            examname.DisplayMember = "ExamName";
            examname.ValueMember = "ExamID";
        }

        private void btnmarkadd_Click(object sender, EventArgs e)
        {
            int StudentID = (int)studentname.SelectedValue;
            int ExamID = (int)examname.SelectedValue;

            Mark mark  = new Mark
            {
                StudentId = StudentID,
                ExamID = ExamID,
                Score = int.Parse(markscore.Text)
            };

            markController.AddMark(mark);
            MessageBox.Show("Mark Added Success");
            MarkLoad();
            studentname.Text = "";
            examname.Text = "";
            markscore.Text = "";


        }

        private void markGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (markGridView.SelectedRows.Count > 0)
            {

                studentname.Text = markGridView.SelectedRows[0].Cells["StudentName"].Value.ToString();

                examname.Text = markGridView.SelectedRows[0].Cells["ExamName"].Value.ToString();
                markscore.Text = markGridView.SelectedRows[0].Cells["Score"].Value.ToString();
            }
        }

        private void btnmarkupdate_Click(object sender, EventArgs e)
        {
            if (markGridView.SelectedRows.Count > 0)
            {
                int StudentID = (int)studentname.SelectedValue;
                int ExamID = (int)examname.SelectedValue;
                int Score =Convert.ToInt32(markGridView.SelectedRows[0].Cells["Score"].Value);
                Mark mark = new Mark
                {
                    ExamID = ExamID,
                    Score = Score,
                    StudentId = StudentID

                };
                markController.UpdateMark(mark);
                MessageBox.Show("Mark updated Success*****");
                MarkLoad();
                studentname.Text = "";
                examname.Text = "";
                markscore.Text = "";

            }
        }

        private void btnmarkdelete_Click(object sender, EventArgs e)
        {
            if (markGridView.SelectedRows.Count > 0)
            {
                int StudentID = (int)studentname.SelectedValue;
                int ExamID = (int)examname.SelectedValue;
                int Score = Convert.ToInt32(markGridView.SelectedRows[0].Cells["Score"].Value);
                int MarkID = Convert.ToInt32(markGridView.SelectedRows[0].Cells["MarkID"].Value);
                Mark mark = new Mark
                {
                    ExamID = ExamID,
                    Score = Score,
                    StudentId = StudentID

                };
                markController.DeleteMark(MarkID);
                MessageBox.Show("Mark Deleted Success*****");
                MarkLoad();
                studentname.Text = "";
                examname.Text = "";
                markscore.Text = "";
            }
        }
    }
}
