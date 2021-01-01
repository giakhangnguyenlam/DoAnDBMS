using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.model
{
    public class BangChamCong
    {
        //-- bangchamcong (tho_id/, thoigianvaolam/, thoigiantanlam)
        public int tho_id { get; set; }
        public DateTime thoigianvaolam { get; set; }
        public DateTime thoigiantanlam { get; set; }
    }
}
