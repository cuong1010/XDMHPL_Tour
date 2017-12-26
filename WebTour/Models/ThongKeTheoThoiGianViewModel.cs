using BusAndModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTour.Models
{
    public class ThongKeTheoThoiGianViewModel<T>
    {
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public List<T> danhsach { get; set; }
        public int Tong { get; set; }
    }
}