using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyCuoc2.Models;

namespace QuanLyCuoc2.Controllers
{
    public class HoaDonTinhCuocsController : Controller
    {
        private Model1 db = new Model1();

        // GET: HoaDonTinhCuocs
        public ActionResult Index(string id)
        {
            var hoaDonTinhCuocs = db.HoaDonTinhCuocs.Where(i => i.IDSIM == id.ToString()).Include(h => h.ThongTinSIM);
            return View(hoaDonTinhCuocs.ToList());
        }

        // GET: HoaDonTinhCuocs/Details/5
        public ActionResult Details(string id, DateTime date)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //var chitiet = db.ChiTietSuDungs.Where(i => i.IDSIM == id);
            HoaDonTinhCuoc hoaDonTinhCuoc = db.HoaDonTinhCuocs.Find(id);
            if (hoaDonTinhCuoc == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonTinhCuoc);
        }

        // GET: HoaDonTinhCuocs/Create
        public ActionResult Create()
        {
            ViewBag.IDSIM = new SelectList(db.ThongTinSIMs, "IDSIM", "SoDienThoai");
            return View();
        }

        // POST: HoaDonTinhCuocs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHDTC,IDSIM,TuNgay,DenNgay,PhiHangThang,TongTien,NgayXuat,ThanhToan,Flag")] HoaDonTinhCuoc hoaDonTinhCuoc)
        {
            if (ModelState.IsValid)
            {
                db.HoaDonTinhCuocs.Add(hoaDonTinhCuoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDSIM = new SelectList(db.ThongTinSIMs, "IDSIM", "SoDienThoai", hoaDonTinhCuoc.IDSIM);
            return View(hoaDonTinhCuoc);
        }

        // GET: HoaDonTinhCuocs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonTinhCuoc hoaDonTinhCuoc = db.HoaDonTinhCuocs.Find(id);
            if (hoaDonTinhCuoc == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDSIM = new SelectList(db.ThongTinSIMs, "IDSIM", "SoDienThoai", hoaDonTinhCuoc.IDSIM);
            return View(hoaDonTinhCuoc);
        }

        // POST: HoaDonTinhCuocs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHDTC,IDSIM,TuNgay,DenNgay,PhiHangThang,TongTien,NgayXuat,ThanhToan,Flag")] HoaDonTinhCuoc hoaDonTinhCuoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoaDonTinhCuoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDSIM = new SelectList(db.ThongTinSIMs, "IDSIM", "SoDienThoai", hoaDonTinhCuoc.IDSIM);
            return View(hoaDonTinhCuoc);
        }

        // GET: HoaDonTinhCuocs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonTinhCuoc hoaDonTinhCuoc = db.HoaDonTinhCuocs.Find(id);
            if (hoaDonTinhCuoc == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonTinhCuoc);
        }

        // POST: HoaDonTinhCuocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HoaDonTinhCuoc hoaDonTinhCuoc = db.HoaDonTinhCuocs.Find(id);
            db.HoaDonTinhCuocs.Remove(hoaDonTinhCuoc);
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
