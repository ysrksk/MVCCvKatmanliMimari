using NLayeredCv.Business.Abstract;
using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayeredCv.WebUI.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim
        private IEgitimlerimService _egitimlerimService;
        public EgitimController(IEgitimlerimService egitimlerimService)
        {
            _egitimlerimService = egitimlerimService;
        }
        public ActionResult Index()
        {
            var egitimler =_egitimlerimService.GetAll();
            return View(egitimler);
        }

        public ActionResult YeniEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniEkle(TblEgitimlerim tblEgitimlerim)
        {
            _egitimlerimService.Add(tblEgitimlerim);
            return RedirectToAction("Index");
        }

        public ActionResult Sil(TblEgitimlerim tblEgitimlerim)
        {
            _egitimlerimService.Delete(tblEgitimlerim);
            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int id)
        {
            var egitim = _egitimlerimService.GetById(id);
            return View(egitim);
        }

        [HttpPost]
        public ActionResult Duzenle(TblEgitimlerim tblEgitimlerim)
        {
            _egitimlerimService.Update(tblEgitimlerim);
            return RedirectToAction("Index");
        }
    }
}