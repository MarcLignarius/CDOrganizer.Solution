using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
  public class ArtistsController : Controller
  {

    [HttpGet("/artists")]
    public ActionResult Index()
    {
        List<Artist> allArtists = Artist.GetAll();
        return View(allArtists);
    }

    [HttpGet("/artists/new")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost("/artists")]
    public ActionResult Create(string artistName)
    {
        Artist newArtist = new Artist(artistName);
        List<Artist> allArtists = Artist.GetAll();
        return View("Index", allArtists);
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Artist selectedArtist = Artist.Find(id);
        List<CD> artistCDs = selectedArtist.GetCD();
        model.Add("artist", selectedArtist);
        model.Add("cd", artistCDs);
        return View(model);
    }

  }

}
