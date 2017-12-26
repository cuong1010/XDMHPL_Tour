using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusAndModel.Model;
using BusAndModel.BUS;
using WebTour.Models;

namespace WebTour.Controllers
{
    public class DoanKhachesController : Controller
    {
        private DoanKhachBus bus = new DoanKhachBus();
        private Model1Container db = new Model1Container();

        // GET: DoanKhaches
        public ActionResult Index()
        {
            var doanKhaches = bus.getList();
            return View(doanKhaches.ToList());
        }
        public ActionResult TienDoan()
        {
            var doanKhaches = db.DoanKhaches.Include(c => c.Tour).Where(c=>c.NgayKetThuc<DateTime.Now);
            return View(doanKhaches.ToList());
        }
        // GET: DoanKhaches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var doankhach = bus.getDetail(id);
            if (doankhach == null)
            {
                return HttpNotFound();
            }
            return View(doankhach);
        }
        public ActionResult DangKy(int? id)
        {
            DoanKhach doan = db.DoanKhaches.Find(id);
            ViewBag.DoanKhachId = new SelectList(db.DoanKhaches, "Id", "TenGoi");
            ViewBag.KhachHangId = new SelectList(db.KhachHangs, "Id", "HoTen");
            ViewBag.tenTour = bus.getTenTour(id);
            ViewBag.ngayKhoiHanh = doan.NgayKhoiHanh.Date.ToString();
            ViewBag.ngayKetThuc = doan.NgayKetThuc.Date.ToString();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangKy([Bind(Include = "Id,DoanKhachId,KhachHangId")] DSKhachTheoDoan dSKhachTheoDoan)
        {
            if (ModelState.IsValid)
            {
                if (bus.Dangky(dSKhachTheoDoan))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Lỗi xảy ra!, Kiểm tra lại số lượng hoặc đã đăng ký vui lòng thử lại sau!";
                    DoanKhach doan = db.DoanKhaches.Find(dSKhachTheoDoan.Id);
                    ViewBag.DoanKhachId = new SelectList(db.DoanKhaches, "Id", "TenGoi");
                    ViewBag.KhachHangId = new SelectList(db.KhachHangs, "Id", "HoTen");
                    ViewBag.tenTour = bus.getTenTour(dSKhachTheoDoan.Id);
                    ViewBag.ngayKhoiHanh = doan.NgayKhoiHanh.Date.ToString();
                    ViewBag.ngayKetThuc = doan.NgayKetThuc.Date.ToString();
                    return View();
                }
            }
            ViewBag.DoanKhachId = new SelectList(db.DoanKhaches, "Id", "TenGoi", dSKhachTheoDoan.DoanKhachId);
            ViewBag.KhachHangId = new SelectList(db.KhachHangs, "Id", "HoTen", dSKhachTheoDoan.KhachHangId);
            return View(dSKhachTheoDoan);
        }
        // GET: DoanKhaches/Create
        public ActionResult Create()
        {
            ViewBag.TourId = new SelectList(db.Tours, "Id", "TenGoi");
            return View();
        }

        // POST: DoanKhaches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TenGoi,NgayKhoiHanh,NgayKetThuc,TongKS,TongAn,TongPT,TongKhac,TourId,SLCho")] DoanKhach doanKhach)
        {
            if (ModelState.IsValid)
            {
                String error=bus.CreateDoan(doanKhach);
                if (error != null)
                {
                    ViewBag.error = error;
                    ViewBag.TourId = new SelectList(db.Tours, "Id", "TenGoi");
                    return View();
                }
                return RedirectToAction("Index");
            }

            ViewBag.TourId = new SelectList(db.Tours, "Id", "TenGoi", doanKhach.TourId);
            return View(doanKhach);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapNhatDoanKhachViewModel doanKhach = new CapNhatDoanKhachViewModel();
            doanKhach = bus.getThongTinChiPhi(id);
            return View(doanKhach);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maDoan,DSKhachSan,DSTienKS,DSAn,DSTienAn,DSPhuongTien,DSTienPT,DSKhac,DSTienKhac")] CapNhatDoanKhachViewModel doankhach)
        {
            if (ModelState.IsValid)
            {
                String error=bus.CapNhatTien(doankhach);
                if (error != null)
                {
                    ViewBag.error = error;
                    return View();
                }
                return RedirectToAction("TienDoan");
            }
            return View(doankhach);
        }

        // GET: DoanKhaches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoanKhach doanKhach = db.DoanKhaches.Find(id);
            if (doanKhach == null)
            {
                return HttpNotFound();
            }
            return View(doanKhach);
        }

        // POST: DoanKhaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoanKhach doanKhach = db.DoanKhaches.Find(id);
            db.DoanKhaches.Remove(doanKhach);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
