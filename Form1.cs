using DoAnDBMS.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmQuanLiKhachHang test = new FrmQuanLiKhachHang();
            //FrmThemDSThue test = new FrmThemDSThue();
            FrmThueXe test = new FrmThueXe();
            test.Show();

        }
    }
}
