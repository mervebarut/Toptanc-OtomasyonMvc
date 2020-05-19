using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToptancıOtomasyonMvc.Controllers
{
    public class HomeController : Controller
    {
       
            // GET: Home
            public ActionResult Index()
            {
                ViewBag.isim = "Ad1";
                ViewData["ad"] = "Ad2";

                return View();
            }



        }
    }

