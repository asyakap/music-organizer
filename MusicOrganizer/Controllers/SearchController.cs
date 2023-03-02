using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
    public class SearchController : Controller
    {

      [HttpGet("/search")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/search/artisttracks")]
      public ActionResult Show(string artist)
      {
        List<CD> artistList = new List<CD> { };
        artistList = CD.FindByArtist(artist);
        return View(artistList);
      }

    }
}

