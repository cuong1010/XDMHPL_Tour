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
                    item.isEdit = khach.isEdit;
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
                db.DoanKhaches.Add(doan);
                db.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                return "Có Lỗi xảy ra: " + e;
            }

        }
        public String CapNhatTien(CapNhatDoanKhachViewModel capnhat)
        {
            try
            {
                string[] stringSeparators = new string[] { ", " };
                List<String> listks = capnhat.DSKhachSan.Split(stringSeparators, StringSplitOptions.None).ToList();

                List<String> listpt = capnhat.DSPhuongTien.Split(stringSeparators, StringSplitOptions.None).ToList();

                List<String> listkhac = capnhat.DSKhac.Split(stringSeparators, StringSplitOptions.None).ToList();
                List<String> listan = capnhat.DSAn.Split(stringSeparators, StringSplitOptions.None).ToList();

                List<String> listtienks = capnhat.DSTienKS.Split(stringSeparators, StringSplitOptions.None).ToList();
                List<String> listtienan = capnhat.DSTienAn.Split(stringSeparators, StringSplitOptions.None).ToList();

                List<String> listtienpt = capnhat.DSTienPT.Split(stringSeparators, StringSplitOptions.None).ToList();

                List<String> listtienkhac = capnhat.DSTienKhac.Split(stringSeparators, StringSplitOptions.None).ToList();

                for (int i = 0; i < listks.Count; i++)
                {
                    String tenks = listks[i];
                    KhachSanTheoDoan ks = db.KhachSanTheoDoans.Where(c => c.DoanKhachId == capnhat.maDoan && c.TenKs == tenks).FirstOrDefault();
                    if (ks == null)
                    {
                        ks = new KhachSanTheoDoan();
                        ks.DoanKhachId = capnhat.maDoan;
                        ks.GiaTien = Int32.Parse(listtienks[i]);
                        ks.TenKs = listks[i];
                        db.KhachSanTheoDoans.Add(ks);
                        db.SaveChanges();
                    }
                    else
                    {
                        ks.TenKs = listks[i];
                        ks.GiaTien = Int32.Parse(listtienks[i]);
                        db.Entry(ks).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
                for (int i = 0; i < listan.Count; i++)
                {
                    String tenpt = listan[i];
                    TienAnTheoDoan ks = db.TienAnTheoDoans.Where(c => c.DoanKhachId == capnhat.maDoan && c.TenGoi == tenpt).FirstOrDefault();
                    if (ks == null)
                    {
                        ks = new TienAnTheoDoan();
                        ks.DoanKhachId = capnhat.maDoan;
                        ks.GiaTien = Int32.Parse(listtienan[i]);
                        ks.TenGoi = listan[i];
                        db.TienAnTheoDoans.Add(ks);
                        db.SaveChanges();
                    }
                    else
                    {
                        ks.GiaTien = Int32.Parse(listtienan[i]);
                        ks.TenGoi = listan[i];
                        db.Entry(ks).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
                for (int i = 0; i < listpt.Count; i++)
                {
                    String tenpt = listpt[i];
                    PhuongTienTheoDoan ks = db.PhuongTienTheoDoans.Where(c => c.DoanKhachId == capnhat.maDoan && c.TenPT == tenpt).FirstOrDefault();
                    if (ks == null)
                    {
                        ks = new PhuongTienTheoDoan();
                        ks.DoanKhachId = capnhat.maDoan;
                        ks.GiaTien = Int32.Parse(listtienpt[i]);
                        ks.TenPT = listpt[i];
                        db.PhuongTienTheoDoans.Add(ks);
                        db.SaveChanges();
                    }
                    else
                    {
                        ks.GiaTien = Int32.Parse(listtienpt[i]);
                        ks.TenPT = listpt[i];
                        db.Entry(ks).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
                for (int i = 0; i < listkhac.Count; i++)
                {
                    String ten = listkhac[i];
                    ChiPhiKhacTheoDoan ks = db.ChiPhiKhacTheoDoans.Where(c => c.DoanKhachId == capnhat.maDoan && c.TenGoi == ten).FirstOrDefault();
                    if (ks == null)
                    {
                        ks = new ChiPhiKhacTheoDoan();
                        ks.DoanKhachId = capnhat.maDoan;
                        ks.GiaTien = Int32.Parse(listtienkhac[i]);
                        ks.TenGoi = listkhac[i];
                        db.ChiPhiKhacTheoDoans.Add(ks);
                        db.SaveChanges();
                    }
                    else
                    {
                        ks.GiaTien = Int32.Parse(listtienkhac[i]);
                        ks.TenGoi = listkhac[i];
                        db.Entry(ks).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
                if (TinhTongTien(capnhat.maDoan)) return null;
                else return "Nhập Sai Số";
            }
            catch (Exception e)
            {
                return "Có Lỗi xảy ra:" + e;
            }
        }
        public bool TinhTongTien(int id)
        {
            DoanKhach doan = db.DoanKhaches.Find(id);
            int tong = 0;
            foreach (KhachSanTheoDoan item in db.KhachSanTheoDoans.Where(c => c.DoanKhachId == id))
            {
                tong += item.GiaTien;
            }
            foreach (TienAnTheoDoan item in db.TienAnTheoDoans.Where(c => c.DoanKhachId == id))
            {
                tong += item.GiaTien;
            }
            foreach (PhuongTienTheoDoan item in db.PhuongTienTheoDoans.Where(c => c.DoanKhachId == id))
            {
                tong += item.GiaTien;
            }
            foreach (ChiPhiKhacTheoDoan item in db.ChiPhiKhacTheoDoans.Where(c => c.DoanKhachId == id))
            {
                tong += item.GiaTien;
            }
            doan.TongChiPhi = tong;
            doan.isEdit = true;
            db.Entry(doan).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
        public CapNhatDoanKhachViewModel getThongTinChiPhi(int? id)
        {
            try
            {
                CapNhatDoanKhachViewModel result = new CapNhatDoanKhachViewModel();
                result.maDoan = id.Value;
                foreach (KhachSanTheoDoan item in db.KhachSanTheoDoans.Where(c => c.DoanKhachId == id))
                {
                    result.DSKhachSan += item.TenKs + ", ";
                    result.DSTienKS += item.GiaTien + ", ";
                }
                foreach (TienAnTheoDoan item in db.TienAnTheoDoans.Where(c => c.DoanKhachId == id))
                {
                    result.DSAn += item.TenGoi + ", ";
                    result.DSTienAn += item.GiaTien + ", ";
                }
                foreach (PhuongTienTheoDoan item in db.PhuongTienTheoDoans.Where(c => c.DoanKhachId == id))
                {
                    result.DSPhuongTien += item.TenPT + ", ";
                    result.DSTienPT += item.GiaTien + ", ";
                }
                foreach (ChiPhiKhacTheoDoan item in db.ChiPhiKhacTheoDoans.Where(c => c.DoanKhachId == id))
                {
                    result.DSKhac += item.TenGoi + ", ";
                    result.DSTienKhac += item.GiaTien + ", ";
                }

                result.DSAn = result.DSAn.Remove(result.DSAn.Length - 2);
                result.DSTienAn = result.DSTienAn.Remove(result.DSTienAn.Length - 2);
                result.DSKhac = result.DSKhac.Remove(result.DSKhac.Length - 2);
                result.DSKhachSan = result.DSKhachSan.Remove(result.DSKhachSan.Length - 2);
                result.DSPhuongTien = result.DSPhuongTien.Remove(result.DSPhuongTien.Length - 2);
                result.DSTienKhac = result.DSTienKhac.Remove(result.DSTienKhac.Length - 2);
                result.DSTienKS = result.DSTienKS.Remove(result.DSTienKS.Length - 2);
                result.DSTienPT = result.DSTienPT.Remove(result.DSTienPT.Length - 2);
                return result;
            }
            catch (Exception e)
            {
                CapNhatDoanKhachViewModel result = new CapNhatDoanKhachViewModel();
                result.maDoan = id.Value;
                return result;
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
                result.dstienan = db.TienAnTheoDoans.Where(c => c.DoanKhachId == id).ToList();
                result.dstienKs = db.KhachSanTheoDoans.Where(c => c.DoanKhachId == id).ToList();
                result.dstienpt = db.PhuongTienTheoDoans.Where(c => c.DoanKhachId == id).ToList();
                result.dstienkhac = db.ChiPhiKhacTheoDoans.Where(c => c.DoanKhachId == id).ToList();
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
        public List<ThongTinNhanVien> getListNhanVien(int? id)
        {
            try
            {
                List<ThongTinNhanVien> result = new List<ThongTinNhanVien>();
                List<NhanVienTheoDoan> ds = db.NhanVienTheoDoans.Where(c => c.idDoanKhach == id).ToList();
                foreach (NhanVienTheoDoan item in ds)
                {
                    ThongTinNhanVien nv = new ThongTinNhanVien();
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
