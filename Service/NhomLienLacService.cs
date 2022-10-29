using QuanLyDanhBaSInhVien.Model;
using QuanLyDanhBaSInhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBaSInhVien.Service
{
    class NhomLienLacService
    {
        public enum Ketqua
        {
            f = 0,
            t = 1,
        }
        public static List<NhomLienLacViewModel> getList()
        {
            var db = new AppDBContext();
            var rs = db.NhomLienLacs.Select(e => new NhomLienLacViewModel { MaNhom = e.MaNhom, TenNhom = e.TenNhom, }).ToList();
            return rs;
        }
        public static Ketqua AddNhomLienLac(NhomLienLac nll)
        {
            var db = new AppDBContext();
            db.NhomLienLacs.Add(nll);
            db.SaveChanges();
            return Ketqua.t;
        }
        public static Ketqua DeleteNhopLienLac(NhomLienLacViewModel lh)
        {
            var db = new AppDBContext();
            var nhomLienLac = db.NhomLienLacs.Where(e => e.MaNhom == lh.MaNhom).FirstOrDefault();
            var lienLac = db.LienLacs.Where(e => e.MaLienLac == lh.MaNhom).FirstOrDefault();
            if (lienLac == null)
            {
                db.NhomLienLacs.Remove(nhomLienLac);
                db.SaveChanges();
                return Ketqua.t;
            }
            return Ketqua.f;
        }
    }
}
