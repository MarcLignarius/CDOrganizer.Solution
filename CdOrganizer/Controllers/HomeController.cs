using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
       return View();
      // CD firstCD = new CD("Add first CD to the organizer");
      // return View(firstCD); // Makes Index_ReturnsCorrectView_True() pass
      // //return new EmptyResult(); //Makes Index_ReturnsCorrectView_True() fail
    }

  }
}
