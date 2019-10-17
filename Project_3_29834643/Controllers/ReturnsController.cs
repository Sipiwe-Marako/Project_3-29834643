using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_3_29834643.Models.Repository;
using Project_3_29834643.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace Project_3_29834643.Controllers
{
    public class ReturnsController : Controller
    {
        private ReturnsCollection thereturns = new ReturnsCollection();
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult listOfReturns()
        {

            return View(thereturns.SelectAll());
        }
        [Authorize]
        public IActionResult ReturnsChart()
        {
            int[] rettotals = thereturns.returnsInRegion();
            string[] labels = thereturns.regionname;

            string returnsarray = Newtonsoft.Json.JsonConvert.SerializeObject(rettotals);
            ViewBag.TheReturnTotals = returnsarray;
            

            string returnlabels = Newtonsoft.Json.JsonConvert.SerializeObject(labels); ;
            ViewBag.TheReturnlabels = returnlabels;
            return View();
        }
    }
}