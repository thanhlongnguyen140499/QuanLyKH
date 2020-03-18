using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102170286_NguyenThanhLong_17TCLC2.DAL
{
    class DBHelper
    {
        public QuanLyKH_DV qlkhdv { get; set; }
        public DBHelper()
        {
            this.qlkhdv = new QuanLyKH_DV();
        }
    }
}
