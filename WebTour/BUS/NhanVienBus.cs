using BusAndModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}