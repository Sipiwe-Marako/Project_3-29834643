using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Project_3_29834643.Models.Repository;
using Project_3_29834643.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Project_3_29834643.Controllers
{
    public class OrdersController : Controller
    {
        private OrdersCollection orders = new OrdersCollection();
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult List_of_Orders()
        {

            return View( orders.SelectAll());
        }
        [Authorize]
        public IActionResult OrderOverYears()
        {
           
            int[] yearTotals = orders.OrdersTotals();
            string[] years = { "2012", "2013", "2014", "2015" };

            string theyears = Newtonsoft.Json.JsonConvert.SerializeObject(years);
            ViewBag.TheYears = theyears;

            string totals = Newtonsoft.Json.JsonConvert.SerializeObject(yearTotals);
            ViewBag.JsTotals = totals;

            
            orders.ProductTypesSold();
            //Category of products according to year
            string jsonCategories = Newtonsoft.Json.JsonConvert.SerializeObject(orders.Totals2012);
            ViewBag.jsonCategories = jsonCategories;

            string jsonCategories1 = Newtonsoft.Json.JsonConvert.SerializeObject(orders.Totals2013);
            ViewBag.jsonCategories1 = jsonCategories1;

            string jsonCategories2 = Newtonsoft.Json.JsonConvert.SerializeObject(orders.Totals2014);
            ViewBag.jsonCategories2 = jsonCategories2;
           


            return View();
        }
        [Authorize]
        public IActionResult ShipmentMethod()
        {
            orders.ShipmentPriority();
            //Shipment chart data from the OrdersCollection model class

            string shipLabels = Newtonsoft.Json.JsonConvert.SerializeObject(orders.shipmethods);
            ViewBag.TheShipLabels = shipLabels;

           
            string modesTotals = Newtonsoft.Json.JsonConvert.SerializeObject(orders.ShipmentMode());
            ViewBag.TheShipTotals = modesTotals;


            

            //Shipment total shipping cost
            string totalcost = Newtonsoft.Json.JsonConvert.SerializeObject(orders.same);
            ViewBag.jsoncost = totalcost;
            return View();
        }
        public IActionResult Ships()
        {
            //Shipment mode vs product priority
            orders.ShipmentPriority();
            string jsonlabel = Newtonsoft.Json.JsonConvert.SerializeObject(orders.ptype);
            ViewBag.jsonlabel = jsonlabel;

            string jsonFirst = Newtonsoft.Json.JsonConvert.SerializeObject(orders.first);
            ViewBag.jsonHigh = jsonFirst;

            string jsonSecond = Newtonsoft.Json.JsonConvert.SerializeObject(orders.second);
            ViewBag.jsonMedium = jsonSecond;

            string jsonStandard = Newtonsoft.Json.JsonConvert.SerializeObject(orders.standard);
            ViewBag.jsonLow = jsonStandard;

            string jsonSame = Newtonsoft.Json.JsonConvert.SerializeObject(orders.same);
            ViewBag.jsonCritical = jsonSame;

            return View();
        }
        
    }
}