using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.model
{
    public class ThanhToanVeXe
    {
        //-- thanhtoanvexe (bienso/, ngaygiovaoben/, thoigianthanhtoan/, sotien)
        public String bienso { get; set; }
        public DateTime ngaygiovaoben { get; set; }
        public DateTime thoigianthanhtoan { get; set; }
        public float sotien { get; set; }

    }
}
