using BusAndModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTour.Models;

namespace WebTour.BUS
{
    public class ThongKeBus
    {
        private Model1Container db = new Model1Container();
        public ThongKeTheoThoiGianViewModel<DoanKhach> TkDoanKhach(DateTime from, DateTime to)
        {
            try
            {
                ThongKeTheoThoiGianViewModel<DoanKhach> result = new ThongKeTheoThoiGianViewModel<DoanKhach>();
                List<DoanKhach> list = db.DoanKhaches.Where(c => c.NgayKetThuc >= from && c.NgayKetThuc <= to).ToList();
                result.from = from;
                result.to = to;
                result.danhsach = list;
                int sum = 0;
                foreach (DoanKhach item in list)
                {
                    sum += item.TongChiPhi;
                }
                result.Tong = sum;
                return result;
            }
            catch (Exception e) { return null; }
        }
        public ThongKeTheoThoiGianViewModel<KhachSanTheoDoan> TkKhachSan(DateTime from, DateTime to)
        {
            try
            {
                ThongKeTheoThoiGianViewModel<KhachSanTheoDoan> result = new ThongKeTheoThoiGianViewModel<KhachSanTheoDoan>();
                List<DoanKhach> list = db.DoanKhaches.Where(c => c.NgayKetThuc >= from && c.NgayKetThuc <= to).ToList();
                result.from = from;
                result.to = to;
                List<KhachSanTheoDoan> resultks = new List<KhachSanTheoDoan>();
                int sum = 0;
                foreach (DoanKhach item in list)
                {
                    List<KhachSanTheoDoan> listks = db.KhachSanTheoDoans.Where(c => c.DoanKhachId == item.Id).ToList();
                    foreach (KhachSanTheoDoan i in listks)
                    {
                        resultks.Add(i);
                        sum += i.GiaTien;
                    }

                }
                result.danhsach = resultks;
                result.Tong = sum;
                return result;
            }
            catch (Exception e) { return null; }
        }
        public ThongKeTheoThoiGianViewModel<TienAnTheoDoan> TkTienAn(DateTime from, DateTime to)
        {
            try
            {
                ThongKeTheoThoiGianViewModel<TienAnTheoDoan> result = new ThongKeTheoThoiGianViewModel<TienAnTheoDoan>();
                List<DoanKhach> list = db.DoanKhaches.Where(c => c.NgayKetThuc >= from && c.NgayKetThuc <= to).ToList();
                result.from = from;
                result.to = to;
                List<TienAnTheoDoan> resultks = new List<TienAnTheoDoan>();
                int sum = 0;
                foreach (DoanKhach item in list)
                {
                    List<TienAnTheoDoan> listks = db.TienAnTheoDoans.Where(c => c.DoanKhachId == item.Id).ToList();
                    foreach (TienAnTheoDoan i in listks)
                    {
                        resultks.Add(i);
                        sum += i.GiaTien;
                    }

                }
                result.danhsach = resultks;
                result.Tong = sum;
                return result;
            }
            catch (Exception e) { return null; }
        }
        public ThongKeTheoThoiGianViewModel<PhuongTienTheoDoan> TkPhuongTien(DateTime from, DateTime to)
        {
            try
            {
                ThongKeTheoThoiGianViewModel<PhuongTienTheoDoan> result = new ThongKeTheoThoiGianViewModel<PhuongTienTheoDoan>();
                List<DoanKhach> list = db.DoanKhaches.Where(c => c.NgayKetThuc >= from && c.NgayKetThuc <= to).ToList();
                result.from = from;
                result.to = to;
                List<PhuongTienTheoDoan> resultks = new List<PhuongTienTheoDoan>();
                int sum = 0;
                foreach (DoanKhach item in list)
                {
                    List<PhuongTienTheoDoan> listks = db.PhuongTienTheoDoans.Where(c => c.DoanKhachId == item.Id).ToList();
                    foreach (PhuongTienTheoDoan i in listks)
                    {
                        resultks.Add(i);
                        sum += i.GiaTien;
                    }

                }
                result.danhsach = resultks;
                result.Tong = sum;
                return result;
            }
            catch (Exception e) { return null; }
        }
        public ThongKeTheoThoiGianViewModel<ThongKeNhanVienViewModel> TkNhanVien(DateTime from, DateTime to)
        {
            try
            {
                ThongKeTheoThoiGianViewModel<ThongKeNhanVienViewModel> result = new ThongKeTheoThoiGianViewModel<ThongKeNhanVienViewModel>();
                List<DoanKhach> list = db.DoanKhaches.Where(c => c.NgayKetThuc >= from && c.NgayKetThuc <= to).ToList();
                result.from = from;
                result.to = to;
                List<NhanVienTheoDoan> listnv = new List<NhanVienTheoDoan>();
                List<ThongKeNhanVienViewModel> resultnv = new List<ThongKeNhanVienViewModel>();
                foreach (DoanKhach item in list)
                {
                    List<NhanVienTheoDoan> listks = db.NhanVienTheoDoans.Where(c => c.idDoanKhach == item.Id).ToList();
                    foreach (NhanVienTheoDoan i in listks)
                    {
                        listnv.Add(i);
                    }
                }
                foreach(NhanVien nv in db.NhanViens.ToList())
                {
                    ThongKeNhanVienViewModel tk = new ThongKeNhanVienViewModel();
                    tk.SoLan=listnv.Count(c => c.idNhanVien == nv.Id);
                    tk.Id = nv.Id;
                    tk.TenNV = nv.TenNhanVien;
                    resultnv.Add(tk);
                }
                result.danhsach = resultnv;
                return result;
            }
            catch (Exception e) { return null; }
        }
    }
}