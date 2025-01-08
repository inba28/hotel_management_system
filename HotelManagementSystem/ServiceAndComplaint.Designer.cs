namespace HotelManagementSystem
{
    partial class ServiceAndComplaint
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_room_no = new System.Windows.Forms.Label();
            this.lbl_request_type = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_room_no = new System.Windows.Forms.TextBox();
            this.cb_request_type = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.rtxt_description = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raise a Complaint / Service Request";
            // 
            // lbl_room_no
            // 
            this.lbl_room_no.AutoSize = true;
            this.lbl_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_no.Location = new System.Drawing.Point(211, 211);
            this.lbl_room_no.Name = "lbl_room_no";
            this.lbl_room_no.Size = new System.Drawing.Size(164, 38);
            this.lbl_room_no.TabIndex = 1;
            this.lbl_room_no.Text = "Room No.";
            // 
            // lbl_request_type
            // 
            this.lbl_request_type.AutoSize = true;
            this.lbl_request_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_request_type.Location = new System.Drawing.Point(211, 294);
            this.lbl_request_type.Name = "lbl_request_type";
            this.lbl_request_type.Size = new System.Drawing.Size(221, 38);
            this.lbl_request_type.TabIndex = 2;
            this.lbl_request_type.Text = "Request Type";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(211, 379);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(181, 38);
            this.lbl_description.TabIndex = 3;
            this.lbl_description.Text = "Description";
            // 
            // txt_room_no
            // 
            this.txt_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_no.Location = new System.Drawing.Point(480, 208);
            this.txt_room_no.Name = "txt_room_no";
            this.txt_room_no.Size = new System.Drawing.Size(272, 45);
            this.txt_room_no.TabIndex = 4;
            // 
            // cb_request_type
            // 
            this.cb_request_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_request_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_request_type.FormattingEnabled = true;
            this.cb_request_type.Items.AddRange(new object[] {
            "Service",
            "Complaint"});
            this.cb_request_type.Location = new System.Drawing.Point(480, 291);
            this.cb_request_type.Name = "cb_request_type";
            this.cb_request_type.Size = new System.Drawing.Size(272, 46);
            this.cb_request_type.TabIndex = 5;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(426, 561);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(135, 46);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(887, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(107, 29);
            this.btn_log_out.TabIndex = 8;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 29);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // rtxt_description
            // 
            this.rtxt_description.Location = new System.Drawing.Point(480, 379);
            this.rtxt_description.Name = "rtxt_description";
            this.rtxt_description.Size = new System.Drawing.Size(272, 134);
            this.rtxt_description.TabIndex = 6;
            this.rtxt_description.Text = "";
            // 
            // ServiceAndComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.rtxt_description);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cb_request_type);
            this.Controls.Add(this.txt_room_no);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_request_type);
            this.Controls.Add(this.lbl_room_no);
            this.Controls.Add(this.label1);
            this.Name = "ServiceAndComplaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raise a Complaint / Service Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_room_no;
        private System.Windows.Forms.Label lbl_request_type;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_room_no;
        private System.Windows.Forms.ComboBox cb_request_type;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.RichTextBox rtxt_description;
    }
}