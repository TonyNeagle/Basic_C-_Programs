using CarInsurance.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // 1. GET: Insuree/Index (Display list)
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // 2. GET: Insuree/Create (Display empty form)
        public ActionResult Create()
        {
            return View();
        }

        // 3. POST: Insuree/Create (Save form data)
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

        // 4. GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null) return HttpNotFound();
            return View(insuree);
        }

        // 5. GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null) return HttpNotFound();
            return View(insuree);
        }

        // 6. POST: Insuree/Edit/5
        // POST: Insuree/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DateOfBirth")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // 1. Fetch the existing record straight from the database file
                var existingRecord = db.Insurees.Find(insuree.Id);
                if (existingRecord == null) return HttpNotFound();

                // 2. Overwrite ONLY the updated Date of Birth value
                existingRecord.DateOfBirth = insuree.DateOfBirth;

                // 3. Save the single attribute adjustment cleanly
                db.SaveChanges(); // Line 65

                return RedirectToAction("Index");
            }
            return View(insuree);
        }


        // 7. GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null) return HttpNotFound();
            return View(insuree);
        }

        // 8. POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // 9. Clean up database connections
        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}
