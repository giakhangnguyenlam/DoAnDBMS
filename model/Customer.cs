using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.model
{
    public class Customer:People
    {
        //-- khachhang (cid/, fname, lname)
        public People people { get; set; }
        public String cid { get; set; }
    }
}
