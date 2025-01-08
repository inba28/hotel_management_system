namespace HotelManagementSystem
{
    partial class Login
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
            this.lbl_login_head = new System.Windows.Forms.Label();
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.lbl_login_password = new System.Windows.Forms.Label();
            this.btn_login_submit = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_user_type = new System.Windows.Forms.Label();
            this.cb_user_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_login_head
            // 
            this.lbl_login_head.AutoSize = true;
            this.lbl_login_head.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_head.ForeColor = System.Drawing.Color.White;
            this.lbl_login_head.Location = new System.Drawing.Point(121, 96);
            this.lbl_login_head.Name = "lbl_login_head";
            this.lbl_login_head.Size = new System.Drawing.Size(772, 69);
            this.lbl_login_head.TabIndex = 0;
            this.lbl_login_head.Text = "Hotel Management System";
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.BackColor = System.Drawing.Color.White;
            this.lbl_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_login_username.Location = new System.Drawing.Point(188, 249);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(168, 38);
            this.lbl_login_username.TabIndex = 1;
            this.lbl_login_username.Text = "Username";
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.BackColor = System.Drawing.Color.White;
            this.lbl_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_password.Location = new System.Drawing.Point(188, 328);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(162, 38);
            this.lbl_login_password.TabIndex = 2;
            this.lbl_login_password.Text = "Password";
            // 
            // btn_login_submit
            // 
            this.btn_login_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_submit.Location = new System.Drawing.Point(419, 525);
            this.btn_login_submit.Name = "btn_login_submit";
            this.btn_login_submit.Size = new System.Drawing.Size(130, 40);
            this.btn_login_submit.TabIndex = 7;
            this.btn_login_submit.Text = "Submit";
            this.btn_login_submit.UseVisualStyleBackColor = true;
            this.btn_login_submit.Click += new System.EventHandler(this.btn_login_submit_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(436, 246);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(363, 45);
            this.txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(436, 325);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(363, 45);
            this.txt_password.TabIndex = 5;
            // 
            // lbl_user_type
            // 
            this.lbl_user_type.AutoSize = true;
            this.lbl_user_type.BackColor = System.Drawing.Color.White;
            this.lbl_user_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_type.Location = new System.Drawing.Point(188, 409);
            this.lbl_user_type.Name = "lbl_user_type";
            this.lbl_user_type.Size = new System.Drawing.Size(169, 38);
            this.lbl_user_type.TabIndex = 3;
            this.lbl_user_type.Text = "User Type";
            // 
            // cb_user_type
            // 
            this.cb_user_type.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "Receptionist",
            "Supervisor"});
            this.cb_user_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_user_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_user_type.FormattingEnabled = true;
            this.cb_user_type.Items.AddRange(new object[] {
            "Admin",
            "Receptionist",
            "Supervisor"});
            this.cb_user_type.Location = new System.Drawing.Point(436, 406);
            this.cb_user_type.Name = "cb_user_type";
            this.cb_user_type.Size = new System.Drawing.Size(363, 46);
            this.cb_user_type.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HotelManagementSystem.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.cb_user_type);
            this.Controls.Add(this.lbl_user_type);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_login_submit);
            this.Controls.Add(this.lbl_login_password);
            this.Controls.Add(this.lbl_login_username);
            this.Controls.Add(this.lbl_login_head);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_head;
        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.Button btn_login_submit;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_user_type;
        private System.Windows.Forms.ComboBox cb_user_type;
    }
}

