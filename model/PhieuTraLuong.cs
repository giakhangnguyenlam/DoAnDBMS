using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.model
{
    public class PhieuTraLuong
    {
        //-- phieutraluong (tho_id/, thang/, sogiolamviec, tienluong)
        public int tho_id { get; set; }
        public DateTime thang { get; set; }
        public float sogiolamviec { get; set; }
        public float tienluong { get; set; }
    }
}
