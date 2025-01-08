namespace HotelManagementSystem
{
    partial class RoomType
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
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_change_room_type = new System.Windows.Forms.Label();
            this.txt_room_no = new System.Windows.Forms.TextBox();
            this.txt_room_type = new System.Windows.Forms.TextBox();
            this.dg_room_type = new System.Windows.Forms.DataGridView();
            this.lbl_room_type = new System.Windows.Forms.Label();
            this.lbl_room_no = new System.Windows.Forms.Label();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_room_price = new System.Windows.Forms.Label();
            this.txt_room_price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_room_type)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(455, 318);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 50);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_change_room_type
            // 
            this.lbl_change_room_type.AutoSize = true;
            this.lbl_change_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change_room_type.Location = new System.Drawing.Point(238, 47);
            this.lbl_change_room_type.Name = "lbl_change_room_type";
            this.lbl_change_room_type.Size = new System.Drawing.Size(562, 69);
            this.lbl_change_room_type.TabIndex = 0;
            this.lbl_change_room_type.Text = "Change Room Type";
            // 
            // txt_room_no
            // 
            this.txt_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_no.Location = new System.Drawing.Point(502, 155);
            this.txt_room_no.Name = "txt_room_no";
            this.txt_room_no.ReadOnly = true;
            this.txt_room_no.Size = new System.Drawing.Size(214, 32);
            this.txt_room_no.TabIndex = 4;
            // 
            // txt_room_type
            // 
            this.txt_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_type.Location = new System.Drawing.Point(502, 204);
            this.txt_room_type.Name = "txt_room_type";
            this.txt_room_type.Size = new System.Drawing.Size(214, 32);
            this.txt_room_type.TabIndex = 5;
            // 
            // dg_room_type
            // 
            this.dg_room_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_room_type.Location = new System.Drawing.Point(162, 415);
            this.dg_room_type.Name = "dg_room_type";
            this.dg_room_type.RowHeadersWidth = 51;
            this.dg_room_type.RowTemplate.Height = 24;
            this.dg_room_type.Size = new System.Drawing.Size(682, 258);
            this.dg_room_type.TabIndex = 8;
            this.dg_room_type.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_room_type_CellClick);
            // 
            // lbl_room_type
            // 
            this.lbl_room_type.AutoSize = true;
            this.lbl_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_type.Location = new System.Drawing.Point(329, 207);
            this.lbl_room_type.Name = "lbl_room_type";
            this.lbl_room_type.Size = new System.Drawing.Size(124, 26);
            this.lbl_room_type.TabIndex = 2;
            this.lbl_room_type.Text = "Room Type";
            // 
            // lbl_room_no
            // 
            this.lbl_room_no.AutoSize = true;
            this.lbl_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_no.Location = new System.Drawing.Point(329, 155);
            this.lbl_room_no.Name = "lbl_room_no";
            this.lbl_room_no.Size = new System.Drawing.Size(111, 26);
            this.lbl_room_no.TabIndex = 1;
            this.lbl_room_no.Text = "Room No.";
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(887, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(107, 29);
            this.btn_log_out.TabIndex = 9;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 29);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_room_price
            // 
            this.lbl_room_price.AutoSize = true;
            this.lbl_room_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_price.Location = new System.Drawing.Point(329, 257);
            this.lbl_room_price.Name = "lbl_room_price";
            this.lbl_room_price.Size = new System.Drawing.Size(127, 26);
            this.lbl_room_price.TabIndex = 3;
            this.lbl_room_price.Text = "Room Price";
            // 
            // txt_room_price
            // 
            this.txt_room_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_price.Location = new System.Drawing.Point(502, 254);
            this.txt_room_price.Name = "txt_room_price";
            this.txt_room_price.Size = new System.Drawing.Size(214, 32);
            this.txt_room_price.TabIndex = 6;
            // 
            // RoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.txt_room_price);
            this.Controls.Add(this.lbl_room_price);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_change_room_type);
            this.Controls.Add(this.txt_room_no);
            this.Controls.Add(this.txt_room_type);
            this.Controls.Add(this.dg_room_type);
            this.Controls.Add(this.lbl_room_type);
            this.Controls.Add(this.lbl_room_no);
            this.Name = "RoomType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Type";
            ((System.ComponentModel.ISupportInitialize)(this.dg_room_type)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_change_room_type;
        private System.Windows.Forms.TextBox txt_room_no;
        private System.Windows.Forms.TextBox txt_room_type;
        private System.Windows.Forms.DataGridView dg_room_type;
        private System.Windows.Forms.Label lbl_room_type;
        private System.Windows.Forms.Label lbl_room_no;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_room_price;
        private System.Windows.Forms.TextBox txt_room_price;
    }
}