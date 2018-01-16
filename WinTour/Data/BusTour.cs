using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusAndModel.Model;

namespace WinTour
{
    class BusTour
    {
        Database db = new Database();
        private int timgiacuatour(DoanKhach k, Tour t)
        {
            int gia = 0;
            for (int i = t.GiaTours.Count-1; i >= 0; i--)
            {
                if (k.NgayKhoiHanh >= t.GiaTours.ElementAt(i).NgayCapNhat) gia=t.GiaTours.ElementAt(i).Gia;
            }
            return gia;
        }
        public int[,] Thongkedoanhthu(DateTime frm,DateTime to)
        {
            int[,] kq;
            var dstour = (List<Tour>)db.Laytatcathongtin("Tours");
            if (dstour[dstour.Count - 1] == null) return null;
            else 
            {
                int stttour = 0;
                int n = dstour.Count;
                kq = new int[n,2];               
                foreach (var i in dstour)
                {
                    var doankhach = i.DoanKhaches.ToList();                    
                    int tongthu = 0;
                    int tongchi = 0;
                    for (int j = 0; j < doankhach.Count; j++)
                        if (doankhach[j].NgayKhoiHanh.Date < frm.Date || doankhach[j].NgayKhoiHanh.Date > to.Date)
                        {  doankhach.RemoveAt(j); j--; }
                  
                    if (doankhach.Count != 0)
                    {
                        foreach (var j in doankhach)
                        {
                            tongthu += timgiacuatour(j, i) * j.DSKhachTheoDoans.Count;
                            tongchi += j.TongChiPhi;
                        }
                    }
                    kq[stttour, 0] = tongthu;
                    kq[stttour, 1] = tongchi;
                    stttour++;
                }
               
            }
            return kq;
        }
        public int[,] ThongkeHD(DateTime frm, DateTime to)
        {
            int[,] kq;
            var dstour = (List<Tour>)db.Laytatcathongtin("Tours");
            if (dstour[dstour.Count - 1] == null) return null;
            else
            {
                int stttour = 0;
                int n = dstour.Count;
                kq = new int[n, 3];
                foreach (var i in dstour)
                {
                    var doankhach = i.DoanKhaches.ToList();
                    int tongslcho = 0;
                    int tongthamgia = 0;
                    for (int j = 0; j < doankhach.Count; j++)
                        if (doankhach[j].NgayKhoiHanh.Date < frm.Date || doankhach[j].NgayKhoiHanh.Date > to.Date)
                        { doankhach.RemoveAt(j); j--; }
                   
                    if (doankhach.Count != 0)
                    {
                        foreach (var j in doankhach)
                        {
                           
                            tongslcho += j.SLCho;
                            tongthamgia += j.DSKhachTheoDoans.Count;
                        }
                    }
                    Console.WriteLine(tongthamgia);
                    kq[stttour, 0] =doankhach.Count;
                    kq[stttour, 1] = tongslcho;
                    kq[stttour, 2] = tongthamgia;

                    stttour++;
                }

            }
            return kq;
        }
    }
}
