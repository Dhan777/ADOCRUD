using MvcApplication4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;

namespace MvcApplication4.Controllers
{
    public class RegistrationController : Controller
    {
        //
        // GET: /Registration/
        DataLayer db = new Models.DataLayer();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student model)
        {
            return View();
        }
        public JsonResult State(string CountryId)
        {
            var lst = db.GetCountry();
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
    }
}
