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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class frm_Staff : Form
    {
        StaffController staffcontroller;
        public frm_Staff()
        {
            staffcontroller = new StaffController();
            InitializeComponent();
            LoadStaffs();
        }

        public void LoadStaffs()
        {
            stagridview.DataSource = null;
            stagridview.DataSource = staffcontroller.GetStaffList();
            stagridview.ClearSelection();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
           /* frm_Staff staff = new frm_Staff();
            staff.TopLevel = false;
            staff.FormBorderStyle = FormBorderStyle.None;
            staff.Dock = DockStyle.Fill;

           // panel3.Controls.Add(staff);
            staff.Show();
*/



        }

        private void staffbtnadd_Click(object sender, EventArgs e)
        {
           Staff staff = new Staff();
            staff.Name = staname.Text;
            staff.Address = staaddress.Text;
            staff.UserName= stausername.Text;   
            staff.Password = stapassword.Text;


            
            staffcontroller.AddStaff(staff);
            staname.Text = "";
            staaddress.Text = "";
            stausername.Text = "";
            stapassword.Text = "";

            MessageBox.Show("Added Successfully");
            LoadStaffs();

        }

        private void stagridview_SelectionChanged(object sender, EventArgs e)
        {
            if (stagridview.SelectedRows.Count > 0)
            {
                staname.Text = stagridview.SelectedRows[0].Cells["Name"].Value.ToString();
                staaddress.Text = stagridview.SelectedRows[0].Cells["Address"].Value.ToString();
                stausername.Text = stagridview.SelectedRows[0].Cells["Username"].Value.ToString();
                //stapassword.Text = stagridview.SelectedRows[0].Cells["Password "].Value.ToString();




            }
        }

        private void staffbtnupdate_Click(object sender, EventArgs e)
        {
            if (stagridview.SelectedRows.Count > 0)
            {
                int SubjectID = Convert.ToInt32(stagridview.SelectedRows[0].Cells["Id"].Value);
                Staff staff = new Staff()
                {
                    Id = SubjectID,
                    Name = staname.Text,
                    Address = staaddress.Text,
                    UserName = stausername.Text,
                    Password = stapassword.Text,

                };
                staffcontroller.UpdateStaff(staff);
                LoadStaffs();
                MessageBox.Show("Staff Updated Success");
                staname.Text = "";
                staaddress.Text = "";
                stausername.Text = "";
                stapassword.Text = "";
            }
        }

        private void stagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void staffbtndelete_Click(object sender, EventArgs e)
        {
            if (stagridview.SelectedRows.Count > 0)
            {
                int SubjectID = Convert.ToInt32(stagridview.SelectedRows[0].Cells["Id"].Value);
                Staff staff = new Staff()
                {
                    Id = SubjectID,
                    Name = staname.Text,
                    Address = staaddress.Text,
                    UserName = stausername.Text,
                    Password = stapassword.Text,

                };
                staffcontroller.DeleteStaff(SubjectID);
                LoadStaffs();
                staname.Text = "";
                staaddress.Text = "";
                stausername.Text = "";
                stapassword.Text = "";
              
             }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.ShowDialog();
        }
    }
}
