using DoAnDBMS.conn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.DAO
{
    public class QuanLiKhachHang
    {
        My_DB mydb = new My_DB();
        public bool insertKhachHang(String cmnd, String fname, String lname)
        {
            SqlCommand command = new SqlCommand("exec pro_ThemKhachHang @cmnd, @fname, @lname", mydb.getConnection);
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;

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

        public bool updateKhachHang(String cmnd, String fname, String lname)
        {
            SqlCommand command = new SqlCommand("exec pro_ChinhSuaKhachHang @cmnd, @fname, @lname", mydb.getConnection);
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;

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


        public bool deleteKhachHang(String cmnd)
        {
            SqlCommand command = new SqlCommand("exec pro_XoaKhachHang @cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = cmnd;
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

        public DataTable getKhachHang(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }    
}
