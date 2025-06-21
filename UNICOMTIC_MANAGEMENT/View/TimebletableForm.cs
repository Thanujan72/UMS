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
    public partial class TimebletableForm : Form
    {
        TimetableController timetableController;
        public TimebletableForm()
        {
            timetableController = new TimetableController();
            InitializeComponent();
            LoadTimeTable();
        }
        public void LoadTimeTable()
        {
            Timetable.DataSource = null;
            Timetable.DataSource = timetableController.GetTimetableList();
            if (Timetable.Columns.Contains("SubjectID"))
            {
                Timetable.Columns["SubjectID"].Visible = false;
            }
            if (Timetable.Columns.Contains("RoomID"))
            {
                Timetable.Columns["RoomID"].Visible = false;
            }
            if (Timetable.Columns.Contains("RoomName"))
            {
                Timetable.Columns["RoomName"].Visible = false;
            }

            Timetable.ClearSelection();

        }

        private void timetableadd_Click(object sender, EventArgs e)
        {
            int SubjectID = (int)combosubeject.SelectedValue;
            int RoomID = (int)timetableroom.SelectedValue;
            string TimeSlot = timbletabletimeslot.Text.ToString();
            Timetable timetable = new Timetable
            {
                SubjectID = SubjectID,
                RoomID = RoomID,
                TimeSlot = TimeSlot
            };
            timetableController.AddTimetable(timetable);
            MessageBox.Show("TimeTable Added Success***");
            LoadTimeTable();
            timetableroom.Text = "";
            combosubeject.Text = "";
            timetableupdate.Text = "";


        }

        private void timetableupdate_Click(object sender, EventArgs e)
        {
            if (Timetable.SelectedRows.Count > 0)
            {
                int timetableId = Convert.ToInt32(Timetable.SelectedRows[0].Cells["TimeTableID"].Value);
                int RoomID = (int)timetableroom.SelectedValue;
                int SubjectID = (int)combosubeject.SelectedValue;
                string TimeSlot = timbletabletimeslot.Text.ToString();
                Timetable timetable = new Timetable
                {
                    TimeTableID = timetableId,
                    SubjectID = SubjectID,
                    RoomID = RoomID,
                    TimeSlot = TimeSlot
                };

                
                timetableController.UpdateTimetable(timetable);
                MessageBox.Show("TimeTable Updated Success***");
                LoadTimeTable();
                timetableroom.Text = "";
                combosubeject.Text = "";
                timbletabletimeslot.Text = "";

            }
        }

        private void TimebletableForm_Load(object sender, EventArgs e)
        {

            combosubeject.DataSource = timetableController.GetAllSubjects();
            combosubeject.DisplayMember = "SubjectName";
            combosubeject.ValueMember = "SubjectID";


            timetableroom.DataSource = timetableController.GetAllRooms();
            timetableroom.DisplayMember = "RoomType";
            timetableroom.ValueMember = "RoomID";
        }

        private void Timetable_SelectionChanged(object sender, EventArgs e)
        {
            if (Timetable.SelectedRows.Count > 0)
            {

                combosubeject.Text = Timetable.SelectedRows[0].Cells["SubjectName"].Value.ToString();
                timetableroom.Text = Timetable.SelectedRows[0].Cells["RoomType"].Value.ToString();
                timbletabletimeslot.Text = Timetable.SelectedRows[0].Cells["TimeSlot"].Value.ToString();

            }
        }

        private void timetabledelete_Click(object sender, EventArgs e)
        {
            if (Timetable.SelectedRows.Count > 0)
            {
                int timetableId = Convert.ToInt32(Timetable.SelectedRows[0].Cells["TimeTableID"].Value);
                int RoomID = (int)timetableroom.SelectedValue;
                int SubjectID = (int)combosubeject.SelectedValue;
                string TimeSlot = timbletabletimeslot.Text.ToString();
                Timetable timetable = new Timetable
                {
                    TimeTableID = timetableId,
                    SubjectID = SubjectID,
                    RoomID = RoomID,
                    TimeSlot = TimeSlot
                };


                timetableController.DeleteTimbleTable(timetableId);
                MessageBox.Show("TimeTable Deleted Success***");
                LoadTimeTable();
                timetableroom.Text = "";
                combosubeject.Text = "";
                timbletabletimeslot.Text = "";
            }
        }
    }
}
