namespace QuanLyLichPhauThuat
{
    partial class fLoginBacSi
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonDangNhapBacSi = new System.Windows.Forms.Button();
            this.buttonTroLaiBacSi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "QUẢN LÝ LỊCH PHẪU THUẬT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "TÊN ĐĂNG NHẬP";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "MẬT KHẨU";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(202, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(280, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // buttonDangNhapBacSi
            // 
            this.buttonDangNhapBacSi.Location = new System.Drawing.Point(223, 202);
            this.buttonDangNhapBacSi.Name = "buttonDangNhapBacSi";
            this.buttonDangNhapBacSi.Size = new System.Drawing.Size(137, 34);
            this.buttonDangNhapBacSi.TabIndex = 3;
            this.buttonDangNhapBacSi.Text = "ĐĂNG NHẬP";
            this.buttonDangNhapBacSi.UseVisualStyleBackColor = true;
            // 
            // buttonTroLaiBacSi
            // 
            this.buttonTroLaiBacSi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonTroLaiBacSi.Location = new System.Drawing.Point(366, 202);
            this.buttonTroLaiBacSi.Name = "buttonTroLaiBacSi";
            this.buttonTroLaiBacSi.Size = new System.Drawing.Size(137, 34);
            this.buttonTroLaiBacSi.TabIndex = 4;
            this.buttonTroLaiBacSi.Text = "TRỞ LẠI";
            this.buttonTroLaiBacSi.UseVisualStyleBackColor = true;
            this.buttonTroLaiBacSi.Click += new System.EventHandler(this.button3_Click);
            // 
            // fLoginBacSi
            // 
            this.AcceptButton = this.buttonDangNhapBacSi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.buttonTroLaiBacSi;
            this.ClientSize = new System.Drawing.Size(580, 296);
            this.Controls.Add(this.buttonTroLaiBacSi);
            this.Controls.Add(this.buttonDangNhapBacSi);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "fLoginBacSi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁC SĨ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxDangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox tbxMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonDangNhapBacSi;
        private System.Windows.Forms.Button buttonTroLaiBacSi;
    }
}

