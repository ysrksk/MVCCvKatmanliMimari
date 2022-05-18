using NLayeredCv.Business.Abstract;
using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayeredCv.WebUI.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        private IIletisimService _iletisimService;
        public IletisimController(IIletisimService iletisimService)
        {
            _iletisimService = iletisimService;
        }
        public ActionResult Index()
        {
            List<TblIletisim> mesajlar = _iletisimService.GetAll();
            return View(mesajlar);
        }

        public ActionResult Sil(TblIletisim tblIletisim)
        {
            _iletisimService.Delete(tblIletisim);
            return RedirectToAction("Index");
        }
    }
}