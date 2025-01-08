namespace HotelManagementSystem
{
    partial class RoomManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_room_management = new System.Windows.Forms.Label();
            this.txt_room_no = new System.Windows.Forms.TextBox();
            this.txt_room_type = new System.Windows.Forms.TextBox();
            this.dg_room_guests = new System.Windows.Forms.DataGridView();
            this.lbl_guest_name = new System.Windows.Forms.Label();
            this.lbl_room_type = new System.Windows.Forms.Label();
            this.lbl_room_no = new System.Windows.Forms.Label();
            this.txt_guest_name = new System.Windows.Forms.TextBox();
            this.lbl_guest_age = new System.Windows.Forms.Label();
            this.txt_guest_age = new System.Windows.Forms.TextBox();
            this.txt_purpose = new System.Windows.Forms.TextBox();
            this.txt_guest_phone = new System.Windows.Forms.TextBox();
            this.txt_guest_email = new System.Windows.Forms.TextBox();
            this.lbl_purpose = new System.Windows.Forms.Label();
            this.lbl_guest_email = new System.Windows.Forms.Label();
            this.lbl_guest_phone = new System.Windows.Forms.Label();
            this.btn_check_out = new System.Windows.Forms.Button();
            this.txt_search_box = new System.Windows.Forms.TextBox();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_days = new System.Windows.Forms.Label();
            this.txt_days = new System.Windows.Forms.TextBox();
            this.lbl_room_price = new System.Windows.Forms.Label();
            this.txt_room_price = new System.Windows.Forms.TextBox();
            this.dtp_check_in = new System.Windows.Forms.DateTimePicker();
            this.dtp_check_out = new System.Windows.Forms.DateTimePicker();
            this.lbl_check_in = new System.Windows.Forms.Label();
            this.lbl_check_out = new System.Windows.Forms.Label();
            this.btn_book = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_room_guests)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(721, 406);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(123, 38);
            this.btn_refresh.TabIndex = 28;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(656, 346);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(123, 38);
            this.btn_update.TabIndex = 24;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(571, 406);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(123, 38);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_room_management
            // 
            this.lbl_room_management.AutoSize = true;
            this.lbl_room_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_management.Location = new System.Drawing.Point(235, 47);
            this.lbl_room_management.Name = "lbl_room_management";
            this.lbl_room_management.Size = new System.Drawing.Size(553, 69);
            this.lbl_room_management.TabIndex = 0;
            this.lbl_room_management.Text = "Room Management";
            // 
            // txt_room_no
            // 
            this.txt_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_no.Location = new System.Drawing.Point(266, 139);
            this.txt_room_no.Name = "txt_room_no";
            this.txt_room_no.ReadOnly = true;
            this.txt_room_no.Size = new System.Drawing.Size(214, 32);
            this.txt_room_no.TabIndex = 12;
            // 
            // txt_room_type
            // 
            this.txt_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_type.Location = new System.Drawing.Point(266, 191);
            this.txt_room_type.Name = "txt_room_type";
            this.txt_room_type.ReadOnly = true;
            this.txt_room_type.Size = new System.Drawing.Size(214, 32);
            this.txt_room_type.TabIndex = 13;
            // 
            // dg_room_guests
            // 
            this.dg_room_guests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_room_guests.Location = new System.Drawing.Point(93, 458);
            this.dg_room_guests.Name = "dg_room_guests";
            this.dg_room_guests.RowHeadersWidth = 51;
            this.dg_room_guests.RowTemplate.Height = 24;
            this.dg_room_guests.Size = new System.Drawing.Size(818, 225);
            this.dg_room_guests.TabIndex = 29;
            this.dg_room_guests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_room_guests_CellClick);
            // 
            // lbl_guest_name
            // 
            this.lbl_guest_name.AutoSize = true;
            this.lbl_guest_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest_name.Location = new System.Drawing.Point(86, 247);
            this.lbl_guest_name.Name = "lbl_guest_name";
            this.lbl_guest_name.Size = new System.Drawing.Size(135, 26);
            this.lbl_guest_name.TabIndex = 3;
            this.lbl_guest_name.Text = "Guest Name";
            // 
            // lbl_room_type
            // 
            this.lbl_room_type.AutoSize = true;
            this.lbl_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_type.Location = new System.Drawing.Point(87, 194);
            this.lbl_room_type.Name = "lbl_room_type";
            this.lbl_room_type.Size = new System.Drawing.Size(124, 26);
            this.lbl_room_type.TabIndex = 2;
            this.lbl_room_type.Text = "Room Type";
            // 
            // lbl_room_no
            // 
            this.lbl_room_no.AutoSize = true;
            this.lbl_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_no.Location = new System.Drawing.Point(87, 142);
            this.lbl_room_no.Name = "lbl_room_no";
            this.lbl_room_no.Size = new System.Drawing.Size(111, 26);
            this.lbl_room_no.TabIndex = 1;
            this.lbl_room_no.Text = "Room No.";
            // 
            // txt_guest_name
            // 
            this.txt_guest_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guest_name.Location = new System.Drawing.Point(266, 244);
            this.txt_guest_name.Name = "txt_guest_name";
            this.txt_guest_name.Size = new System.Drawing.Size(214, 32);
            this.txt_guest_name.TabIndex = 14;
            // 
            // lbl_guest_age
            // 
            this.lbl_guest_age.AutoSize = true;
            this.lbl_guest_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest_age.Location = new System.Drawing.Point(88, 302);
            this.lbl_guest_age.Name = "lbl_guest_age";
            this.lbl_guest_age.Size = new System.Drawing.Size(115, 26);
            this.lbl_guest_age.TabIndex = 4;
            this.lbl_guest_age.Text = "Guest Age";
            // 
            // txt_guest_age
            // 
            this.txt_guest_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guest_age.Location = new System.Drawing.Point(266, 299);
            this.txt_guest_age.Name = "txt_guest_age";
            this.txt_guest_age.Size = new System.Drawing.Size(214, 32);
            this.txt_guest_age.TabIndex = 15;
            // 
            // txt_purpose
            // 
            this.txt_purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purpose.Location = new System.Drawing.Point(697, 191);
            this.txt_purpose.Name = "txt_purpose";
            this.txt_purpose.Size = new System.Drawing.Size(214, 32);
            this.txt_purpose.TabIndex = 18;
            // 
            // txt_guest_phone
            // 
            this.txt_guest_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guest_phone.Location = new System.Drawing.Point(266, 352);
            this.txt_guest_phone.Name = "txt_guest_phone";
            this.txt_guest_phone.Size = new System.Drawing.Size(214, 32);
            this.txt_guest_phone.TabIndex = 16;
            // 
            // txt_guest_email
            // 
            this.txt_guest_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guest_email.Location = new System.Drawing.Point(697, 139);
            this.txt_guest_email.Name = "txt_guest_email";
            this.txt_guest_email.Size = new System.Drawing.Size(214, 32);
            this.txt_guest_email.TabIndex = 17;
            // 
            // lbl_purpose
            // 
            this.lbl_purpose.AutoSize = true;
            this.lbl_purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purpose.Location = new System.Drawing.Point(517, 194);
            this.lbl_purpose.Name = "lbl_purpose";
            this.lbl_purpose.Size = new System.Drawing.Size(93, 26);
            this.lbl_purpose.TabIndex = 7;
            this.lbl_purpose.Text = "Purpose";
            // 
            // lbl_guest_email
            // 
            this.lbl_guest_email.AutoSize = true;
            this.lbl_guest_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest_email.Location = new System.Drawing.Point(517, 142);
            this.lbl_guest_email.Name = "lbl_guest_email";
            this.lbl_guest_email.Size = new System.Drawing.Size(132, 26);
            this.lbl_guest_email.TabIndex = 6;
            this.lbl_guest_email.Text = "Guest Email";
            // 
            // lbl_guest_phone
            // 
            this.lbl_guest_phone.AutoSize = true;
            this.lbl_guest_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest_phone.Location = new System.Drawing.Point(87, 355);
            this.lbl_guest_phone.Name = "lbl_guest_phone";
            this.lbl_guest_phone.Size = new System.Drawing.Size(139, 26);
            this.lbl_guest_phone.TabIndex = 5;
            this.lbl_guest_phone.Text = "Guest Phone";
            // 
            // btn_check_out
            // 
            this.btn_check_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check_out.Location = new System.Drawing.Point(788, 346);
            this.btn_check_out.Name = "btn_check_out";
            this.btn_check_out.Size = new System.Drawing.Size(123, 38);
            this.btn_check_out.TabIndex = 25;
            this.btn_check_out.Text = "Check Out";
            this.btn_check_out.UseVisualStyleBackColor = true;
            this.btn_check_out.Click += new System.EventHandler(this.btn_check_out_Click);
            // 
            // txt_search_box
            // 
            this.txt_search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_box.Location = new System.Drawing.Point(162, 409);
            this.txt_search_box.Name = "txt_search_box";
            this.txt_search_box.Size = new System.Drawing.Size(387, 32);
            this.txt_search_box.TabIndex = 26;
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(887, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(107, 29);
            this.btn_log_out.TabIndex = 30;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 29);
            this.btn_back.TabIndex = 31;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_days.Location = new System.Drawing.Point(517, 247);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(62, 26);
            this.lbl_days.TabIndex = 8;
            this.lbl_days.Text = "Days";
            // 
            // txt_days
            // 
            this.txt_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_days.Location = new System.Drawing.Point(598, 244);
            this.txt_days.Name = "txt_days";
            this.txt_days.ReadOnly = true;
            this.txt_days.Size = new System.Drawing.Size(51, 32);
            this.txt_days.TabIndex = 19;
            // 
            // lbl_room_price
            // 
            this.lbl_room_price.AutoSize = true;
            this.lbl_room_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_price.Location = new System.Drawing.Point(517, 302);
            this.lbl_room_price.Name = "lbl_room_price";
            this.lbl_room_price.Size = new System.Drawing.Size(127, 26);
            this.lbl_room_price.TabIndex = 11;
            this.lbl_room_price.Text = "Room Price";
            // 
            // txt_room_price
            // 
            this.txt_room_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_price.Location = new System.Drawing.Point(697, 299);
            this.txt_room_price.Name = "txt_room_price";
            this.txt_room_price.ReadOnly = true;
            this.txt_room_price.Size = new System.Drawing.Size(214, 32);
            this.txt_room_price.TabIndex = 22;
            // 
            // dtp_check_in
            // 
            this.dtp_check_in.Location = new System.Drawing.Point(770, 236);
            this.dtp_check_in.Name = "dtp_check_in";
            this.dtp_check_in.Size = new System.Drawing.Size(141, 22);
            this.dtp_check_in.TabIndex = 20;
            this.dtp_check_in.Value = new System.DateTime(2024, 4, 7, 0, 0, 0, 0);
            this.dtp_check_in.ValueChanged += new System.EventHandler(this.dtp_check_in_ValueChanged);
            // 
            // dtp_check_out
            // 
            this.dtp_check_out.Location = new System.Drawing.Point(770, 264);
            this.dtp_check_out.Name = "dtp_check_out";
            this.dtp_check_out.Size = new System.Drawing.Size(141, 22);
            this.dtp_check_out.TabIndex = 21;
            this.dtp_check_out.Value = new System.DateTime(2024, 4, 7, 0, 0, 0, 0);
            this.dtp_check_out.ValueChanged += new System.EventHandler(this.dtp_check_out_ValueChanged);
            // 
            // lbl_check_in
            // 
            this.lbl_check_in.AutoSize = true;
            this.lbl_check_in.Location = new System.Drawing.Point(694, 241);
            this.lbl_check_in.Name = "lbl_check_in";
            this.lbl_check_in.Size = new System.Drawing.Size(58, 16);
            this.lbl_check_in.TabIndex = 9;
            this.lbl_check_in.Text = "Check In";
            // 
            // lbl_check_out
            // 
            this.lbl_check_out.AutoSize = true;
            this.lbl_check_out.Location = new System.Drawing.Point(694, 269);
            this.lbl_check_out.Name = "lbl_check_out";
            this.lbl_check_out.Size = new System.Drawing.Size(68, 16);
            this.lbl_check_out.TabIndex = 10;
            this.lbl_check_out.Text = "Check Out";
            // 
            // btn_book
            // 
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.Location = new System.Drawing.Point(521, 346);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(123, 38);
            this.btn_book.TabIndex = 23;
            this.btn_book.Text = "Book";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.lbl_check_out);
            this.Controls.Add(this.lbl_check_in);
            this.Controls.Add(this.dtp_check_out);
            this.Controls.Add(this.dtp_check_in);
            this.Controls.Add(this.txt_room_price);
            this.Controls.Add(this.lbl_room_price);
            this.Controls.Add(this.txt_days);
            this.Controls.Add(this.lbl_days);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.txt_search_box);
            this.Controls.Add(this.btn_check_out);
            this.Controls.Add(this.txt_purpose);
            this.Controls.Add(this.txt_guest_phone);
            this.Controls.Add(this.txt_guest_email);
            this.Controls.Add(this.lbl_purpose);
            this.Controls.Add(this.lbl_guest_email);
            this.Controls.Add(this.lbl_guest_phone);
            this.Controls.Add(this.txt_guest_age);
            this.Controls.Add(this.lbl_guest_age);
            this.Controls.Add(this.txt_guest_name);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_room_management);
            this.Controls.Add(this.txt_room_no);
            this.Controls.Add(this.txt_room_type);
            this.Controls.Add(this.dg_room_guests);
            this.Controls.Add(this.lbl_guest_name);
            this.Controls.Add(this.lbl_room_type);
            this.Controls.Add(this.lbl_room_no);
            this.Name = "RoomManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Management";
            ((System.ComponentModel.ISupportInitialize)(this.dg_room_guests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_room_management;
        private System.Windows.Forms.TextBox txt_room_no;
        private System.Windows.Forms.TextBox txt_room_type;
        private System.Windows.Forms.DataGridView dg_room_guests;
        private System.Windows.Forms.Label lbl_guest_name;
        private System.Windows.Forms.Label lbl_room_type;
        private System.Windows.Forms.Label lbl_room_no;
        private System.Windows.Forms.TextBox txt_guest_name;
        private System.Windows.Forms.Label lbl_guest_age;
        private System.Windows.Forms.TextBox txt_guest_age;
        private System.Windows.Forms.TextBox txt_purpose;
        private System.Windows.Forms.TextBox txt_guest_phone;
        private System.Windows.Forms.TextBox txt_guest_email;
        private System.Windows.Forms.Label lbl_purpose;
        private System.Windows.Forms.Label lbl_guest_email;
        private System.Windows.Forms.Label lbl_guest_phone;
        private System.Windows.Forms.Button btn_check_out;
        private System.Windows.Forms.TextBox txt_search_box;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.TextBox txt_days;
        private System.Windows.Forms.Label lbl_room_price;
        private System.Windows.Forms.TextBox txt_room_price;
        private System.Windows.Forms.DateTimePicker dtp_check_in;
        private System.Windows.Forms.DateTimePicker dtp_check_out;
        private System.Windows.Forms.Label lbl_check_in;
        private System.Windows.Forms.Label lbl_check_out;
        private System.Windows.Forms.Button btn_book;
    }
}