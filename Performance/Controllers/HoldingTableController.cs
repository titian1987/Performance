using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance.Data.Entity;
using Performance.DAL;
using Performance.Models;

namespace Performance.Controllers
{
    public class HoldingTableController : Controller
    {
        private PerformanceContext db = new PerformanceContext();

        //
        // GET: /HoldingTable/

        public ActionResult Index()
        {
            return View(db.HoldingTables.ToList());
        }

        public ActionResult Show()
        {
            
            List<DisplayModel> displayModelList = new List<DisplayModel>();


            List<HoldingTable> holdingTableList = db.HoldingTables.ToList();
            List<InvestmentTree> investmentTreeList = db.InvestmentTrees.ToList();
            List<string> splitTypeList = new List<string>();
            
            List<string> portList = new List<string>();
            List<string> mportList = new List<string>();
            foreach (InvestmentTree tree in investmentTreeList)
            {
                splitTypeList.Add(tree.SplitType);
                if(tree.SplitType == "Portfolio")
                {
                    foreach (HoldingTable holdingTable in holdingTableList)
                    {
                        if (portList.IndexOf(holdingTable.PortfolioName) < 0)
                        {
                            portList.Add(holdingTable.PortfolioName);
                        }
                    }
                }
                if (tree.SplitType == "Model portfolio")
                {
                    foreach (HoldingTable holdingTable in holdingTableList)
                    {
                        if (mportList.IndexOf(holdingTable.ModelPortfolioName) < 0)
                        {
                            mportList.Add(holdingTable.ModelPortfolioName);
                        }
                    }
                }
            }
            foreach (string type in splitTypeList)
            {
                foreach (string port in portList)
                {
                    DisplayModel display = new DisplayModel();
                    display.Name = port;
                    foreach (HoldingTable holdingTable in holdingTableList)
                    {
                        if (holdingTable.PortfolioName == port)
                        {
                            display.Value += holdingTable.MarketValue;
                        }
                    }
                    displayModelList.Add(display);
                }
                foreach (string mport in mportList)
                {
                    DisplayModel display = new DisplayModel();
                    display.Name = mport;
                    foreach (HoldingTable holdingTable in holdingTableList)
                    {
                        if (holdingTable.PortfolioName == mport)
                        {
                            display.Value += holdingTable.MarketValue;
                        }
                    }
                    displayModelList.Add(display);
                }
            }


            return View(displayModelList);
        }

        //
        // GET: /HoldingTable/Details/5

        public ActionResult Details(int id = 0)
        {
            HoldingTable holdingtable = db.HoldingTables.Find(id);
            if (holdingtable == null)
            {
                return HttpNotFound();
            }
            return View(holdingtable);
        }

        //
        // GET: /HoldingTable/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /HoldingTable/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HoldingTable holdingtable)
        {
            if (ModelState.IsValid)
            {
                db.HoldingTables.Add(holdingtable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(holdingtable);
        }

        //
        // GET: /HoldingTable/Edit/5

        public ActionResult Edit(int id = 0)
        {
            HoldingTable holdingtable = db.HoldingTables.Find(id);
            if (holdingtable == null)
            {
                return HttpNotFound();
            }
            return View(holdingtable);
        }

        //
        // POST: /HoldingTable/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HoldingTable holdingtable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(holdingtable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(holdingtable);
        }

        //
        // GET: /HoldingTable/Delete/5

        public ActionResult Delete(int id = 0)
        {
            HoldingTable holdingtable = db.HoldingTables.Find(id);
            if (holdingtable == null)
            {
                return HttpNotFound();
            }
            return View(holdingtable);
        }

        //
        // POST: /HoldingTable/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HoldingTable holdingtable = db.HoldingTables.Find(id);
            db.HoldingTables.Remove(holdingtable);
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