using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.conn
{
    public class My_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57RHTFE;Initial Catalog=dbms_final_proj;Integrated Security=True");

        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if ((con.State == System.Data.ConnectionState.Closed))
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if ((con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
