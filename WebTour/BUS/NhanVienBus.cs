using BusAndModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTour.Models;

namespace WebTour.BUS
{
    public class NhanVienBus
    {
        private Model1Container db = new Model1Container();
        public String PhanCong(NhanVienTheoDoan nv)
        {
            List<NhanVienTheoDoan>list= db.NhanVienTheoDoans.Where(c => c.idNhanVien == nv.idNhanVien).ToList();
            DateTime starttime = db.DoanKhaches.Find(nv.idDoanKhach).NgayKhoiHanh;
            DateTime endtime = db.DoanKhaches.Find(nv.idDoanKhach).NgayKetThuc;
            foreach (NhanVienTheoDoan item in list)
            {
                DoanKhach doan= db.DoanKhaches.Find(item.idDoanKhach);
                if (doan.NgayKhoiHanh.Date > starttime && endtime > doan.NgayKhoiHanh)
                {
                        return "Trùng Lịch!! chọn lại";
                }
                if (doan.NgayKhoiHanh < starttime && doan.NgayKetThuc > starttime)
                {
                        return "Trùng Lịch!!! chọn lại";
                }
                if (doan.NgayKhoiHanh == starttime)
                {
                    return "Trùng Lịch!!! chọn lại";
                }
                
            }
            db.NhanVienTheoDoans.Add(nv);
            db.SaveChanges();
            return null;
        }
        public NhanVienViewModel ThongTinNV(int? id)
        {
            try
            {
                NhanVienViewModel result = new NhanVienViewModel();
                NhanVien nv = db.NhanViens.Find(id);
                result.tenNV = nv.TenNhanVien;
                List<PhanCongViewModel> phancong = new List<PhanCongViewModel>();
                List<NhanVienTheoDoan> list = db.NhanVienTheoDoans.Where(c => c.idNhanVien == id).ToList();
                result.TinhTrang = "Rãnh Rỗi";
                foreach (NhanVienTheoDoan item in list)
                {
                    PhanCongViewModel pc = new PhanCongViewModel();
                    DoanKhach doan = db.DoanKhaches.Find(item.idDoanKhach);
                    pc.TenDoan = doan.TenGoi;
                    pc.TuNgay = doan.NgayKhoiHanh;
                    pc.DenNgay = doan.NgayKetThuc;
                    pc.ChucVu = db.NhiemVus.Find(item.idNhiemVu).TenNhiemVu;
                    pc.TenTour = db.Tours.Find(doan.TourId).TenGoi;
                    if(doan.NgayKhoiHanh.Date<=DateTime.Now.Date && doan.NgayKetThuc.Date >= DateTime.Now.Date)
                    {
                        result.TinhTrang = "Đang Hoạt Động Trong Đoàn";
                    }
                    phancong.Add(pc);
                }
                result.PhanCong = phancong;
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
           
        }
    }
}