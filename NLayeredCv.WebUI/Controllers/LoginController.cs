using NLayeredCv.Business.Abstract;
using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NLayeredCv.WebUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private IAdminService _adminService;
        public LoginController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblAdmin tblAdmin2)
        {
            var bilgi = _adminService.GetAll().FirstOrDefault(p => p.KullaniciAdi == tblAdmin2.KullaniciAdi && p.Sifre == tblAdmin2.Sifre);
            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.KullaniciAdi, false);
                Session["KullaniciAdi"] = bilgi.KullaniciAdi.ToString();
                return RedirectToAction("Index","Deneyim");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
    }
}