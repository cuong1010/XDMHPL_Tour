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
        public ThongKeDoanKhachViewModel TkDoanKhach(DateTime from, DateTime to)
        {
            try
            {
                ThongKeDoanKhachViewModel result = new ThongKeDoanKhachViewModel();
                List<DoanKhach> list = db.DoanKhaches.Where(c => c.NgayKetThuc >= from && c.NgayKetThuc <= to).ToList();
                result.from = from;
                result.to = to;
                result.danhSachDoan = list;
                int sum = 0;
                foreach (DoanKhach item in list)
                {
                    sum += item.TongAn.Value + item.TongKhac.Value + item.TongKS.Value + item.TongPT.Value;
                }
                result.TongTien = sum;
                return result;
            }
            catch (Exception e) { return null; }
        }
    }
}