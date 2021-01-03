using DoAnDBMS.conn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.DAO
{
    public class QuanLiXe
    {
        My_DB mydb = new My_DB();
        public bool addChoThueXe(String cmnd, String bienso, String loaixe, String hieuxe, MemoryStream pic, DateTime ngayhd, DateTime ngaygiaoxe, DateTime ngayhethanthue, double trigiahd)
        {
            SqlCommand command = new SqlCommand("Exec pro_ThemXeVaoDanhSachChoThue @bienso , @loaixe , @hieuxe, @hinhanh, @oid, @ngayhd, @ngayhieuluc, @ngayhethan, @trigiahd", mydb.getConnection);
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            command.Parameters.Add("@loaixe", SqlDbType.VarChar).Value = loaixe;
            command.Parameters.Add("@hieuxe", SqlDbType.VarChar).Value = hieuxe;
            command.Parameters.Add("@hinhanh", SqlDbType.Image).Value = pic.ToArray();
            command.Parameters.Add("@oid", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@ngayhd", SqlDbType.Date).Value = ngayhd;
            command.Parameters.Add("@ngayhieuluc", SqlDbType.Date).Value = ngaygiaoxe;
            command.Parameters.Add("@ngayhethan", SqlDbType.Date).Value = ngayhethanthue;
            command.Parameters.Add("@trigiahd", SqlDbType.Money).Value = trigiahd;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool updateChoThueXe(String bienso, String loaixe, String hieuxe, MemoryStream pic, DateTime ngayhd, DateTime ngaygiaoxe, DateTime ngayhethanthue, double trigiahd)
        {
            SqlCommand command = new SqlCommand("Exec pro_ChinhSuaDanhSachChoThue @bienso, @loaixe, @hieuxe, @hinhanh, @ngayhd, @ngayhieuluc, @ngayhethan, @trigiahd", mydb.getConnection);
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            command.Parameters.Add("@loaixe", SqlDbType.VarChar).Value = loaixe;
            command.Parameters.Add("@hieuxe", SqlDbType.VarChar).Value = hieuxe;
            command.Parameters.Add("@hinhanh", SqlDbType.Image).Value = pic.ToArray();
            command.Parameters.Add("@ngayhd", SqlDbType.Date).Value = ngayhd;
            command.Parameters.Add("@ngayhieuluc", SqlDbType.Date).Value = ngaygiaoxe;
            command.Parameters.Add("@ngayhethan", SqlDbType.Date).Value = ngayhethanthue;
            command.Parameters.Add("@trigiahd", SqlDbType.Money).Value = trigiahd;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }



        public bool addThueXe(DateTime ngayhopdong, DateTime ngayhieuluc, DateTime ngayhethan, double trigiahd, String cid, String bienso)
        {
            SqlCommand command = new SqlCommand("Exec pro_ThemVaoDanhSachThue @ngayhd , @ngayhieuluc , @ngayhethan , @trigiahd , @cid , @bienso", mydb.getConnection);
            command.Parameters.Add("@ngayhd", SqlDbType.Date).Value = ngayhopdong;
            command.Parameters.Add("@ngayhieuluc", SqlDbType.Date).Value = ngayhieuluc;
            command.Parameters.Add("@ngayhethan", SqlDbType.Date).Value = ngayhethan;
            command.Parameters.Add("@trigiahd", SqlDbType.Money).Value = trigiahd;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = cid;
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getXe(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool addThanhToanHopDongThue(int sohd, String fname, String lname, DateTime thoigiantt, double sotien)
        {
            SqlCommand command = new SqlCommand("Exec pro_ThemThanhToanHopDongThue @sohd, @fname, @lname, @thoigiantt, @sotien", mydb.getConnection);
            command.Parameters.Add("@sohd", SqlDbType.Int).Value = sohd;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@thoigiantt", SqlDbType.DateTime).Value = thoigiantt;
            command.Parameters.Add("@sotien", SqlDbType.Money).Value = sotien;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool addThanhToanHopDongChoThue(int sohd, String fname, String lname, DateTime thoigiantt, double sotien)
        {
            SqlCommand command = new SqlCommand("Exec pro_ThemThanhToanHopDongChoThue @sohd, @fname, @lname, @thoigiantt, @sotien", mydb.getConnection);
            command.Parameters.Add("@sohd", SqlDbType.Int).Value = sohd;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@thoigiantt", SqlDbType.DateTime).Value = thoigiantt;
            command.Parameters.Add("@sotien", SqlDbType.Money).Value = sotien;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
