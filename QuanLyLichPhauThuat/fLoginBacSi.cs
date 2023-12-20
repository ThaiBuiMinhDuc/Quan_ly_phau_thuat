using System;
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
    public partial class fLoginBacSi : Form
    {
        public fLoginBacSi()
        {
            InitializeComponent();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fLuaChon f= new fLuaChon();
            this.Hide();
            f.Show();
        }
    }
}
