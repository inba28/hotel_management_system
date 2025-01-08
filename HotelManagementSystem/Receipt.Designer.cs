namespace HotelManagementSystem
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.PrintPanel = new System.Windows.Forms.Panel();
            this.lbl_guest_phone = new System.Windows.Forms.Label();
            this.lbl_guest_phone_h = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_hotel_address = new System.Windows.Forms.Label();
            this.lbl_hotel_website = new System.Windows.Forms.Label();
            this.lbl_hotel_email = new System.Windows.Forms.Label();
            this.lbl_hotel_phone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_hotel_sub = new System.Windows.Forms.Label();
            this.lbl_hotel_name = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_days = new System.Windows.Forms.Label();
            this.lbl_check_out = new System.Windows.Forms.Label();
            this.lbl_room_type = new System.Windows.Forms.Label();
            this.lbl_check_in = new System.Windows.Forms.Label();
            this.lbl_room_no = new System.Windows.Forms.Label();
            this.lbl_guest_name = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_guest_name_h = new System.Windows.Forms.Label();
            this.lbl_check_in_h = new System.Windows.Forms.Label();
            this.lbl_check_out_h = new System.Windows.Forms.Label();
            this.lbl_room_no_h = new System.Windows.Forms.Label();
            this.lbl_room_type_h = new System.Windows.Forms.Label();
            this.lbl_days_h = new System.Windows.Forms.Label();
            this.lbl_price_h = new System.Windows.Forms.Label();
            this.lbl_status_h = new System.Windows.Forms.Label();
            this.lbl_id_h = new System.Windows.Forms.Label();
            this.lbl_receipt = new System.Windows.Forms.Label();
            this.PrintPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(13, 653);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 28);
            this.btn_back.TabIndex = 31;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(269, 653);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 28);
            this.btn_print.TabIndex = 32;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(526, 653);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(75, 28);
            this.btn_log_out.TabIndex = 33;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // PrintPanel
            // 
            this.PrintPanel.Controls.Add(this.lbl_guest_phone);
            this.PrintPanel.Controls.Add(this.lbl_guest_phone_h);
            this.PrintPanel.Controls.Add(this.label6);
            this.PrintPanel.Controls.Add(this.label5);
            this.PrintPanel.Controls.Add(this.lbl_contact);
            this.PrintPanel.Controls.Add(this.lbl_hotel_address);
            this.PrintPanel.Controls.Add(this.lbl_hotel_website);
            this.PrintPanel.Controls.Add(this.lbl_hotel_email);
            this.PrintPanel.Controls.Add(this.lbl_hotel_phone);
            this.PrintPanel.Controls.Add(this.label3);
            this.PrintPanel.Controls.Add(this.lbl_hotel_sub);
            this.PrintPanel.Controls.Add(this.lbl_hotel_name);
            this.PrintPanel.Controls.Add(this.lbl_status);
            this.PrintPanel.Controls.Add(this.lbl_price);
            this.PrintPanel.Controls.Add(this.lbl_days);
            this.PrintPanel.Controls.Add(this.lbl_check_out);
            this.PrintPanel.Controls.Add(this.lbl_room_type);
            this.PrintPanel.Controls.Add(this.lbl_check_in);
            this.PrintPanel.Controls.Add(this.lbl_room_no);
            this.PrintPanel.Controls.Add(this.lbl_guest_name);
            this.PrintPanel.Controls.Add(this.lbl_id);
            this.PrintPanel.Controls.Add(this.lbl_guest_name_h);
            this.PrintPanel.Controls.Add(this.lbl_check_in_h);
            this.PrintPanel.Controls.Add(this.lbl_check_out_h);
            this.PrintPanel.Controls.Add(this.lbl_room_no_h);
            this.PrintPanel.Controls.Add(this.lbl_room_type_h);
            this.PrintPanel.Controls.Add(this.lbl_days_h);
            this.PrintPanel.Controls.Add(this.lbl_price_h);
            this.PrintPanel.Controls.Add(this.lbl_status_h);
            this.PrintPanel.Controls.Add(this.lbl_id_h);
            this.PrintPanel.Controls.Add(this.lbl_receipt);
            this.PrintPanel.Location = new System.Drawing.Point(2, 1);
            this.PrintPanel.Name = "PrintPanel";
            this.PrintPanel.Size = new System.Drawing.Size(599, 636);
            this.PrintPanel.TabIndex = 34;
            // 
            // lbl_guest_phone
            // 
            this.lbl_guest_phone.AutoSize = true;
            this.lbl_guest_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest_phone.Location = new System.Drawing.Point(309, 306);
            this.lbl_guest_phone.Name = "lbl_guest_phone";
            this.lbl_guest_phone.Size = new System.Drawing.Size(0, 20);
            this.lbl_guest_phone.TabIndex = 52;
            // 
            // lbl_guest_phone_h
            // 
            this.lbl_guest_phone_h.AutoSize = true;
            this.lbl_guest_phone_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest_phone_h.Location = new System.Drawing.Point(84, 306);
            this.lbl_guest_phone_h.Name = "lbl_guest_phone_h";
            this.lbl_guest_phone_h.Size = new System.Drawing.Size(106, 20);
            this.lbl_guest_phone_h.TabIndex = 42;
            this.lbl_guest_phone_h.Text = "Guest Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "______________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 61;
            this.label5.Text = "Signature";
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.Location = new System.Drawing.Point(344, 9);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(87, 26);
            this.lbl_contact.TabIndex = 34;
            this.lbl_contact.Text = "Contact";
            // 
            // lbl_hotel_address
            // 
            this.lbl_hotel_address.AutoSize = true;
            this.lbl_hotel_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotel_address.Location = new System.Drawing.Point(20, 80);
            this.lbl_hotel_address.Name = "lbl_hotel_address";
            this.lbl_hotel_address.Size = new System.Drawing.Size(148, 36);
            this.lbl_hotel_address.TabIndex = 33;
            this.lbl_hotel_address.Text = "91, Islington, London,\r\nAE0 MW";
            // 
            // lbl_hotel_website
            // 
            this.lbl_hotel_website.AutoSize = true;
            this.lbl_hotel_website.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotel_website.Location = new System.Drawing.Point(347, 90);
            this.lbl_hotel_website.Name = "lbl_hotel_website";
            this.lbl_hotel_website.Size = new System.Drawing.Size(192, 18);
            this.lbl_hotel_website.TabIndex = 37;
            this.lbl_hotel_website.Text = "Website  : www.royalty.com";
            // 
            // lbl_hotel_email
            // 
            this.lbl_hotel_email.AutoSize = true;
            this.lbl_hotel_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotel_email.Location = new System.Drawing.Point(347, 67);
            this.lbl_hotel_email.Name = "lbl_hotel_email";
            this.lbl_hotel_email.Size = new System.Drawing.Size(219, 18);
            this.lbl_hotel_email.TabIndex = 36;
            this.lbl_hotel_email.Text = "Email      : support@royalty.com";
            // 
            // lbl_hotel_phone
            // 
            this.lbl_hotel_phone.AutoSize = true;
            this.lbl_hotel_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotel_phone.Location = new System.Drawing.Point(347, 45);
            this.lbl_hotel_phone.Name = "lbl_hotel_phone";
            this.lbl_hotel_phone.Size = new System.Drawing.Size(192, 18);
            this.lbl_hotel_phone.TabIndex = 35;
            this.lbl_hotel_phone.Text = "Phone    : +44 020 123 4567";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(595, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // lbl_hotel_sub
            // 
            this.lbl_hotel_sub.AutoSize = true;
            this.lbl_hotel_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotel_sub.Location = new System.Drawing.Point(20, 51);
            this.lbl_hotel_sub.Name = "lbl_hotel_sub";
            this.lbl_hotel_sub.Size = new System.Drawing.Size(161, 22);
            this.lbl_hotel_sub.TabIndex = 32;
            this.lbl_hotel_sub.Text = "Hotel and Services";
            // 
            // lbl_hotel_name
            // 
            this.lbl_hotel_name.AutoSize = true;
            this.lbl_hotel_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotel_name.Location = new System.Drawing.Point(15, 5);
            this.lbl_hotel_name.Name = "lbl_hotel_name";
            this.lbl_hotel_name.Size = new System.Drawing.Size(154, 46);
            this.lbl_hotel_name.TabIndex = 31;
            this.lbl_hotel_name.Text = "Royalty";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(310, 520);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 20);
            this.lbl_status.TabIndex = 59;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(310, 491);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(0, 20);
            this.lbl_price.TabIndex = 58;
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_days.Location = new System.Drawing.Point(310, 460);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(0, 20);
            this.lbl_days.TabIndex = 57;
            // 
            // lbl_check_out
            // 
            this.lbl_check_out.AutoSize = true;
            this.lbl_check_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_check_out.Location = new System.Drawing.Point(309, 429);
            this.lbl_check_out.Name = "lbl_check_out";
            this.lbl_check_out.Size = new System.Drawing.Size(0, 20);
            this.lbl_check_out.TabIndex = 56;
            // 
            // lbl_room_type
            // 
            this.lbl_room_type.AutoSize = true;
            this.lbl_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_type.Location = new System.Drawing.Point(309, 368);
            this.lbl_room_type.Name = "lbl_room_type";
            this.lbl_room_type.Size = new System.Drawing.Size(0, 20);
            this.lbl_room_type.TabIndex = 54;
            // 
            // lbl_check_in
            // 
            this.lbl_check_in.AutoSize = true;
            this.lbl_check_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_check_in.Location = new System.Drawing.Point(309, 399);
            this.lbl_check_in.Name = "lbl_check_in";
            this.lbl_check_in.Size = new System.Drawing.Size(0, 20);
            this.lbl_check_in.TabIndex = 55;
            // 
            // lbl_room_no
            // 
            this.lbl_room_no.AutoSize = true;
            this.lbl_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_no.Location = new System.Drawing.Point(309, 338);
            this.lbl_room_no.Name = "lbl_room_no";
            this.lbl_room_no.Size = new System.Drawing.Size(0, 20);
            this.lbl_room_no.TabIndex = 53;
            // 
            // lbl_guest_name
            // 
            this.lbl_guest_name.AutoSize = true;
            this.lbl_guest_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest_name.Location = new System.Drawing.Point(309, 276);
            this.lbl_guest_name.Name = "lbl_guest_name";
            this.lbl_guest_name.Size = new System.Drawing.Size(0, 20);
            this.lbl_guest_name.TabIndex = 51;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(309, 246);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 20);
            this.lbl_id.TabIndex = 50;
            // 
            // lbl_guest_name_h
            // 
            this.lbl_guest_name_h.AutoSize = true;
            this.lbl_guest_name_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest_name_h.Location = new System.Drawing.Point(84, 276);
            this.lbl_guest_name_h.Name = "lbl_guest_name_h";
            this.lbl_guest_name_h.Size = new System.Drawing.Size(103, 20);
            this.lbl_guest_name_h.TabIndex = 41;
            this.lbl_guest_name_h.Text = "Guest Name";
            // 
            // lbl_check_in_h
            // 
            this.lbl_check_in_h.AutoSize = true;
            this.lbl_check_in_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_check_in_h.Location = new System.Drawing.Point(84, 399);
            this.lbl_check_in_h.Name = "lbl_check_in_h";
            this.lbl_check_in_h.Size = new System.Drawing.Size(74, 20);
            this.lbl_check_in_h.TabIndex = 45;
            this.lbl_check_in_h.Text = "Check In";
            // 
            // lbl_check_out_h
            // 
            this.lbl_check_out_h.AutoSize = true;
            this.lbl_check_out_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_check_out_h.Location = new System.Drawing.Point(84, 429);
            this.lbl_check_out_h.Name = "lbl_check_out_h";
            this.lbl_check_out_h.Size = new System.Drawing.Size(88, 20);
            this.lbl_check_out_h.TabIndex = 46;
            this.lbl_check_out_h.Text = "Check Out";
            // 
            // lbl_room_no_h
            // 
            this.lbl_room_no_h.AutoSize = true;
            this.lbl_room_no_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_no_h.Location = new System.Drawing.Point(84, 338);
            this.lbl_room_no_h.Name = "lbl_room_no_h";
            this.lbl_room_no_h.Size = new System.Drawing.Size(83, 20);
            this.lbl_room_no_h.TabIndex = 43;
            this.lbl_room_no_h.Text = "Room No.";
            // 
            // lbl_room_type_h
            // 
            this.lbl_room_type_h.AutoSize = true;
            this.lbl_room_type_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_type_h.Location = new System.Drawing.Point(84, 368);
            this.lbl_room_type_h.Name = "lbl_room_type_h";
            this.lbl_room_type_h.Size = new System.Drawing.Size(94, 20);
            this.lbl_room_type_h.TabIndex = 44;
            this.lbl_room_type_h.Text = "Room Type";
            // 
            // lbl_days_h
            // 
            this.lbl_days_h.AutoSize = true;
            this.lbl_days_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_days_h.Location = new System.Drawing.Point(85, 460);
            this.lbl_days_h.Name = "lbl_days_h";
            this.lbl_days_h.Size = new System.Drawing.Size(97, 20);
            this.lbl_days_h.TabIndex = 47;
            this.lbl_days_h.Text = "No. of Days";
            // 
            // lbl_price_h
            // 
            this.lbl_price_h.AutoSize = true;
            this.lbl_price_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_h.Location = new System.Drawing.Point(85, 491);
            this.lbl_price_h.Name = "lbl_price_h";
            this.lbl_price_h.Size = new System.Drawing.Size(48, 20);
            this.lbl_price_h.TabIndex = 48;
            this.lbl_price_h.Text = "Price";
            // 
            // lbl_status_h
            // 
            this.lbl_status_h.AutoSize = true;
            this.lbl_status_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_h.Location = new System.Drawing.Point(85, 520);
            this.lbl_status_h.Name = "lbl_status_h";
            this.lbl_status_h.Size = new System.Drawing.Size(57, 20);
            this.lbl_status_h.TabIndex = 49;
            this.lbl_status_h.Text = "Status";
            // 
            // lbl_id_h
            // 
            this.lbl_id_h.AutoSize = true;
            this.lbl_id_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_h.Location = new System.Drawing.Point(84, 246);
            this.lbl_id_h.Name = "lbl_id_h";
            this.lbl_id_h.Size = new System.Drawing.Size(91, 20);
            this.lbl_id_h.TabIndex = 40;
            this.lbl_id_h.Text = "Booking ID";
            // 
            // lbl_receipt
            // 
            this.lbl_receipt.AutoSize = true;
            this.lbl_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receipt.Location = new System.Drawing.Point(226, 150);
            this.lbl_receipt.Name = "lbl_receipt";
            this.lbl_receipt.Size = new System.Drawing.Size(156, 46);
            this.lbl_receipt.TabIndex = 39;
            this.lbl_receipt.Text = "Receipt";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 693);
            this.Controls.Add(this.PrintPanel);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_back);
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.PrintPanel.ResumeLayout(false);
            this.PrintPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Panel PrintPanel;
        private System.Windows.Forms.Label lbl_guest_phone;
        private System.Windows.Forms.Label lbl_guest_phone_h;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_hotel_address;
        private System.Windows.Forms.Label lbl_hotel_website;
        private System.Windows.Forms.Label lbl_hotel_email;
        private System.Windows.Forms.Label lbl_hotel_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_hotel_sub;
        private System.Windows.Forms.Label lbl_hotel_name;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.Label lbl_check_out;
        private System.Windows.Forms.Label lbl_room_type;
        private System.Windows.Forms.Label lbl_check_in;
        private System.Windows.Forms.Label lbl_room_no;
        private System.Windows.Forms.Label lbl_guest_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_guest_name_h;
        private System.Windows.Forms.Label lbl_check_in_h;
        private System.Windows.Forms.Label lbl_check_out_h;
        private System.Windows.Forms.Label lbl_room_no_h;
        private System.Windows.Forms.Label lbl_room_type_h;
        private System.Windows.Forms.Label lbl_days_h;
        private System.Windows.Forms.Label lbl_price_h;
        private System.Windows.Forms.Label lbl_status_h;
        private System.Windows.Forms.Label lbl_id_h;
        private System.Windows.Forms.Label lbl_receipt;
    }
}