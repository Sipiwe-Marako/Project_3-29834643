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
    public class ManagersController : Controller
    {
        private ManagersCollection managers = new ManagersCollection();
        [Authorize]
        public IActionResult Index()

        {
            return View(managers.SelectAll());
        }
        [Authorize]
        public IActionResult listOfManagers()
        {

            return View(managers.SelectAll());
        }
        [HttpPost]
        public ActionResult Create(SuperstoreManagers manager)
        {
            this.managers.InsertManager(manager);
            return RedirectToAction("List", managers.SelectAll());
        }
        public ActionResult Edit(string managersId)
        {
            return View(managers.Get(managersId));
        }

        [Authorize]
        public IActionResult SpecificManager()
        {

            return View(managers.Specific());
        }
        [HttpPost]
        public ActionResult Edit(string Id, SuperstoreManagers manager)
        {
            this.managers.UpdateManager(Id, manager);

            return RedirectToAction("List",
                 managers.SelectAll());
        }

    }
}