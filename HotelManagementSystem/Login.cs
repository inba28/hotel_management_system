using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Inba\\source\\repos\\HotelManagementSystem\\HotelManagementSystem\\HotelManagementDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username = @username AND password = @password AND user_type = @user_type",con);
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);
            cmd.Parameters.AddWithValue("@user_type", cb_user_type.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0 )
            {
                if (cb_user_type.Text == "Admin")
                {
                    AdminPortal adminform = new AdminPortal();
                    adminform.Show();
                    this.Hide();
                }
                else if (cb_user_type.Text == "Receptionist")
                {
                    ReceptionistPortal receptionistform = new ReceptionistPortal();
                    receptionistform.Show();
                    this.Hide();
                }
                else
                {
                    SupervisorPortal supervisorform = new SupervisorPortal();
                    supervisorform.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Error!, Check the Username and Password.");
            }
        }
    }
}
