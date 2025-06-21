using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNICOMTIC_MANAGEMENT.Controller;
using UNICOMTIC_MANAGEMENT.Model;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class ExamForm : Form
    {
        ExamContoller contoller;
        public ExamForm()
        {
            contoller = new ExamContoller();
            InitializeComponent();
            LoadExam();
        }
        public void LoadExam()
        {
            ExamGridView.DataSource = null;
            ExamGridView.DataSource = contoller.GetExamList();
            if (ExamGridView.Columns.Contains("SubjectID"))
            {
                ExamGridView.Columns["SubjectID"].Visible = false;
            }
            if (ExamGridView.Columns.Contains("SubjectName"))
            {
                ExamGridView.Columns["SubjectName"].Visible = false;

            }
            if ((ExamGridView.Columns.Contains("RoomID")))
            {
                ExamGridView.Columns["RoomID"].Visible = false;
            }
            
            
            ExamGridView.ClearSelection();



        }


        private void examadd_Click(object sender, EventArgs e)
        {
            int SubjectID = (int)subjectname.SelectedValue;
            int roomID = (int)room.SelectedValue;
            DateTime examDate = (DateTime)ExamDatetime.Value;
            Exam exam = new Exam
            {
                SubjectID = SubjectID,
                ExamName = subjectname.Text,
                ExamDate = examDate,
                RoomID = roomID,
                
            };
            contoller.AddExam(exam);
            MessageBox.Show("Exam Added Success");
            LoadExam();
            subjectname.SelectedValue = "";
            room.SelectedValue = "";
            ExamDatetime.Text = "";

        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
           
            subjectname.DataSource = contoller.GetSubjectList();
            subjectname.DisplayMember = "SubjectName";
            subjectname.ValueMember = "SubjectID";

            room.DataSource = contoller.GetRoomList();
            room.DisplayMember = "RoomType";
            room.ValueMember = "RoomID";

        }

        private void ExamGridView_SelectionChanged(object sender, EventArgs e)
        {
          
            {
                if (ExamGridView.SelectedRows.Count > 0)
                {
                    subjectname.SelectedValue = ExamGridView.SelectedRows[0].Cells["SubjectID"].Value;
                    room.SelectedValue = ExamGridView.SelectedRows[0].Cells["RoomID"].Value;

                    var examDateCell = ExamGridView.SelectedRows[0].Cells["ExamDate"].Value;

                    if (examDateCell != null && examDateCell != DBNull.Value)
                    {
                        DateTime examDate;
                        if (DateTime.TryParse(examDateCell.ToString(), out examDate))
                        {
                            if (examDate >= ExamDatetime.MinDate && examDate <= ExamDatetime.MaxDate)
                            {
                                ExamDatetime.Value = examDate;
                            }
                            else
                            {
                                ExamDatetime.Value = DateTime.Today;
                            }
                        }
                        else
                        {
                            ExamDatetime.Value = DateTime.Today;
                        }
                    }
                    else
                    {
                        ExamDatetime.Value = DateTime.Today;
                    }
                }
            }

        }

        private void ExamDatetime_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = ExamDatetime.Value;
            MessageBox.Show("Selected Exam Date: " + selectedDate.ToString("dd-MM-yyyy"));
        }

        private void examupdate_Click(object sender, EventArgs e)
        {
            if (ExamGridView.SelectedRows.Count > 0)
            {
              
                    if (ExamGridView.SelectedRows.Count > 0)
                    {
                        int SubjectID = (int)subjectname.SelectedValue;
                        int examId = Convert.ToInt32(ExamGridView.SelectedRows[0].Cells["ExamID"].Value);
                        string examName = subjectname.Text; 
                        DateTime examDate = ExamDatetime.Value;
                        int roomId = (int)room.SelectedValue; 

                        Exam exam = new Exam
                        {
                            ExamId = examId,
                            ExamName = examName,
                            ExamDate = examDate,
                            RoomID = roomId,
                            SubjectID = SubjectID
                        };

                        contoller.UpdateExam(exam);
                        LoadExam();
                    MessageBox.Show("Do you want to update the exam?", "Confirm Update");
                        subjectname.SelectedValue = "";
                        room.SelectedValue = "";
                        ExamDatetime.Text = "";

                }


            }
        }

        private void examdelete_Click(object sender, EventArgs e)
        {
            if (ExamGridView.SelectedRows.Count > 0)
            {

                if (ExamGridView.SelectedRows.Count > 0)
                {
                    int SubjectID = (int)subjectname.SelectedValue;
                    int examId = Convert.ToInt32(ExamGridView.SelectedRows[0].Cells["ExamID"].Value);
                    string examName = subjectname.Text;
                    DateTime examDate = ExamDatetime.Value;
                    int roomId = (int)room.SelectedValue;

                    Exam exam = new Exam
                    {
                        ExamId = examId,
                        ExamName = examName,
                        ExamDate = examDate,
                        RoomID = roomId,
                        SubjectID = SubjectID
                    };

                    contoller.DeleteExam(examId);
                    MessageBox.Show("Do you want to Delete the exam?");
                    LoadExam();
                    subjectname.SelectedValue = "";
                    room.SelectedValue = "";
                    ExamDatetime.Text = "";

                }
            }
        }
    }

}





                    