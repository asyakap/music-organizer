using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Controllers
{
  public class TrackController : Controller
  {
    [HttpGet("/tracks/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/tracks/{trackId}/tracks/new")]
    public ActionResult New(int categoryId)
    {
      Category category = Category.Find(categoryId);
      return View(category);
    }
  }
}