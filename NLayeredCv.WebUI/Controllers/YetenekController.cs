using NLayeredCv.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLayeredCv.Entities.Concrete;

namespace NLayeredCv.WebUI.Controllers
{
    public class YetenekController : Controller
    {
        private IYeteneklerimService _yeneklerimService;
        public YetenekController(IYeteneklerimService yeteneklerimService)
        {
            _yeneklerimService = yeteneklerimService;
        }
        // GET: Yetenek
        public ActionResult Index()
        {
            var yetenekler = _yeneklerimService.GetAll();
            return View(yetenekler);
        }

        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(TblYeteneklerim tblYeteneklerim)
        {
            _yeneklerimService.Add(tblYeteneklerim);
            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int id)
        {
            var yetenekler = _yeneklerimService.GetById(id);
            return View(yetenekler);
        }

        [HttpPost]
        public ActionResult Duzenle(TblYeteneklerim tblYeteneklerim)
        {
            _yeneklerimService.Update(tblYeteneklerim);
            return RedirectToAction("Index");
        }

        public ActionResult Sil(TblYeteneklerim tblYeteneklerim)
        {
            _yeneklerimService.Delete(tblYeteneklerim);
            return RedirectToAction("Index");
        }
    }
}