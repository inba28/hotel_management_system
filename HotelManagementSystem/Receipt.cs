using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        public void CreateReceipt(String id, String guest_name, String guest_phone, String room_no, String room_type, String check_in, String check_out, String days, String price, String status)
        {
            lbl_id.Text = id; lbl_guest_name.Text = guest_name; lbl_guest_phone.Text = guest_phone; lbl_room_no.Text = room_no;
            lbl_room_type.Text = room_type; lbl_check_in.Text = check_in; lbl_check_out.Text = check_out; lbl_days.Text = days;
            lbl_price.Text = price; lbl_status.Text = status;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(bmp, (pagearea.Width / 2) - (this.PrintPanel.Width / 2), this.PrintPanel.Location.Y);
        }

        private void Print(Panel pl)
        {
            PrinterSettings ps = new PrinterSettings();
            PrintPanel = pl;
            getprintarea(pl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap bmp;

        private void getprintarea(Panel pl)
        {
            bmp = new Bitmap(pl.Width, pl.Height);
            pl.DrawToBitmap(bmp, new Rectangle(0, 0, pl.Width, pl.Height));
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            BillingInformation billingform = new BillingInformation();
            billingform.Show();
            this.Hide();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {   
            Print(this.PrintPanel);
        }
    }
}