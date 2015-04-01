using ActionFilterDemo.DataAccess.Managers;
using ActionFilterDemo.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilterDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            HomeIndexVM model = new HomeIndexVM();
            model.Users = UserManager.GetAll();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(HomeIndexVM model)
        {
            Session["CurrentUserID"] = model.SelectedUser;
            TempData["FlashMessage"] = "You are now " + UserManager.GetByID(model.SelectedUser).Name + ".";
            return RedirectToAction("Index");
        }
    }
}