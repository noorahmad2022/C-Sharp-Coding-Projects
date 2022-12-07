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
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurances.ToList());
        }

        // GET: Insuree/Details/5
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

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurance insurance)
        {
            if (ModelState.IsValid)
            {
                db.Insurances.Add(insurance);

                int ticketCost = insurance.SpeedingTickets * 10;
                int userAge = DateTime.Now.Year - insurance.DateOfBirth.Year;
                decimal defaultQuote = 50 + ticketCost;
                decimal total;

                if (userAge <= 18)
                {
                    insurance.Quote = defaultQuote += 100;
                }
                if (userAge > 18 && userAge <= 25)
                {
                    insurance.Quote = defaultQuote += 50;
                }
                if (userAge > 25)
                {
                    insurance.Quote = defaultQuote += 25;
                }
                if (insurance.CarYear <= 2000)
                {
                    insurance.Quote = defaultQuote += 25;
                }
                if (insurance.CarYear >= 2015)
                {
                    insurance.Quote = defaultQuote += 25;
                }
                if (insurance.CarMake == "Porsche")
                {
                    insurance.Quote = defaultQuote += 25;
                }
                if (insurance.CarMake == "Porsche" && insurance.CarMake == "911 Carrera")
                {
                    insurance.Quote = defaultQuote += 50;
                }
                if (insurance.DUI == true)
                {
                    total=defaultQuote*25/100+defaultQuote;
                    defaultQuote = total;
                    insurance.Quote = total;
                }
                if (insurance.CoverageType == true)
                {
                    total = defaultQuote * 50 / 100 + defaultQuote;
                    insurance.Quote = total;

                }

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insurance);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurance insurance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurance);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurance insurance = db.Insurances.Find(id);
            db.Insurances.Remove(insurance);
            db.SaveChanges();
            return RedirectToAction("Index");
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
