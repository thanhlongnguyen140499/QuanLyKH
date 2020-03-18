using _102170286_NguyenThanhLong_17TCLC2.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102170286_NguyenThanhLong_17TCLC2.DAL
{
    class QL_DAL
    {
        public DBHelper db { get; set; }
        public QL_DAL()
        {
            this.db = new DBHelper();
        }
        public IList ShowTest_DAL(string text)
        {
            return db.qlkhdv.KHs.Where(p => p.HoTen == text).Select( p => new { p.MSKH,p.HoTen,p.GioiTinh,p.DV.TenDichVu,p.DV.DiemTichLuy,p.DV.NgayGiaoDich }).ToList();
        }
        public void Update_DAL()
        {

        }
        public void Add_DAL(KhachHang kh)
        {
            KhachHang newKH = new KhachHang()
            {
                MSKH = kh.MSKH,
                HoTen = kh.HoTen,
                GioiTinh = kh.GioiTinh
            };
            db.qlkhdv.KHs.Add(newKH);
            db.qlkhdv.SaveChanges();
        }
        
        public void Del_DAL(string mskh)
        {
            KhachHang delKH = db.qlkhdv.KHs.Where(p => p.MSKH == mskh).FirstOrDefault();
            db.qlkhdv.KHs.Remove(delKH);
            db.qlkhdv.SaveChanges();
        }
        public IList Search_DAL(string text)
        {
            return db.qlkhdv.KHs.Where(p => p.HoTen == text).Select(p => new { p.MSKH, p.HoTen, p.GioiTinh, p.DV.TenDichVu, p.DV.DiemTichLuy, p.DV.NgayGiaoDich }).ToList();
        }
        public void Sort_DAL(DataGridView dt,string text)
        {
            if (text == "HoTen")
            {
                dt.DataSource = db.qlkhdv.KHs.OrderBy(x => x.HoTen).Select(p => new { p.MSKH, p.HoTen, p.GioiTinh, p.DV.TenDichVu, p.DV.DiemTichLuy, p.DV.NgayGiaoDich }).ToList();
            }
            else if (text == "MSKH")
            {
                dt.DataSource = db.qlkhdv.KHs.OrderBy(x => x.MSKH).Select(p => new { p.MSKH, p.HoTen, p.GioiTinh, p.DV.TenDichVu, p.DV.DiemTichLuy, p.DV.NgayGiaoDich }).ToList();
            }
        }

        public KhachHang getKH(string mskh)
        {
            KhachHang kh = new KhachHang();
            kh = db.qlkhdv.KHs.Where(p => p.MSKH == mskh).FirstOrDefault();
            return kh;
        }
    }
}
