using BusAndModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTour.BUS;
using WebTour.Models;

namespace WebTour.Controllers
{
    public class ThongKeController : Controller
    {
        private ThongKeBus bus = new ThongKeBus();
        // GET: ThongKe
        public ActionResult DoanKhach()
        {
            var thongkedoan = bus.TkDoanKhach(new DateTime(2016, 1, 1), DateTime.Now);
            if (thongkedoan == null)
            {
                ViewBag.error = "Không tìm thấy lịch sử đoàn khách!!!";
            }
            return View(thongkedoan);
        }
        [HttpPost]
        public ActionResult DoanKhach([Bind(Include = "from,to")] ThongKeTheoThoiGianViewModel<DoanKhach> thongke)
        {
            if (ModelState.IsValid)
            {
                var thongkedoan = bus.TkDoanKhach(thongke.from,thongke.to);
                if (thongkedoan == null)
                {
                    ViewBag.error = "Không tìm thấy lịch sử đoàn khách!!!!";
                    return View(thongke);
                }
                return View(thongke);
            }

            return View(thongke);
        }
        public ActionResult KhachSan()
        {
            var thongkedoan = bus.TkKhachSan(new DateTime(2016, 1, 1), DateTime.Now);
            if (thongkedoan == null)
            {
                ViewBag.error = "Không tìm thấy lịch sử khách Sạn!!!";
            }
            return View(thongkedoan);
        }
        [HttpPost]
        public ActionResult KhachSan([Bind(Include = "from,to")] ThongKeTheoThoiGianViewModel<KhachSanTheoDoan> thongke)
        {
            if (ModelState.IsValid)
            {
                var thongkedoan = bus.TkKhachSan(thongke.from, thongke.to);
                if (thongkedoan == null)
                {
                    ViewBag.error = "Không tìm thấy lịch sử Khách Sạn!!!!";
                    return View(thongke);
                }
                return View(thongke);
            }

            return View(thongke);
        }
        public ActionResult TienAn()
        {
            var thongkedoan = bus.TkTienAn(new DateTime(2016, 1, 1), DateTime.Now);
            if (thongkedoan == null)
            {
                ViewBag.error = "Không tìm thấy lịch sử tiền ăn!!!";
            }
            return View(thongkedoan);
        }
        [HttpPost]
        public ActionResult TienAn([Bind(Include = "from,to")] ThongKeTheoThoiGianViewModel<KhachSanTheoDoan> thongke)
        {
            if (ModelState.IsValid)
            {
                var thongkedoan = bus.TkTienAn(thongke.from, thongke.to);
                if (thongkedoan == null)
                {
                    ViewBag.error = "Không tìm thấy lịch sử tiền ăn!!!!";
                    return View(thongke);
                }
                return View(thongke);
            }

            return View(thongke);
        }
        public ActionResult PhuongTien()
        {
            var thongkedoan = bus.TkPhuongTien(new DateTime(2016, 1, 1), DateTime.Now);
            if (thongkedoan == null)
            {
                ViewBag.error = "Không tìm thấy lịch sử phương tiện!!!";
            }
            return View(thongkedoan);
        }
        [HttpPost]
        public ActionResult PhuongTien([Bind(Include = "from,to")] ThongKeTheoThoiGianViewModel<KhachSanTheoDoan> thongke)
        {
            if (ModelState.IsValid)
            {
                var thongkedoan = bus.TkPhuongTien(thongke.from, thongke.to);
                if (thongkedoan == null)
                {
                    ViewBag.error = "Không tìm thấy lịch sử phương tiện!!!!";
                    return View(thongke);
                }
                return View(thongke);
            }

            return View(thongke);
        }
        public ActionResult NhanVien()
        {
            var thongkedoan = bus.TkNhanVien(new DateTime(2016, 1, 1), DateTime.Now);
            if (thongkedoan == null)
            {
                ViewBag.error = "Không tìm thấy lịch sử nhân viên !!!";
            }
            return View(thongkedoan);
        }
        [HttpPost]
        public ActionResult NhanVien([Bind(Include = "from,to")] ThongKeTheoThoiGianViewModel<KhachSanTheoDoan> thongke)
        {
            if (ModelState.IsValid)
            {
                var thongkedoan = bus.TkNhanVien(thongke.from, thongke.to);
                if (thongkedoan == null)
                {
                    ViewBag.error = "Không tìm thấy lịch sử nhân viên!!!!";
                    return View(thongke);
                }
                return View(thongke);
            }

            return View(thongke);
        }
    }
}