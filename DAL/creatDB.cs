using _102170286_NguyenThanhLong_17TCLC2.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102170286_NguyenThanhLong_17TCLC2.DAL
{
    class creatDB : CreateDatabaseIfNotExists<QuanLyKH_DV>
    {
        public creatDB() { }
        public creatDB crDB { get; set; }
        protected override void Seed(QuanLyKH_DV context)
        {
            //base.Seed(context);
            context.KHs.Add( new KhachHang {MSKH = "MSKH01",HoTen="Long A",GioiTinh= true });
            context.DVs.Add(new DichVu { HoTen = "Long A",DiemTichLuy=1,TenDichVu="Bảo dưỡng", NgayGiaoDich = Convert.ToDateTime("30/11/2019") });
            context.KHs.Add(new KhachHang { MSKH = "MSKH02", HoTen = "Long B", GioiTinh = false });
            context.DVs.Add(new DichVu { HoTen = "Long B", DiemTichLuy = 2, TenDichVu = "Sửa Xe", NgayGiaoDich = Convert.ToDateTime("20/11/2019") });
            context.KHs.Add(new KhachHang { MSKH = "MSKH03", HoTen = "Long C", GioiTinh = true });
            context.DVs.Add(new DichVu { HoTen = "Long C", DiemTichLuy = 3, TenDichVu = "Rửa Xe", NgayGiaoDich = Convert.ToDateTime("28/11/2019") });
            context.KHs.Add(new KhachHang { MSKH = "MSKH04", HoTen = "Long D", GioiTinh = false });
            context.DVs.Add(new DichVu { HoTen = "Long D", DiemTichLuy = 1, TenDichVu = "Rửa Xe", NgayGiaoDich = Convert.ToDateTime("11/11/2019") });
        }
    }
}
