using BusAndModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTour.Models
{
    public class ThongKeDoanKhachViewModel
    {
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public int TongTien { get; set; }
        public List<DoanKhach> danhSachDoan { get; set; }
    }
}