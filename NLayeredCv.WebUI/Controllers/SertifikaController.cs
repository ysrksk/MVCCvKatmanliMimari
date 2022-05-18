using NLayeredCv.Business.Abstract;
using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayeredCv.WebUI.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        private ISertifikalarimService _sertifikalarimService;
        public SertifikaController(ISertifikalarimService sertifikalarimService)
        {
            _sertifikalarimService = sertifikalarimService;
        }
        public ActionResult Index()
        {
            List<TblSertifikalarim> sertifikalar = _sertifikalarimService.GetAll();
            return View(sertifikalar);
        }

        public ActionResult YeniEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kaydet(TblSertifikalarim tblSertifikalarim)
        {
            _sertifikalarimService.Add(tblSertifikalarim);
            return RedirectToAction("Index");
        }

        public ActionResult Sil(TblSertifikalarim tblSertifikalarim)
        {
            _sertifikalarimService.Delete(tblSertifikalarim);
            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int id)
        {
            TblSertifikalarim sertifika = _sertifikalarimService.GetById(id);
            return View(sertifika);
        }

        [HttpPost]
        public ActionResult Guncelle(TblSertifikalarim tblSertifikalarim)
        {
            _sertifikalarimService.Update(tblSertifikalarim);
            return RedirectToAction("Index");
        }
    }
}