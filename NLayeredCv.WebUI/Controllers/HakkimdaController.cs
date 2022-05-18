using NLayeredCv.Business.Abstract;
using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayeredCv.WebUI.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        private IHakkindaService _hakkindaService;
        public HakkimdaController(IHakkindaService hakkindaService)
        {
            _hakkindaService = hakkindaService;
        }
        public ActionResult Index()
        {
            var profil = _hakkindaService.GetByİd();
            return View(profil);
        }

        public ActionResult Duzenle(TblHakkinda tblHakkinda)
        {
            _hakkindaService.Update(tblHakkinda);
            return RedirectToAction("Index");
        }
    }
}