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
            FrmQuanLiKhachHang test = new FrmQuanLiKhachHang();
            //FrmThemDSThue test = new FrmThemDSThue();
            //FrmThueXe test = new FrmThueXe();
            //FrmThanhToanHopDong test = new FrmThanhToanHopDong();
            test.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmQuanLiDSChoThue test = new FrmQuanLiDSChoThue();
            test.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmQuanLiDSThueXe test = new FrmQuanLiDSThueXe();
            test.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmThanhToanHopDong test = new FrmThanhToanHopDong();
            test.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmQuanLiHopDong test = new FrmQuanLiHopDong();
            test.Show();
        }
    }
}
