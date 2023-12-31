﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projem.Models.DataContext;
using Projem.Models.Departman;
using Projem.Models.Personel;

namespace Projem.Controllers
{
    public class DepartmanBilgilerisController : Controller
    {
        private ProjeTakipDBContext db = new ProjeTakipDBContext();

        // GET: DepartmanBilgileris
        public ActionResult Index()
        {
            return View(db.DepartmanBilgileris.ToList());
        }

        // GET: DepartmanBilgileris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DepartmanBilgileri departmanBilgileri = db.DepartmanBilgileris.Find(id);
            if (departmanBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(departmanBilgileri);
        }

        // GET: DepartmanBilgileris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmanBilgileris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DepartmanBilgileriId,DepartmanAdi")] DepartmanBilgileri departmanBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.DepartmanBilgileris.Add(departmanBilgileri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(departmanBilgileri);
        }

        // GET: DepartmanBilgileris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DepartmanBilgileri departmanBilgileri = db.DepartmanBilgileris.Find(id);
            if (departmanBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(departmanBilgileri);
        }

        // POST: DepartmanBilgileris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DepartmanBilgileriId,DepartmanAdi")] DepartmanBilgileri departmanBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(departmanBilgileri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(departmanBilgileri);
        }

        // GET: DepartmanBilgileris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DepartmanBilgileri departmanBilgileri = db.DepartmanBilgileris.Find(id); //seçili id yi buluyor bu satırda bak departman controllerındayım DepartmanBilgileri yazıyor
            db.DepartmanBilgileris.Remove(departmanBilgileri);//sonra veritabanından kaldır emiri veriyor
            db.SaveChanges();//ve siliyor
            return RedirectToAction("Index");
        }

        // POST: DepartmanBilgileris/Delete/5
        /*[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DepartmanBilgileri departmanBilgileri = db.DepartmanBilgileris.Find(id);
            db.DepartmanBilgileris.Remove(departmanBilgileri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }*/

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
