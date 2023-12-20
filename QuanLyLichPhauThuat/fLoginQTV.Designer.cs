namespace QuanLyLichPhauThuat
{
    partial class fLoginQTV
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxDangNhapQTV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxMatKhauQTV = new System.Windows.Forms.TextBox();
            this.buttonDangNhapQTV = new System.Windows.Forms.Button();
            this.buttonTroLaiQTV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "QUẢN LÝ LỊCH PHẪU THUẬT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "TÊN ĐĂNG NHẬP";
            // 
            // tbxDangNhapQTV
            // 
            this.tbxDangNhapQTV.Location = new System.Drawing.Point(202, 115);
            this.tbxDangNhapQTV.Name = "tbxDangNhapQTV";
            this.tbxDangNhapQTV.Size = new System.Drawing.Size(280, 22);
            this.tbxDangNhapQTV.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "MẬT KHẨU";
            // 
            // tbxMatKhauQTV
            // 
            this.tbxMatKhauQTV.Location = new System.Drawing.Point(202, 159);
            this.tbxMatKhauQTV.Name = "tbxMatKhauQTV";
            this.tbxMatKhauQTV.Size = new System.Drawing.Size(280, 22);
            this.tbxMatKhauQTV.TabIndex = 6;
            this.tbxMatKhauQTV.UseSystemPasswordChar = true;
            // 
            // buttonDangNhapQTV
            // 
            this.buttonDangNhapQTV.Location = new System.Drawing.Point(223, 202);
            this.buttonDangNhapQTV.Name = "buttonDangNhapQTV";
            this.buttonDangNhapQTV.Size = new System.Drawing.Size(137, 34);
            this.buttonDangNhapQTV.TabIndex = 7;
            this.buttonDangNhapQTV.Text = "ĐĂNG NHẬP";
            this.buttonDangNhapQTV.UseVisualStyleBackColor = true;
            // 
            // buttonTroLaiQTV
            // 
            this.buttonTroLaiQTV.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonTroLaiQTV.Location = new System.Drawing.Point(366, 202);
            this.buttonTroLaiQTV.Name = "buttonTroLaiQTV";
            this.buttonTroLaiQTV.Size = new System.Drawing.Size(137, 34);
            this.buttonTroLaiQTV.TabIndex = 8;
            this.buttonTroLaiQTV.Text = "TRỞ LẠI";
            this.buttonTroLaiQTV.UseVisualStyleBackColor = true;
            this.buttonTroLaiQTV.Click += new System.EventHandler(this.buttonTroLaiNV_Click);
            // 
            // fLoginQTV
            // 
            this.AcceptButton = this.buttonDangNhapQTV;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonTroLaiQTV;
            this.ClientSize = new System.Drawing.Size(580, 296);
            this.Controls.Add(this.buttonTroLaiQTV);
            this.Controls.Add(this.buttonDangNhapQTV);
            this.Controls.Add(this.tbxMatKhauQTV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxDangNhapQTV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "fLoginQTV";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN TRỊ VIÊN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxDangNhapQTV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxMatKhauQTV;
        private System.Windows.Forms.Button buttonDangNhapQTV;
        private System.Windows.Forms.Button buttonTroLaiQTV;
    }
}