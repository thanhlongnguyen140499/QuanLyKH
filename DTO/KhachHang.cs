using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102170286_NguyenThanhLong_17TCLC2.DTO
{
    public class KhachHang
    {
        [Key][Required]
        public string MSKH { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }

        [ForeignKey("HoTen")]
        public virtual DichVu DV { get; set; }

        public static bool CompareHoTen(object o1,object o2)
        {
            if (String.Compare( ((KhachHang)o1).HoTen, ((KhachHang)o2).HoTen ) > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
