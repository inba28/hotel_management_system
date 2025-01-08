using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class RoomManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Inba\\source\\repos\\HotelManagementSystem\\HotelManagementSystem\\HotelManagementDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter sda;
        public RoomManagement()
        {
            InitializeComponent();

            dtp_check_in.Format = DateTimePickerFormat.Custom;
            dtp_check_in.CustomFormat = "dd/MM/yyyy";

            dtp_check_out.Format = DateTimePickerFormat.Custom;
            dtp_check_out.CustomFormat = "dd/MM/yyyy";

            displaydata();
        }

        private void displaydata()
        {
            con.Open();
            cmd = new SqlCommand("SELECT r.room_no, r.room_type, rg.guest_name, rg.guest_age, rg.guest_phone, rg.guest_email, rg.purpose, rg.check_in_date, rg.check_out_date, rg.days, r.room_price FROM rooms AS r LEFT JOIN room_guests AS rg ON r.room_no = rg.room_no", con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg_room_guests.DataSource = dt;
            con.Close();
        }

        private void cleardata()
        {
            txt_room_no.Text = "";
            txt_room_type.Text = "";
            txt_guest_name.Text = "";
            txt_guest_age.Text = "";
            txt_guest_phone.Text = "";
            txt_guest_email.Text = "";
            txt_purpose.Text = "";
            txt_days.Text = "";
            txt_room_price.Text = "";

        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ReceptionistPortal receptionistform = new ReceptionistPortal();
            receptionistform.Show();
            this.Hide();
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO room_guests (room_no,guest_name,guest_age,guest_phone,guest_email,purpose,check_in_date,check_out_date,days) VALUES (@room_no, @guest_name, @guest_age, @guest_phone, @guest_email, @purpose, @check_in_date, @check_out_date, @days)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@room_no", txt_room_no.Text);
                cmd.Parameters.AddWithValue("@guest_name", txt_guest_name.Text);
                cmd.Parameters.AddWithValue("@guest_age", txt_guest_age.Text);
                cmd.Parameters.AddWithValue("@guest_phone", txt_guest_phone.Text);
                cmd.Parameters.AddWithValue("@guest_email", txt_guest_email.Text);
                cmd.Parameters.AddWithValue("@purpose", txt_purpose.Text);
                cmd.Parameters.AddWithValue("@check_in_date", dtp_check_in.Value.Date.ToString("dd-MM-yyyy"));
                cmd.Parameters.AddWithValue("@check_out_date", dtp_check_out.Value.Date.ToString("dd-MM-yyyy"));
                cmd.Parameters.AddWithValue("@days", txt_days.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                displaydata(); cleardata();
                MessageBox.Show("Room booked successfully!");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Select at least one Room.\n\n" + ex.Message);
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE room_guests SET guest_name = @guest_name, guest_age = @guest_age, guest_phone = @guest_phone, guest_email = @guest_email, purpose = @purpose, check_in_date = @check_in_date, check_out_date = @check_out_date, days = @days WHERE room_no = @room_no", con);
                con.Open();
                cmd.Parameters.AddWithValue("@room_no", txt_room_no.Text);
                cmd.Parameters.AddWithValue("@guest_name", txt_guest_name.Text);
                cmd.Parameters.AddWithValue("@guest_age", txt_guest_age.Text);
                cmd.Parameters.AddWithValue("@guest_phone", txt_guest_phone.Text);
                cmd.Parameters.AddWithValue("@guest_email", txt_guest_email.Text);
                cmd.Parameters.AddWithValue("@purpose", txt_purpose.Text);
                cmd.Parameters.AddWithValue("@check_in_date", dtp_check_in.Value.Date.ToString("dd-MM-yyyy"));
                cmd.Parameters.AddWithValue("@check_out_date", dtp_check_out.Value.Date.ToString("dd-MM-yyyy"));
                cmd.Parameters.AddWithValue("@days", txt_days.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                displaydata(); cleardata();
                MessageBox.Show("Guest details updated successfully!");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Select at least one Room.\n\n" + ex.Message);
            }
        }

        private void btn_check_out_Click(object sender, EventArgs e)
        {
            if (txt_guest_name.Text == "" || txt_days.Text == "" || txt_room_price.Text == "" || txt_guest_phone.Text == "")
            {
                MessageBox.Show("Guest Name, Guest Phone and No. of Days are mandatory for Check Out!");
            }
            else
            { 
                cmd = new SqlCommand("INSERT INTO room_billing (guest_name,guest_phone,room_no,room_type,check_in_date,check_out_date,days,price) VALUES (@guest_name,@guest_phone,@room_no,@room_type,@check_in_date,@check_out_date,@days,@price)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@guest_name", txt_guest_name.Text);
                cmd.Parameters.AddWithValue("@guest_phone", txt_guest_phone.Text);
                cmd.Parameters.AddWithValue("@room_no", txt_room_no.Text);
                cmd.Parameters.AddWithValue("@room_type", txt_room_type.Text);
                cmd.Parameters.AddWithValue("@check_in_date", dtp_check_in.Value.Date.ToString("dd-MM-yyyy"));
                cmd.Parameters.AddWithValue("@check_out_date", dtp_check_out.Value.Date.ToString("dd-MM-yyyy"));
                cmd.Parameters.AddWithValue("@days", txt_days.Text);
                cmd.Parameters.AddWithValue("@price", Int32.Parse(txt_days.Text) * Int32.Parse(txt_room_price.Text));
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("DELETE FROM room_guests WHERE room_no = @room_no", con);
                cmd.Parameters.AddWithValue("@room_no", txt_room_no.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Room Checked Out Successfully!");
                displaydata(); cleardata();
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT rg.room_no, r.room_type, rg.guest_name, rg.guest_age, rg.guest_phone, rg.guest_email, rg.purpose, rg.days, r.room_price FROM room_guests AS rg INNER JOIN rooms AS r ON rg.room_no = r.room_no WHERE CONCAT(rg.room_no,rg.guest_name,rg.guest_phone,rg.guest_email) LIKE '%" + txt_search_box.Text + "%'", con);
            con.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg_room_guests.DataSource = dt;
            con.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void dtp_check_in_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan day_difference = dtp_check_out.Value - dtp_check_in.Value;
            int days = day_difference.Days;
            if(days == 0) { days = 1; }
            txt_days.Text = Convert.ToString(days);
        }

        private void dtp_check_out_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan day_difference = dtp_check_out.Value - dtp_check_in.Value;
            int days = day_difference.Days;
            if (days == 0) { days = 1; }
            txt_days.Text = Convert.ToString(days);
        }

        private void dg_room_guests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_room_no.Text = dg_room_guests.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_room_type.Text = dg_room_guests.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_guest_name.Text = dg_room_guests.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_guest_age.Text = dg_room_guests.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_guest_phone.Text = dg_room_guests.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_guest_email.Text = dg_room_guests.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_purpose.Text = dg_room_guests.Rows[e.RowIndex].Cells[6].Value.ToString();
            dtp_check_in.Text = dg_room_guests.Rows[e.RowIndex].Cells[7].Value.ToString();
            dtp_check_out.Text = dg_room_guests.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_days.Text = dg_room_guests.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_room_price.Text = dg_room_guests.Rows[e.RowIndex].Cells[10].Value.ToString();
        }
    }
}
