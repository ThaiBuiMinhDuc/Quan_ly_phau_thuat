namespace QuanLyLichPhauThuat
{
    partial class fLuaChon
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
            this.btnBS = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnQTV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng chọn vai trò đăng nhập";
            // 
            // btnBS
            // 
            this.btnBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBS.Location = new System.Drawing.Point(15, 69);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(124, 30);
            this.btnBS.TabIndex = 1;
            this.btnBS.Text = "Bác sĩ";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.BtnBS);
            // 
            // btnNV
            // 
            this.btnNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNV.Location = new System.Drawing.Point(157, 69);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(124, 30);
            this.btnNV.TabIndex = 2;
            this.btnNV.Text = "Nhân viên";
            this.btnNV.UseVisualStyleBackColor = true;
            this.btnNV.Click += new System.EventHandler(this.BtnNV);
            // 
            // btnQTV
            // 
            this.btnQTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQTV.Location = new System.Drawing.Point(300, 69);
            this.btnQTV.Name = "btnQTV";
            this.btnQTV.Size = new System.Drawing.Size(124, 30);
            this.btnQTV.TabIndex = 3;
            this.btnQTV.Text = "Quản trị";
            this.btnQTV.UseVisualStyleBackColor = true;
            this.btnQTV.Click += new System.EventHandler(this.btnQTV_Click);
            // 
            // fLuaChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 149);
            this.Controls.Add(this.btnQTV);
            this.Controls.Add(this.btnNV);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.label1);
            this.Name = "fLuaChon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LuaChon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnQTV;
    }
}