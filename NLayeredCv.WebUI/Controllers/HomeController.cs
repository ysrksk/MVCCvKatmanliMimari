using NLayeredCv.Business.Abstract;
using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayeredCv.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHakkindaService _hakkindaService;
        private readonly IDeneyimlerimService _deneyimlerimService;
        private readonly IEgitimlerimService _egitimlerimService;
        private readonly IHobilerimService _hobilerimService;
        private IIletisimService _iletisimService;
        private readonly ISertifikalarimService _sertifikalarimService;
        private readonly IYeteneklerimService _yeteneklerimService;

        public HomeController(IHakkindaService hakkindaService, IDeneyimlerimService deneyimlerimService, IEgitimlerimService egitimlerimService, IHobilerimService hobilerimService,
            IIletisimService iletisimService, ISertifikalarimService sertifikalarimService, IYeteneklerimService yeteneklerimService)
        {
            _hakkindaService = hakkindaService;
            _deneyimlerimService = deneyimlerimService;
            _egitimlerimService = egitimlerimService;
            _hobilerimService = hobilerimService;
            _iletisimService = iletisimService;
            _sertifikalarimService = sertifikalarimService;
            _yeteneklerimService = yeteneklerimService;
        }


        // GET: Home
        public ActionResult Index(string mesaj = null)
        {
            var degerler = _hakkindaService.GetAll();
            ViewBag.Mesaj = mesaj;
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = _deneyimlerimService.GetAll();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitim()
        {
            var egitimler = _egitimlerimService.GetAll();
            return PartialView(egitimler);
        }

        public PartialViewResult Yetenek()
        {
            var yetenekler = _yeteneklerimService.GetAll();
            return PartialView(yetenekler);
        }

        public PartialViewResult Hobiler()
        {
            var hobiler = _hobilerimService.GetAll();
            return PartialView(hobiler);
        }

        public PartialViewResult Sertifika()
        {
            var sertifikalar = _sertifikalarimService.GetAll();
            return PartialView(sertifikalar);
        }

        [HttpGet]
        public PartialViewResult İletisim()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult İletisim(TblIletisim p)
        {
            p.Tarih = DateTime.Parse(DateTime.Now.ToShortTimeString());
            _iletisimService.Add(p);
            return RedirectToAction("Index","Home", new { mesaj = "Mesajınız Kaydedilmiştir." });

        }
    }
}