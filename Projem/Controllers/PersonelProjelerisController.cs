using Projem.Models.DataContext;
using Projem.Models.Departman;
using Projem.Models.Personel;
using Projem.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Projem.Controllers
{
    public class PersonelProjelerisController : Controller
    {

        private ProjeTakipDBContext db = new ProjeTakipDBContext(); //veritabanı bağlantısı yaptık


        // GET: PersonelProjeleris
        public ActionResult Index()
        {
            var projelistele = db.PersonelProjeleris.ToList();
            return View(projelistele);
        }

        public ActionResult Create()
        {
            ViewBag.PersonelBilgileriId = new SelectList(db.PersonelBilgileris, "PersonelBilgileriId", "AdSoyad");
            return View();
        }

        [HttpPost]
        public ActionResult Create(PersonelProjeleri projeObj, int[] PersonelBilgileriId)
        {

            foreach (var x in PersonelBilgileriId)
            {
                projeObj.PersonelBilgileris.Add(db.PersonelBilgileris.Find(x));
            }
            projeObj.OlusturmaTarihi = DateTime.Now;
            db.PersonelProjeleris.Add(projeObj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id) 
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelProjeleri personelProjeleri = db.PersonelProjeleris.Find(id); //personel controllerındayım PersonelBilgileri tablosuna bağlanmış anladın mı
            db.PersonelProjeleris.Remove(personelProjeleri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelProjeleri personelProjeleri = db.PersonelProjeleris.Find(id);
            if (personelProjeleri == null)
            {
                return HttpNotFound();
            }
            return View(personelProjeleri);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonelProjeleri personelProjeleri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personelProjeleri).State = EntityState.Modified;
                if(personelProjeleri.TamamlanmaOrani == 100)
                {
                    personelProjeleri.TamamlanmaDurumu = true;
                }
                else
                {
                    personelProjeleri.TamamlanmaDurumu = false;
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personelProjeleri);
        }

        public ActionResult Tamamla(int? id)
        {
            var projeObj = db.PersonelProjeleris.Find(id);
            projeObj.TamamlanmaDurumu = true;
            projeObj.TamamlanmaOrani = 100;

            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}