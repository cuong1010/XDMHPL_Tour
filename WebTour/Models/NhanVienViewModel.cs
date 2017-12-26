using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTour.Models
{
    public class NhanVienViewModel
    {
        public String tenNV { get; set; }
        public List<PhanCongViewModel> PhanCong { get; set; }
        public String TinhTrang { get; set; }
    }
    public class PhanCongViewModel
    {
        public String ChucVu { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public String TenTour { get; set; }
        public String TenDoan { get; set; }
    }
    public class ThongKeNhanVienViewModel
    {
        public int Id
        {
            get;
            set;
        }
        public String TenNV { get; set; }
        public int SoLan { get; set; }
    }
}