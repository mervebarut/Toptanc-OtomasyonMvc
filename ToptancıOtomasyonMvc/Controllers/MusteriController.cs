using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToptancıOtomasyonMvc.DAL;
using ToptancıOtomasyonMvc.Models;
using ToptancıOtomasyonMvc.Models.ViewModels;

namespace ToptancıOtomasyonMvc.Controllers
{
    public class MusteriController : Controller
    {
        UrunContext ctx = new UrunContext();
        // GET: Musteri
        public ActionResult Index()
        {


            using (UrunContext ctx = new UrunContext())
            {
                MusteriViewModel ovm = new MusteriViewModel();
                ovm.Musteriler = ctx.Musteriler.ToList();

                return View(ovm);
            }

        }


        public ActionResult Ekle()
        {
            return View();
        }



        [HttpPost]
        public bool Ekle(Musteri o)
        {

            if (ModelState.IsValid)//bu dogrulama düzenlede de olmalı projede
            {
                using (UrunContext ctx = new UrunContext())
                {
                    ctx.Musteriler.Add(o);
                    int sonuc = ctx.SaveChanges();
                    if (sonuc > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public string Listele()
        {
            string liste = "";
            List<Musteri> muslistesi = ctx.Musteriler.ToList();
            foreach (var list in muslistesi)
            {
                liste += "<br>" + list.AD + " " + list.SOYAD + " " + list.Telefon + "" + list.TCKNo + "<hr>";
            }
            return liste;
        }

        public ActionResult Duzenle(int? id)
        {
            using (UrunContext ctx = new UrunContext())
            {
                var mus = ctx.Musteriler.Find(id);

                return View(mus);
            }
        }


        [HttpPost]
        public ActionResult Duzenle(Musteri mus)
        {
            using (UrunContext ctx = new UrunContext())
            {
                ctx.Entry(mus).State = EntityState.Modified;
                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
        }

        public ActionResult Sil(int? id)
        {
            using (UrunContext ctx = new UrunContext())
            {
                var mus = ctx.Musteriler.Find(id);
                ctx.Musteriler.Remove(mus);
                ctx.SaveChanges();
                return RedirectToAction("Index");

            }
        }
    }
}
}