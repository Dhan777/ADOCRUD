using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class ADOController : Controller
    {
        //
        // GET: /ADO/

        DataLayer db = new DataLayer();
        public ActionResult Index()
        {
            Tab model = new Tab();
            model.ProcId = "Select";
            return View(db.CRUD_Tab(model).ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Tab model)
        {
            model.ProcId = "Create";
            var lst = db.CRUD_Tab(model);
            if (lst != null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            Tab model = new Tab();
            model.ID = id; model.ProcId = "search";
            return View(db.CRUD_Tab(model).FirstOrDefault());
        }

    }
}
