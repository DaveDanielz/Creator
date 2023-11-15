using BusinessObj;
using Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index (UserBO objUserBO) 
        {
            UserBL userBL = new UserBL();
           AccountBO accountBO = userBL.AddUser(objUserBO);
            return View();
        }
    }
}