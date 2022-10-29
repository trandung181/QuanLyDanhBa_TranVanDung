using QuanLyDanhBaSInhVien.Model;
using QuanLyDanhBaSInhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBaSInhVien.Service
{
    class LienLacService
    {
        public enum KetQua
        {
            f = 0,
            t = 1,
        }
        public static List<LienLacViewModel> getList()
        {
            var db = new AppDBContext();
            var rs = db.LienLacs.Select(e => new LienLacViewModel { MaLienLac = e.MaLienLac, TenGoi = e.TenGoi, Email = e.Email, MaNhom = e.MaNhom, DiaChi = e.DiaChi, SoDienThoai = e.SoDienThoai, }).ToList();
            return rs;
        }

        public static List<LienLacViewModel> getList(int MaNhom)
        {
            var db = new AppDBContext();
            var rs = db.LienLacs.Where(e => e.MaNhom == MaNhom).Select(e => new LienLacViewModel { MaLienLac = e.MaLienLac, TenGoi = e.TenGoi, Email = e.Email, MaNhom = e.MaNhom, DiaChi = e.DiaChi, SoDienThoai = e.SoDienThoai, }).ToList();
            return rs;
        }
        public static KetQua AddLienLac(LienLac ct)
        {
            var db = new AppDBContext();

            db.LienLacs.Add(ct);
            db.SaveChanges();
            return KetQua.t;
        }
        public static KetQua DeleteLienLac(LienLacViewModel ctn)
        {
            var db = new AppDBContext();
            var lienlac = db.LienLacs.Where(e => e.MaLienLac == ctn.MaLienLac).FirstOrDefault();
            db.LienLacs.Remove(lienlac);
            db.SaveChanges();
            return KetQua.t;
        }

    }
}
