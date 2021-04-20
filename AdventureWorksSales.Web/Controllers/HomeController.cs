using AdventureWorksSales.Web.Data;
using AdventureWorksSales.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorksSales.Web.Controllers
{
    public class HomeController : Controller
    {
        private AdventureWorksSalesWebContext db = new AdventureWorksSalesWebContext();

        public ActionResult Index()
        {
            int totalOrder = db.SalesOrders.Count();
           
            decimal highestLineTotal = db.SalesOrders.Select(s => s.LineTotal).DefaultIfEmpty(0).Max();
            var frontBreak = db.Products.Where(s => s.Name == "Front Brakes").FirstOrDefault();

            if(frontBreak != null)
            {
                var totalFrontBreak = db.SalesOrders.Where(s => s.ProductID == frontBreak.ProductID)
                    .Sum(d => d.UnitPrice * d.OrderQty);
                ViewBag.TotalFrontBreak = totalFrontBreak;
            }
               
            ViewBag.TotalOrder = totalOrder;
            ViewBag.HighestLineTotal = highestLineTotal;
           
            return View();
        }

    }
}