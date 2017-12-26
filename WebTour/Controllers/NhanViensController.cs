using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusAndModel.Model;
using WebTour.BUS;

namespace WebTour.Controllers
{
    public class NhanViensController : Controller
    {
        private Model1Container db = new Model1Container();
        private NhanVienBus bus = new NhanVienBus();
        // GET: NhanViens
        public ActionResult Index()
        {
            return View(db.NhanViens.ToList());
        }

        // GET: NhanViens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var nhanvien = bus.ThongTinNV(id);
            if (nhanvien == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien);
        }

        // GET: NhanViens/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult PhanCongNV()
        {
            ViewBag.idNhiemVu = new SelectList(db.NhiemVus, "Id", "TenNhiemVu");
            ViewBag.idNhanVien = new SelectList(db.NhanViens, "Id", "TenNhanVien");
            ViewBag.idDoanKhach = new SelectList(db.DoanKhaches, "Id", "TenGoi");
            return View();
        }
        public ActionResult PhanCong(int? id)
        {
            DoanKhach dk=db.DoanKhaches.Find(id);
            List<DoanKhach> list = new List<DoanKhach>();
            list.Add(dk);
            ViewBag.idNhiemVu = new SelectList(db.NhiemVus, "Id", "TenNhiemVu");
            ViewBag.idNhanVien = new SelectList(db.NhanViens, "Id", "TenNhanVien");
            ViewBag.idDoanKhach = new SelectList(list, "Id", "TenGoi");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PhanCong([Bind(Include = "Id,idNhiemVu,idNhanVien,idDoanKhach")] NhanVienTheoDoan nhanVien)
        {
            if (ModelState.IsValid)
            {
                String error=bus.PhanCong(nhanVien);
                if (error != null)
                {
                    ViewBag.error = error;
                    ViewBag.idNhiemVu = new SelectList(db.NhiemVus, "Id", "TenNhiemVu");
                    ViewBag.idNhanVien = new SelectList(db.NhanViens, "Id", "TenNhanVien");
                    ViewBag.idDoanKhach = new SelectList(db.DoanKhaches, "Id", "TenGoi");
                    return View(nhanVien);
                }
                return RedirectToAction("../DoanKhaches/Details/"+nhanVien.idDoanKhach);
            }

            return View(nhanVien);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TenNhanVien")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                db.NhanViens.Add(nhanVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhanVien);
        }

        // GET: NhanViens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanViens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TenNhanVien")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhanVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhanVien);
        }

        // GET: NhanViens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhanVien nhanVien = db.NhanViens.Find(id);
            db.NhanViens.Remove(nhanVien);
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
