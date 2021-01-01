using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.model
{
    public class ThanhToanCSX
    {
        //-- thanhtoancsx (bienso/, tho_id/, ngaygiogiaoxe/, thoigianthanhtoan/, sotien)
        public String bienso { get; set; }
        public int thoid { get; set; }
        public DateTime ngaygiogiaoxe { get; set; }
        public DateTime thoigianthanhtoan { get; set; }
        public float sotien { get; set; }

    }
}
