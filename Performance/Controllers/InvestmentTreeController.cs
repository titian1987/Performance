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
    public class InvestmentTreeController : Controller
    {
        private PerformanceContext db = new PerformanceContext();

        //
        // GET: /InvestmentTree/

        public ActionResult Index()
        {
            return View(db.InvestmentTrees.ToList());
        }

        //
        // GET: /InvestmentTree/Details/5

        public ActionResult Details(int id = 0)
        {
            InvestmentTree investmenttree = db.InvestmentTrees.Find(id);
            if (investmenttree == null)
            {
                return HttpNotFound();
            }
            return View(investmenttree);
        }

        //
        // GET: /InvestmentTree/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /InvestmentTree/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InvestmentTree investmenttree)
        {
            if (ModelState.IsValid)
            {
                db.InvestmentTrees.Add(investmenttree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(investmenttree);
        }

        //
        // GET: /InvestmentTree/Edit/5

        public ActionResult Edit(int id = 0)
        {
            InvestmentTree investmenttree = db.InvestmentTrees.Find(id);
            if (investmenttree == null)
            {
                return HttpNotFound();
            }
            return View(investmenttree);
        }

        //
        // POST: /InvestmentTree/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InvestmentTree investmenttree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(investmenttree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(investmenttree);
        }

        //
        // GET: /InvestmentTree/Delete/5

        public ActionResult Delete(int id = 0)
        {
            InvestmentTree investmenttree = db.InvestmentTrees.Find(id);
            if (investmenttree == null)
            {
                return HttpNotFound();
            }
            return View(investmenttree);
        }

        //
        // POST: /InvestmentTree/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InvestmentTree investmenttree = db.InvestmentTrees.Find(id);
            db.InvestmentTrees.Remove(investmenttree);
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