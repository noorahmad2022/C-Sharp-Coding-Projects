using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Insurances.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurance insurance = db.Insurances.Find(id);
            if (insurance == null)
            {
                return HttpNotFound();
            }
            return View(insurance);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
