using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.model
{
    public class ChiTietHopDong
    {
        //-- chitiethd (sohd/, loaihd, ngayhd, ngayhieuluc, ngayhethan, trigiahd)
        public int sohd { get; set; }
        public int loaihd { get; set; }
        public DateTime ngayhd {get;set;}
        public DateTime ngayhieuluc { get; set; }
        public DateTime ngayhethan { get; set; }
        public float trigiahd { get; set; }

    }
}
