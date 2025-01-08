using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_management_Click(object sender, EventArgs e)
        {
            UserManagement usersmanagementform = new UserManagement();
            usersmanagementform.Show();
            this.Hide();
        }

        private void btn_change_room_Click(object sender, EventArgs e)
        {
            RoomType roomtypeform = new RoomType();
            roomtypeform.Show();
            this.Hide();
        }

        private void btn_change_supervisor_Click(object sender, EventArgs e)
        {
            RoomSupervisor roomsupervisorform = new RoomSupervisor();
            roomsupervisorform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();

        }

    }
}
