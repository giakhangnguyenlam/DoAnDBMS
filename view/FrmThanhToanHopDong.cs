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
    public partial class FrmThanhToanHopDong : Form
    {
        public FrmThanhToanHopDong()
        {
            InitializeComponent();
        }
        QuanLiXe quanLiXe = new QuanLiXe();
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

        private void FrmThanhToanHopDong_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("Select * From func_BangThanhToan()"));
        }
        public void fillGrid(SqlCommand command)
        {
            dtgv_HopDong.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dtgv_HopDong.RowTemplate.Height = 80;
            dtgv_HopDong.DataSource = quanLiXe.getXe(command);
            picCol = (DataGridViewImageColumn)dtgv_HopDong.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtgv_HopDong.AllowUserToAddRows = false;
        }

        private void dtgv_HopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_CMND.Text = dtgv_HopDong.CurrentRow.Cells[0].Value.ToString();
            txb_FirstName.Text = dtgv_HopDong.CurrentRow.Cells[1].Value.ToString();
            txb_LastName.Text = dtgv_HopDong.CurrentRow.Cells[2].Value.ToString();
            if (dtgv_HopDong.CurrentRow.Cells[3].Value.ToString() == "Xe hoi")
            {
                cb_LoaiXe.SelectedIndex = 1;
            }
            else
            {
                cb_LoaiXe.SelectedIndex = 0;
            }
            txb_HieuXe.Text = dtgv_HopDong.CurrentRow.Cells[4].Value.ToString();
            txb_BienSo.Text = dtgv_HopDong.CurrentRow.Cells[5].Value.ToString();
            byte[] pic = (byte[])dtgv_HopDong.CurrentRow.Cells[6].Value;
            MemoryStream picture = new MemoryStream(pic);
            ptb_Anh.Image = Image.FromStream(picture);
            dtp_NgayHopDong.Value = (DateTime)dtgv_HopDong.CurrentRow.Cells[7].Value;
            txb_TriGiaHD.Text = dtgv_HopDong.CurrentRow.Cells[8].Value.ToString();
            dtp_NgayGiaoXe.Value = (DateTime)dtgv_HopDong.CurrentRow.Cells[9].Value;
            dtp_NgayHetHanThue.Value = (DateTime)dtgv_HopDong.CurrentRow.Cells[10].Value;
            if (dtgv_HopDong.CurrentRow.Cells[11].Value.ToString() == "1")
            {
                cb_loaihopdong.SelectedIndex = 1;
            }
            else
            {
                cb_loaihopdong.SelectedIndex = 0;
            }
            txb_SoHD.Text = dtgv_HopDong.CurrentRow.Cells[12].Value.ToString();
        }

        private void btn_TraXe_Click(object sender, EventArgs e)
        {
            if (txb_CMND.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thanh toán hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int sohd = int.Parse(txb_SoHD.Text);
                String fname = txb_FirstName.Text;
                String lname = txb_LastName.Text;
                DateTime thoigiantt = dtp_NgayTraXe.Value;
                double sotien = double.Parse(txb_TriGiaHD.Text);
                if (cb_loaihopdong.SelectedIndex == 0)
                {
                    try
                    {
                        quanLiXe.addThanhToanHopDongThue(sohd, fname, lname, thoigiantt, sotien);
                        MessageBox.Show("Thanh toán thành công", "Thanh toán hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message, "Thanh toán hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        quanLiXe.addThanhToanHopDongChoThue(sohd, fname, lname, thoigiantt, sotien);
                        MessageBox.Show("Thanh toán thành công", "Thanh toán hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message, "Thanh toán hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("Select * From func_BangThanhToan()"));
        }
    }
}
