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
    public class ChiTietSuDungsController : Controller
    {
        private Model1 db = new Model1();

        // GET: ChiTietSuDungs
        public ActionResult Index(string id, int date)
        {
            //var chiTietSuDungs = from chi in db.ChiTietSuDungs
                                       //where chi.IDSIM == id && chi.TGKT.Value.Month == thang
                                       //select chi;
            var chiTietSuDungs = db.ChiTietSuDungs.Where(i => i.IDSIM == id.ToString() && i.TGKT.Value.Month == date).Include(c => c.ThongTinSIM);
            return View(chiTietSuDungs.ToList());
        }

        // GET: ChiTietSuDungs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietSuDung chiTietSuDung = db.ChiTietSuDungs.Find(id);
            if (chiTietSuDung == null)
            {
                return HttpNotFound();
            }
            return View(chiTietSuDung);
        }

        // GET: ChiTietSuDungs/Create
        public ActionResult Create()
        {
            ViewBag.IDSIM = new SelectList(db.ThongTinSIMs, "IDSIM", "SoDienThoai");
            return View();
        }

        // POST: ChiTietSuDungs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IDSIM,TGBD,TGKT,SoPhutSD7h23h,SoPhutSD23h7h")] ChiTietSuDung chiTietSuDung)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietSuDungs.Add(chiTietSuDung);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDSIM = new SelectList(db.ThongTinSIMs, "IDSIM", "SoDienThoai", chiTietSuDung.IDSIM);
            return View(chiTietSuDung);
        }

        // GET: ChiTietSuDungs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietSuDung chiTietSuDung = db.ChiTietSuDungs.Find(id);
            if (chiTietSuDung == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDSIM = new SelectList(db.ThongTinSIMs, "IDSIM", "SoDienThoai", chiTietSuDung.IDSIM);
            return View(chiTietSuDung);
        }

        // POST: ChiTietSuDungs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IDSIM,TGBD,TGKT,SoPhutSD7h23h,SoPhutSD23h7h")] ChiTietSuDung chiTietSuDung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietSuDung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDSIM = new SelectList(db.ThongTinSIMs, "IDSIM", "SoDienThoai", chiTietSuDung.IDSIM);
            return View(chiTietSuDung);
        }

        // GET: ChiTietSuDungs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietSuDung chiTietSuDung = db.ChiTietSuDungs.Find(id);
            if (chiTietSuDung == null)
            {
                return HttpNotFound();
            }
            return View(chiTietSuDung);
        }

        // POST: ChiTietSuDungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChiTietSuDung chiTietSuDung = db.ChiTietSuDungs.Find(id);
            db.ChiTietSuDungs.Remove(chiTietSuDung);
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
        public ActionResult Search()
        {
            ViewBag.IDSIM = new SelectList(db.ThongTinSIMs, "IDSIM", "SoDienThoai");
            return View();
        }
    }
}
