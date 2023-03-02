using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Controllers
{
  public class CDController : Controller
  {
    [HttpGet("/cd")]
    public ActionResult Index()
    {
      List<CD> allCDs = CD.GetAll();
      return View(allCDs);
    }
    
    [HttpGet("/cd/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/cd")]
    public ActionResult Create(string cdName, string artistName)
    {
      CD newCD = new CD(cdName, artistName);
      return RedirectToAction("Index");
    }

    [HttpGet("/cd/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      CD selectedCD = CD.Find(id);
      List<Track> tracks = selectedCD.Tracks;
      model.Add("cd", selectedCD);
      model.Add("tracks", tracks);
      return View(model);
    }

    [HttpPost("/cd/{cdId}/tracks")]
    public ActionResult Create(int cdId, string trackName)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      CD foundCD = CD.Find(cdId);
      Track newTrack = new Track(trackName);
      foundCD.AddTrack(newTrack);
      List<Track> CDTracks = foundCD.Tracks;
      model.Add("tracks", CDTracks);
      model.Add("cd", foundCD);
      return View("Show", model);
    }
  }
}