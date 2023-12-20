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
    public partial class fLoginQTV : Form
    {
        public fLoginQTV()
        {
            InitializeComponent();
        }

        private void buttonTroLaiNV_Click(object sender, EventArgs e)
        {
            fLuaChon f = new fLuaChon();
            this.Hide();
            f.Show();
        }
    }
}
