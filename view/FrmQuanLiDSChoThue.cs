using DoAnDBMS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDBMS.view
{
    public partial class FrmQuanLiDSChoThue : Form
    {
        public FrmQuanLiDSChoThue()
        {
            InitializeComponent();
        }
        QuanLiKhachHang quanLiKhachHang = new QuanLiKhachHang();
        QuanLiXe quanLiXe = new QuanLiXe();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string fname = txb_FirstName.Text;
            string lname = txb_LastName.Text;
            string cmnd = txb_CMND.Text;
            string loaixe;
            string hieuxe = txb_HieuXe.Text;
            if (cb_LoaiXe.SelectedIndex == 0)
            {
                loaixe = "Xe máy";
            }
            else
            {
                loaixe = "Xe hơi";
            }
            string bienso = txb_BienSo.Text;
            MemoryStream pic = new MemoryStream();
            DateTime ngayhd = dtp_NgayHopDong.Value;
            double trigiahd = Convert.ToDouble(txb_TriGiaHD.Text);
            DateTime ngaygiaoxe = dtp_NgayGiaoXe.Value;
            DateTime ngayhethanthue = dtp_NgayHetHanThue.Value;
            if (verif())
            {
                ptb_Anh.Image.Save(pic, ptb_Anh.Image.RawFormat);
                try
                {
                    quanLiXe.addChoThueXe(cmnd, bienso, loaixe, hieuxe, pic, ngayhd, ngaygiaoxe, ngayhethanthue, trigiahd);
                    MessageBox.Show("Đã thêm thành công", "Quản lí xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception a)
                {
                    MessageBox.Show(a.Message, "Quản lí xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fileds", "Quản lí xe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((dtp_NgayHetHanThue.Value - dtp_NgayGiaoXe.Value).TotalDays < 7)
            {
                MessageBox.Show("Xe được cho thuê phải nhiều hơn 7 ngày", "Xe Thuê Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Seclect Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                ptb_Anh.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("Xe_" + txb_HieuXe.Text + "_" + txb_BienSo.Text);
            if ((ptb_Anh.Image == null))
            {
                MessageBox.Show("Không có hình ảnh");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                ptb_Anh.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThemDSChoThue_Load(object sender, EventArgs e)
        {
            fillGridKhachHang(new SqlCommand("Select * From func_TatCaKhachHang ()"));
        }

        public void fillGridKhachHang(SqlCommand command)
        {
            dtgv_quanlikhachhang.ReadOnly = true;
            dtgv_quanlikhachhang.RowTemplate.Height = 80;
            dtgv_quanlikhachhang.DataSource = quanLiKhachHang.getKhachHang(command);
            dtgv_quanlikhachhang.AllowUserToAddRows = false;
        }

        private void dtgv_quanlikhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_CMND.Text = dtgv_quanlikhachhang.CurrentRow.Cells[0].Value.ToString();
            txb_FirstName.Text = dtgv_quanlikhachhang.CurrentRow.Cells[1].Value.ToString();
            txb_LastName.Text = dtgv_quanlikhachhang.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
