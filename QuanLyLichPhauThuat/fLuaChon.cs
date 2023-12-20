﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichPhauThuat
{
    public partial class fLuaChon : Form
    {
        public fLuaChon()
        {
            InitializeComponent();
        }

        private void BtnBS (object sender, EventArgs e)
        {
            fLoginBacSi f = new fLoginBacSi();
            this.Hide();    
            f.Show();
        }

        private void BtnNV (object sender, EventArgs e)
        {
            fLoginNhanVien f = new fLoginNhanVien();
            this.Hide();
            f.Show();
        }

        private void btnQTV_Click(object sender, EventArgs e)
        {
            fLoginQTV f = new fLoginQTV();
            this.Hide();
            f.Show();
        }
    }
}
