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
    public partial class RoomForm : Form
    {
        RoomController roomController;
        public RoomForm()
        {
            roomController = new RoomController();
            InitializeComponent();
            LoadRooms();
        }
        public void LoadRooms()
        {
            RoomView.DataSource = null;
            RoomView.DataSource = roomController.GetRooms();
            RoomView.ClearSelection();
        }

        private void RoomAdd_Click(object sender, EventArgs e)
        {

            var room = new Room
            {
                RoomType = roomtype.SelectedItem.ToString(),
                RoomName = roomname.Text
            };
            roomController.AddRooms(room);
            MessageBox.Show("Rooms added success... ");
            LoadRooms();
            roomtype.Text = "";
            roomname.Text = "";
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

            roomtype.Items.Add("Lab");
            roomtype.Items.Add("Hall");
            roomtype.DropDownStyle = ComboBoxStyle.DropDownList;
            

        }

        private void RoomView_SelectionChanged(object sender, EventArgs e)
        {
            if (RoomView.SelectedRows.Count > 0)
            {
                roomtype.Text = RoomView.SelectedRows[0].Cells["RoomType"].Value.ToString();
                roomname.Text = RoomView.SelectedRows[0].Cells["RoomName"].Value.ToString();
            }
        }
    }
}
