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
    public partial class FrmQuanLiDSThueXe : Form
    {
        public FrmQuanLiDSThueXe()
        {
            InitializeComponent();
        }
        QuanLiKhachHang quanLiKhachHang = new QuanLiKhachHang();
        QuanLiXe quanLiXe = new QuanLiXe();
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txb_CMND.Text.Trim() == "" || txb_BienSo.Text.Trim() == "" || txb_TriGiaHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
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
                ptb_Anh.Image.Save(pic, ptb_Anh.Image.RawFormat);
                try
                {
                    quanLiXe.addThueXe(ngayhd, ngaygiaoxe, ngayhethanthue, trigiahd, cmnd, bienso);
                    MessageBox.Show("Thuê xe thành công", "Quản lí xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Quản lí xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void dtgv_quanlikhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_CMND.Text = dtgv_quanlikhachhang.CurrentRow.Cells[0].Value.ToString();
        }

        private void FrmThueXe_Load(object sender, EventArgs e)
        {
            fillGridKhachHang(new SqlCommand("Select * From func_TatCaKhachHang ()"));
            fillGridXe(new SqlCommand("Select * From func_XeChuaDuocThue()"));
        }
        public void fillGridXe(SqlCommand command)
        {
            dtgv_QuanLiThueXe.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dtgv_QuanLiThueXe.RowTemplate.Height = 80;
            dtgv_QuanLiThueXe.DataSource = quanLiXe.getXe(command);
            picCol = (DataGridViewImageColumn)dtgv_QuanLiThueXe.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtgv_QuanLiThueXe.AllowUserToAddRows = false;
        }

        public void fillGridKhachHang(SqlCommand command)
        {
            dtgv_quanlikhachhang.ReadOnly = true;
            dtgv_quanlikhachhang.RowTemplate.Height = 80;
            dtgv_quanlikhachhang.DataSource = quanLiKhachHang.getKhachHang(command);
            dtgv_quanlikhachhang.AllowUserToAddRows = false;
        }

        private void dtgv_QuanLiThueXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_BienSo.Text = dtgv_QuanLiThueXe.CurrentRow.Cells[0].Value.ToString();
            if (dtgv_QuanLiThueXe.CurrentRow.Cells[1].Value.ToString() == "Xe hoi")
            {
                cb_LoaiXe.SelectedIndex = 1;
            }
            else
            {
                cb_LoaiXe.SelectedIndex = 0;
            }
            txb_HieuXe.Text = dtgv_QuanLiThueXe.CurrentRow.Cells[2].Value.ToString();
            byte[] pic = (byte[])dtgv_QuanLiThueXe.CurrentRow.Cells[3].Value;
            MemoryStream picture = new MemoryStream(pic);
            ptb_Anh.Image = Image.FromStream(picture);
            dtp_NgayHetHanThue.Value = (DateTime)dtgv_QuanLiThueXe.CurrentRow.Cells[4].Value;
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            fillGridKhachHang(new SqlCommand("Select * From func_TatCaKhachHang ()"));
            fillGridXe(new SqlCommand("Select * From func_XeChuaDuocThue()"));
        }

        private void btn_SearchXe_Click(object sender, EventArgs e)
        {
            String hieuxe = txb_SearchXe.Text;
            fillGridXe(new SqlCommand("Select * From func_TimKiemXeChuaDuocThue('" + hieuxe+"')"));
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            fillGridKhachHang(new SqlCommand("Select * from func_TimKiemKhachHang('" + txb_Search.Text.Trim() + "')"));
        }
    }
}
