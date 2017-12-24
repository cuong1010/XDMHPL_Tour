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
        [Required]
        [Display(Name = "Tên Tour")]
        public string tenTour { get; set; }

        [Required]
        [Display(Name = "Tên Đoàn")]
        public string tenDoan { get; set; }

        [Required]
        [Display(Name = "Mã Đoàn")]
        public int maDoan { get; set; }

        [Required]
        [Display(Name = "Ngày Khởi Hành")]
        public DateTime ngayKhoiHanh { get; set; }

        [Required]
        [Display(Name = "Ngày Kết Thúc")]
        public DateTime ngayKetThuc { get; set; }
        [Required]
        [Display(Name = "Thông tin")]
        public string thongtin { get; set; }

        [Display(Name = "Số lượng còn lại")]
        public int soluong { get; set; }
        public List<KhachHang> danhsachkhach { get; set; }
        public List<NhanVienViewModel> nhanvien { get; set; }
    }
    public class NhanVienViewModel
    {
        public String tenNV { get; set; }
        public String ChucVu { get; set; }
    }
}