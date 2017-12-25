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
        public ActionResult DoanKhach([Bind(Include = "from,to")] ThongKeDoanKhachViewModel thongke)
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
    }
}