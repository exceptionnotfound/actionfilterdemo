using ActionFilterDemo.Attributes;
using ActionFilterDemo.DataAccess.Managers;
using ActionFilterDemo.ViewModels.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilterDemo.Controllers
{
    public class ReportsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ReportsIndexVM model = new ReportsIndexVM();
            model.Reports = ReportsManager.GetAll();
            return View(model);
        }

        [HttpGet]
        [CanEditReport]
        public ActionResult View(int id)
        {
            var report = ReportsManager.GetByID(id);
            return View(report);
        }
    }
}