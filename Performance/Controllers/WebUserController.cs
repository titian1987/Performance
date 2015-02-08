using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance.Data.Entity;
using Performance.DAL;

namespace Performance.Controllers
{
    public class WebUserController : Controller
    {
        private PerformanceContext db = new PerformanceContext();

        //
        // GET: /WebUser/

        public ActionResult Index()
        {
            return View(db.WebUsers.ToList());
        }

        //
        // POST: /WebUser/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WebUser webuser)
        {
            if (ModelState.IsValid)
            {
                db.WebUsers.Add(webuser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(webuser);
        }

        
        //
        // GET: /WebUser/Delete/5

        public ActionResult Delete(int id = 0)
        {
            WebUser webuser = db.WebUsers.Find(id);
            if (webuser == null)
            {
                return HttpNotFound();
            }
            return View(webuser);
        }

        //
        // POST: /WebUser/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WebUser webuser = db.WebUsers.Find(id);
            db.WebUsers.Remove(webuser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}