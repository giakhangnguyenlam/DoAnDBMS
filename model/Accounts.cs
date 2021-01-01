using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.view
{
    public class Accounts
    {
        // -- admin_accounts (userid/, uname, upasswd, vaitro)
        //-- tho_accounts(userid/, uname, upasswd, vaitro)
        public int userid { get; set; }
        public string uname { get; set; }
        public string upasswd { get; set; }
        public string vaitro { get; set; }

    }
}
