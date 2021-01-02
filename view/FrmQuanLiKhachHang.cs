using DoAnDBMS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDBMS.view
{
    public partial class FrmQuanLiKhachHang : Form
    {
        public FrmQuanLiKhachHang()
        {
            InitializeComponent();
        }
        QuanLiKhachHang quanLiKhachHang = new QuanLiKhachHang(); 
        private void btn_Them_Click(object sender, EventArgs e)
        {
            String cmnd = txb_CMND.Text.Trim();
            String fname = txb_FirstName.Text.Trim();
            String lname = txb_lname.Text.Trim();

            if (cmnd == "" || fname == "" || lname == "")
            {
                MessageBox.Show("Vui lòng điền  đủ thông tin");
            }
            else
            {
                try
                {
                    quanLiKhachHang.insertKhachHang(cmnd, fname, lname);
                    MessageBox.Show("Thêm khách hàng thành công", "Quản lí khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception abc)
                {
                    MessageBox.Show(abc.Message, "Quản lí khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void fillGrid(SqlCommand command)
        {
            dtgv_quanlikhachhang.ReadOnly = true;
            dtgv_quanlikhachhang.RowTemplate.Height = 80;
            dtgv_quanlikhachhang.DataSource = quanLiKhachHang.getKhachHang(command);
            dtgv_quanlikhachhang.AllowUserToAddRows = false;
        }

        private void FrmQuanLiKhachHang_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("Select * From func_TatCaKhachHang ()"));
        }

        private void dtgv_quanlikhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_CMND.Text = dtgv_quanlikhachhang.CurrentRow.Cells[0].Value.ToString();
            txb_FirstName.Text = dtgv_quanlikhachhang.CurrentRow.Cells[1].Value.ToString();
            txb_lname.Text = dtgv_quanlikhachhang.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            String cmnd = txb_CMND.Text.Trim();
            if (cmnd == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                if (quanLiKhachHang.deleteKhachHang(cmnd))
                {
                    MessageBox.Show("Xóa khách hàng thành công", "Quản lí khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Quản lí khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("Select * From func_TatCaKhachHang ()"));
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            String cmnd = txb_CMND.Text.Trim();
            String fname = txb_FirstName.Text.Trim();
            String lname = txb_lname.Text.Trim();

            if (cmnd == "" || fname == "" || lname == "")
            {
                MessageBox.Show("Vui lòng điền  đủ thông tin");
            }
            else
            {
                if (quanLiKhachHang.updateKhachHang(cmnd, fname, lname))
                {
                    MessageBox.Show("Chỉnh sửa khách hàng thành công", "Quản lí khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa không thành công", "Quản lí khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("Select * from func_TimKiemKhachHang('" + txb_Search.Text.Trim() + "')"));
        }
    }
}
