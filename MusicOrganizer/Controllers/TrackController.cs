using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Controllers
{
  public class TrackController : Controller
  {
    [HttpGet("/cd/{cdId}/tracks/new")]
    public ActionResult New(int cdId)
    {
      CD cd = CD.Find(cdId);
      return View(cd);
    }

     [HttpPost("/tracks")]
    public ActionResult Create(string trackName)
    {
      Track myTrack = new Track(trackName);
      return RedirectToAction("Index");
    }

    [HttpGet("/tracks/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/tracks/{id}")]
    public ActionResult Show(int id)
    {
      Track foundTrack = Track.Find(id);
      return View(foundTrack);
    }

    [HttpGet("/cd/{cdId}/tracks/{trackId}")]
    public ActionResult Show(int cdId, int trackId)
    {
      Track track = Track.Find(trackId);
      CD cd = CD.Find(cdId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("track", track);
      model.Add("CD", cd);
      return View(model);
    }
    
  }
}