using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.model
{
    public class Xe
    {
        //-- xe (bienso/, loaixe, hieuxe, hinhanh, cosan)
        public String bienso { get; set; }
        public String loaixe { get; set; }
        public String hieuxe { get; set; }
        public MemoryStream hinhanh { get; set; }
        public int cosan { get; set; }
    }
}
