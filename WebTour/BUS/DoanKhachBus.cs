using BusAndModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTour.Models;

namespace BusAndModel.BUS
{
    public class DoanKhachBus
    {
        private Model1Container db = new Model1Container();
        public List<DoanKhachViewModel> getList()
        {
            try
            {
                List<DoanKhachViewModel> list = new List<DoanKhachViewModel>();
                var doanKhaches = db.DoanKhaches.ToList();
                foreach (var khach in doanKhaches)
                {
                    DoanKhachViewModel item = new DoanKhachViewModel();
                    item.maDoan = khach.Id;
                    item.soluong = khach.SLCho - getSoLuong(khach.Id);
                    item.tenDoan = khach.TenGoi;
                    item.tenTour = khach.Tour.TenGoi;
                    item.thongtin = khach.Tour.DacDiem;
                    item.ngayKhoiHanh = khach.NgayKhoiHanh;
                    item.ngayKetThuc = khach.NgayKetThuc;
                    list.Add(item);
                }
                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int getSoLuong(int id)
        {
            return db.DSKhachTheoDoans.Count(c => c.DoanKhachId == id);
        }
        public bool Dangky(DSKhachTheoDoan ds)
        {
            try
            {
                DoanKhach doan = db.DoanKhaches.Find(ds.DoanKhachId);
                int count = db.DSKhachTheoDoans.Count(c => c.DoanKhachId == ds.DoanKhachId);
                if (doan.SLCho > count)
                {
                    DSKhachTheoDoan result = db.DSKhachTheoDoans.Where(c => c.DoanKhachId == ds.DoanKhachId).ToList().Find(c => c.KhachHangId == ds.KhachHangId);
                    if (result == null)
                    {
                        db.DSKhachTheoDoans.Add(ds);
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public String getTenTour(int? id)
        {
            var doankhaches = db.DoanKhaches.Include(c => c.Tour).ToList();
            DoanKhach doan = doankhaches.Find(c => c.Id == id);
            return doan.Tour.TenGoi;
        }

        public String CreateDoan(DoanKhach doan)
        {
            try
            {
                if (doan.NgayKhoiHanh.Date < DateTime.Now.Date)
                {
                    return "Ngày khởi hành phải lớn hơn ngày hiện hành!!!";
                }
                doan.TongAn = 0;
                doan.TongKhac = 0;
                doan.TongKS = 0;
                doan.TongPT = 0;
                db.DoanKhaches.Add(doan);
                db.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                return "Có Lỗi xảy ra: " + e;
            }

        }
        public String CapNhatTien(DoanKhach doan)
        {
            try
            {
                if (doan.TongAn < 0 || doan.TongKhac < 0 || doan.TongKS < 0 || doan.TongPT < 0)
                {
                    return "Tổng tiền không được âm !!!!";
                }
                db.Entry(doan).State = EntityState.Modified;
                db.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                return "Có Lỗi xảy ra:" + e;
            }
        }
        public DoanKhachViewModel getDetail(int? id)
        {
            try
            {
                DoanKhachViewModel result = new DoanKhachViewModel();
                DoanKhach doan = db.DoanKhaches.Find(id);
                result.maDoan = doan.Id;
                result.soluong = doan.SLCho - getSoLuong(doan.Id);
                result.tenDoan = doan.TenGoi;
                result.tenTour = doan.Tour.TenGoi;
                result.thongtin = doan.Tour.DacDiem;
                result.ngayKhoiHanh = doan.NgayKhoiHanh;
                result.ngayKetThuc = doan.NgayKetThuc;
                result.danhsachkhach = getListKhachHang(id);
                result.nhanvien = getListNhanVien(id);
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<KhachHang> getListKhachHang(int? id)
        {
            try
            {
                List<KhachHang> result = new List<KhachHang>();
                List<DSKhachTheoDoan> ds = db.DSKhachTheoDoans.Where(c => c.DoanKhachId == id).ToList();
                foreach (DSKhachTheoDoan item in ds)
                {
                    result.Add(db.KhachHangs.Find(item.KhachHangId));
                }
                return result;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public List<NhanVienViewModel> getListNhanVien(int? id)
        {
            try
            {
                List<NhanVienViewModel> result = new List<NhanVienViewModel>();
                List<NhanVienTheoDoan> ds = db.NhanVienTheoDoans.Where(c => c.idDoanKhach == id).ToList();
                foreach (NhanVienTheoDoan item in ds)
                {
                    NhanVienViewModel nv = new NhanVienViewModel();
                    nv.tenNV = db.NhanViens.Find(item.idNhanVien).TenNhanVien;
                    nv.ChucVu = db.NhiemVus.Find(item.idNhiemVu).TenNhiemVu;
                    result.Add(nv);
                }
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
    }
}
