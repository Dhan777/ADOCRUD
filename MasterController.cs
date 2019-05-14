using MvcApplication4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication4.Controllers
{
    public class MasterController : Controller
    {

        DataLayer db = new DataLayer();
        public ActionResult Index()
        {
            return View();
        }

        public SelectList LoadCountry()
        {
            var lst = db.GetCountry();
            System.Web.Mvc.SelectList lst2 = new SelectList(lst, "Value", "Name");
            return lst2;
        }

    }
}
