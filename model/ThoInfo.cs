using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDBMS.model
{
    public class ThoInfo: People 
    {
        //--tho_infos (userid/, fname, lname, hinhanh, chucvu)
        //Sử dụng kế thừa của lớp people
        public People people { get; set; }
        public int userid { get; set; }
        public MemoryStream hinhanh { get; set; }
        //chưa hiểu lắm chỗ này mình để chức vụ chỗ account lun rùi
        //public int chucvu { get; set; }

    }
}
