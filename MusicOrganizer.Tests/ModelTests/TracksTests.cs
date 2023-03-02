using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace Tracks.Tests
{
  [TestClass]
  public class TrackTests
  {
    [TestMethod]

    public void TrackConstructor_CreateInstanceOfTrack_Track()
    {
      Track newTrack = new Track("test");
      Assert.AreEqual(typeof(Track), newTrack.GetType());
    }

    [TestMethod]

    public void GetTrackName_ReturnTrackName_String()
    {
      string trackName = "Frozen";
      Track newTrack = new Track(trackName);
      string result = newTrack.TrackName;
      Assert.AreEqual(trackName, result);
    }

    

  }


}



