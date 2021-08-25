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
            var lstQuote = new List<Insuree>();
            foreach(var quote in db.Insurees)
            {
                var lstquotes = new Insuree();
                lstquotes.FirstName = quote.FirstName;
                lstquotes.LastName = quote.LastName;
                lstquotes.EmailAddress = quote.EmailAddress;
                
                decimal totalQuote = 0;
                var age = 0;
                // find persons age
                age = DateTime.Today.Year - quote.DateOfBirth.Year;
                // age quote
                if(age < 18)
                {
                    totalQuote += 100;
                }
                if (age >= 19 && age < 25)
                {
                    totalQuote += 50;
                }
                if (age > 25)
                {
                    totalQuote += + 25;
                }
                // car year quote
                if(quote.CarYear < 2000)
                {
                    totalQuote += 25;
                }
                if(quote.CarYear > 2015)
                {
                    totalQuote += 25;
                }
                // car make and model quote
                if(quote.CarMake == "Porsche")
                {
                    totalQuote += 25;
                }
                if (quote.CarMake == "Porsche" && quote.CarModel == "911 Carrea")
                {
                    totalQuote += 25;
                }
                // speeding tickets quote
                if (quote.SpeedingTickets > 0)
                {
                    totalQuote += (quote.SpeedingTickets * 10);
                }
                // dui quote
                if (quote.DUI)
                {
                    double duiMult = 0.25;
                    totalQuote += totalQuote * Convert.ToDecimal(duiMult);
                }
                // full coverage quote
                if (quote.CoverageType)
                {
                    double coverageMult = .50;
                    totalQuote += totalQuote * Convert.ToDecimal(coverageMult);
                }


                // add totalQuote to list for quote
                lstquotes.Quote = totalQuote;
               
                lstQuote.Add(lstquotes);
                

                quote.Quote = totalQuote;
                
                
            }
            try
            {
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return View(lstQuote);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
