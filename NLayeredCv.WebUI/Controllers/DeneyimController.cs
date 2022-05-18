using NLayeredCv.Business.Abstract;
using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayeredCv.WebUI.Controllers
{
    public class DeneyimController : Controller
    {
        private IDeneyimlerimService _deneyimlerimService;
        public DeneyimController(IDeneyimlerimService deneyimlerimService)
        {
            _deneyimlerimService = deneyimlerimService;
        }
        // GET: Deneyim
        public ActionResult Index()
        {
            var deneyimler = _deneyimlerimService.GetAll();
            return View(deneyimler);
        }

        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeneyimEkle(TblDeneyimlerim tblDeneyimlerim)
        {
            _deneyimlerimService.Add(tblDeneyimlerim);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Duzenle(int id)
        {
            var deneyimler =_deneyimlerimService.GetById(id);
            return View(deneyimler);
        }

        [HttpPost]
        public ActionResult Duzenle(TblDeneyimlerim tblDeneyimlerim)
        {
            _deneyimlerimService.Update(tblDeneyimlerim);
            return RedirectToAction("Index");
        }

        public ActionResult Sil(TblDeneyimlerim tblDeneyimlerim)
        {
            _deneyimlerimService.Delete(tblDeneyimlerim);
            return RedirectToAction("Index");
        }
    }
}