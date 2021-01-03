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
    public partial class FrmQuanLiHopDong : Form
    {
        public FrmQuanLiHopDong()
        {
            InitializeComponent();
        }
        QuanLiXe quanLiXe = new QuanLiXe();
        private void FrmQuanLiHopDong_Load(object sender, EventArgs e)
        {
            double tongsotien = 0;
            fillGrid(new SqlCommand("Select * From dbo.thanhtoanhd"));
            for (int i = 0; i < dtgv_HopDong.Rows.Count; i++)
            {
                tongsotien += double.Parse(dtgv_HopDong.Rows[i].Cells[4].Value.ToString());
            }
            //lb_TongDoanhThu.Text = query;
            lb_TongDoanhThu.Text = "Tổng số tiền:" + tongsotien.ToString();
        }
        public void fillGrid(SqlCommand command)
        {
            dtgv_HopDong.ReadOnly = true;
            dtgv_HopDong.RowTemplate.Height = 80;
            dtgv_HopDong.DataSource = quanLiXe.getXe(command);
            dtgv_HopDong.AllowUserToAddRows = false;
        }

        private void btn_SaveToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp =
                 new Microsoft.Office.Interop.Excel.Application();
            int i = 0;
            int j = 0;
            Microsoft.Office.Interop.Excel._Workbook ExcelBook;
            Microsoft.Office.Interop.Excel._Worksheet ExcelSheet;
            ExcelBook = (Microsoft.Office.Interop.Excel._Workbook)ExcelApp.Workbooks.Add(1);
            ExcelSheet = (Microsoft.Office.Interop.Excel._Worksheet)ExcelBook.ActiveSheet;

            for (i = 1; i <= this.dtgv_HopDong.Columns.Count; i++)
            {
                ExcelSheet.Cells[1, i] = this.dtgv_HopDong.Columns[i - 1].HeaderText;
            }
            string bdate;
            //export data
            for (i = 1; i <= this.dtgv_HopDong.RowCount; i++)
            {
                for (j = 1; j <= dtgv_HopDong.Columns.Count; j++)
                {
                    try
                    {
                        ExcelSheet.Cells[i + 1, j] = dtgv_HopDong.Rows[i - 1].Cells[j - 1].Value;
                        if (j == 5 || j == 7)
                        {

                            bdate = dtgv_HopDong.Rows[i].Cells[j].Value.ToString();
                            ExcelSheet.Cells[i + 1, j] = bdate;

                        }
                    }
                    catch
                    {


                    }
                }
            }
            ExcelSheet.Cells[dtgv_HopDong.RowCount + 1, dtgv_HopDong.Columns.Count + 1].Value = "Tong doanh thu";
            ExcelSheet.Cells[dtgv_HopDong.RowCount + 2, dtgv_HopDong.Columns.Count + 1].Value = lb_TongDoanhThu.Text;
            ExcelApp.Visible = true;
            ExcelSheet = null;
            ExcelBook = null;
            ExcelApp = null;
        }
    }
}
