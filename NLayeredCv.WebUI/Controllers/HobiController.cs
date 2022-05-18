using NLayeredCv.Business.Abstract;
using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayeredCv.WebUI.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        private IHobilerimService _hobilerimService;
        public HobiController(IHobilerimService hobilerimService)
        {
            _hobilerimService = hobilerimService;
        }
        public ActionResult Index()
        {
            var hobiler = _hobilerimService.GetAll();
            return View(hobiler);
        }

        public ActionResult YeniEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniEkle(TblHobilerim tblHobilerim)
        {
            _hobilerimService.Add(tblHobilerim);
            return RedirectToAction("Index");
        }

        public ActionResult Sil(TblHobilerim tblHobilerim)
        {
            _hobilerimService.Delete(tblHobilerim);
            return RedirectToAction("Index");
        }
    }
}