using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.model
{
    public class ThanhToanHopDong
    {
        //-- thanhtoanhd (sohd/, fname/, lname/, thoigiantt/, sotien)
        public int sohd { get; set; }
        public String fname { get; set; }
        public String lname { get; set; }
        public DateTime thoigiantt { get; set; }
        public float Sotien { get; set; }
    }
}
