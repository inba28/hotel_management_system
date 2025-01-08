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
    public partial class UserManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Inba\\source\\repos\\HotelManagementSystem\\HotelManagementSystem\\HotelManagementDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter sda;
        public UserManagement()
        {
            InitializeComponent();
            displaydata();
        }

        private void displaydata()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM users",con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg_users.DataSource = dt;
            con.Close();
        }

        private void cleardata()
        {
            txt_id.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";
            cb_user_type.SelectedIndex = -1;
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminPortal adminform = new AdminPortal();
            adminform.Show();
            this.Hide();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO users (username,password,user_type) VALUES (@username,@password,@user_type)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                cmd.Parameters.AddWithValue("@user_type", cb_user_type.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                displaydata(); cleardata();
                MessageBox.Show("User created successfully!");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Fill in all the Details and Username cannot be repeated.\n\n" + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE users SET username = @username, password = @password,user_type = @user_type WHERE id = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                cmd.Parameters.AddWithValue("@user_type", cb_user_type.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                displaydata(); cleardata();
                MessageBox.Show("User updated successfully!");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Fill in all the details and Username cannot be repeated. Edit if the username is assigned to any rooms before changing here.\n\n" + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE users WHERE id = @id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata(); cleardata();
            MessageBox.Show("User deleted successfully!");
        }

        private void dg_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_users.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_username.Text = dg_users.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_password.Text = dg_users.Rows[e.RowIndex].Cells[2].Value.ToString();
            cb_user_type.Text = dg_users.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
