using BusAndModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTour.Models
{
    public class DoanKhachViewModel
    {
        [Display(Name = "Tên Tour")]
        public string tenTour { get; set; }
        [Display(Name = "Tên Đoàn")]
        public string tenDoan { get; set; }

  
        [Display(Name = "Mã Đoàn")]
        public int maDoan { get; set; }

        [Display(Name = "Ngày Khởi Hành")]
        public DateTime ngayKhoiHanh { get; set; }

   
        [Display(Name = "Ngày Kết Thúc")]
        public DateTime ngayKetThuc { get; set; }
        [Display(Name = "Thông tin")]
        public string thongtin { get; set; }

        [Display(Name = "Số lượng còn lại")]
        public int soluong { get; set; }
        public List<KhachHang> danhsachkhach { get; set; }
        public List<ThongTinNhanVien> nhanvien { get; set; }
        public List<KhachSanTheoDoan> dstienKs { get; set; }
        public List<ChiPhiKhacTheoDoan> dstienkhac { get; set; }
        public List<PhuongTienTheoDoan> dstienpt { get; set; }
        public List<TienAnTheoDoan> dstienan { get; set; }
        public bool isEdit { get; set; }
    }
    public class ThongTinNhanVien
    {
        public String tenNV { get; set; }
        public String ChucVu { get; set; }
    }
    public class CapNhatDoanKhachViewModel
    {
        public int maDoan { get; set; }
        public String DSKhachSan { get; set; }
        public String DSTienKS { get; set; }
        public String DSPhuongTien { get; set; }
        public String DSTienPT { get; set; }
        public String DSKhac { get; set; }
        public String DSTienKhac { get; set; }
        public String DSAn { get; set; }
        public String DSTienAn { get; set; }
    }
    
}