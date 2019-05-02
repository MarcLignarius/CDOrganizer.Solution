using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;
using System.Collections.Generic;

namespace CdOrganizer.Controllers
{
    public class CDsController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            List<CD> allCds = CD.GetAll(); //Makes Index_HasCorrectModelType_CDList() pass
            return View(allCds);
            //return View(0); //Makes Index_HasCorrectModelType_CDList() fail
        }

        [Route("/cd/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/cd")]
        public ActionResult Create(string title)
        {
            CD newCD = new CD(title);
            return RedirectToAction("Index"); // makes Create_RedirectsToCorrectAction_Index() pass
            //return RedirectToAction("CreateForm"); // makes Create_RedirectsToCorrectAction_Index() fail
        }
    }
}
