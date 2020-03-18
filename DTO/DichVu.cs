using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102170286_NguyenThanhLong_17TCLC2.DTO
{
    public class DichVu
    {
        [Key][Required]
        public string HoTen { get; set; }
        public string TenDichVu { get; set; }
        public int DiemTichLuy { get; set; }
        public DateTime NgayGiaoDich { get; set; }

        public virtual ICollection<KhachHang> KHs { get; set; }
    }
}
