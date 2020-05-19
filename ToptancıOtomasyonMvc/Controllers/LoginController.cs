using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ToptancıOtomasyonMvc.Models.ViewModels;

namespace ToptancıOtomasyonMvc.Controllers
{
    public class LoginController : Controller
    {
        
            // GET: Admin/Login
            [AllowAnonymous]
            public ActionResult Login()
            {
                if (String.IsNullOrEmpty(HttpContext.User.Identity.Name))
                {
                    FormsAuthentication.SignOut();
                    return View();
                }
                return Redirect("/Admin/Home");


            }
            [AllowAnonymous]
            [HttpPost]
            public ActionResult Login(LoginModel model, string returnurl)
            {
                if (ModelState.IsValid)
                {

                    var rpstryadmn = new RepositoryPortal<AdminUser>();
                    //Aşağıdaki if komutu gönderilen mail ve şifre doğrultusunda kullanıcı kontrolu yapar. Eğer kullanıcı var ise login olur.
                    if (rpstryadmn.NesneVarMi(a => a.Email == model.EMail && a.Password == model.password))
                    {
                        FormsAuthentication.SetAuthCookie(model.EMail, true);
                        return RedirectToAction("Index", "Home");
                    }

                    else
                    {
                        ModelState.AddModelError("", "EMail veya şifre hatalı!");
                    }
                }
                return View(model);
            }
        }
    }
}