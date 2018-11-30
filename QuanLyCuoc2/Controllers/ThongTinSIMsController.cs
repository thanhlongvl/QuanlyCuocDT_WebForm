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
    public class ThongTinSIMsController : Controller
    {
        private Model1 db = new Model1();

        // GET: ThongTinSIMs
        public ActionResult Index()
        {
            var thongTinSIMs = db.ThongTinSIMs.Include(t => t.KhachHang);
            return View(thongTinSIMs.ToList());
        }

        // GET: ThongTinSIMs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongTinSIM thongTinSIM = db.ThongTinSIMs.Find(id);
            if (thongTinSIM == null)
            {
                return HttpNotFound();
            }
            return View(thongTinSIM);
        }

        // GET: ThongTinSIMs/Create
        public ActionResult Create()
        {
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "TenKH");
            return View();
        }

        // POST: ThongTinSIMs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDSIM,SoDienThoai,NgayDangKy,NgayHetHan,Flag,MaKH")] ThongTinSIM thongTinSIM)
        {
            if (ModelState.IsValid)
            {
                db.ThongTinSIMs.Add(thongTinSIM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "TenKH", thongTinSIM.MaKH);
            return View(thongTinSIM);
        }

        // GET: ThongTinSIMs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongTinSIM thongTinSIM = db.ThongTinSIMs.Find(id);
            if (thongTinSIM == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "TenKH", thongTinSIM.MaKH);
            return View(thongTinSIM);
        }

        // POST: ThongTinSIMs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDSIM,SoDienThoai,NgayDangKy,NgayHetHan,Flag,MaKH")] ThongTinSIM thongTinSIM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thongTinSIM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "TenKH", thongTinSIM.MaKH);
            return View(thongTinSIM);
        }

        // GET: ThongTinSIMs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongTinSIM thongTinSIM = db.ThongTinSIMs.Find(id);
            if (thongTinSIM == null)
            {
                return HttpNotFound();
            }
            return View(thongTinSIM);
        }

        // POST: ThongTinSIMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ThongTinSIM thongTinSIM = db.ThongTinSIMs.Find(id);
            db.ThongTinSIMs.Remove(thongTinSIM);
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
