using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace Tracks.Tests 
{
  [TestClass]
  public class TrackTests : IDisposable
  {
    public void Dispose()
    {
      Track.ClearAll();
    }

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

    [TestMethod]

    public void SetTrackName_SetTrackName_String()
    {
      string trackName = "Frozen";
      Track newTrack = new Track(trackName);
      string updatedTrackName = "Frozen 2";
      newTrack.TrackName = updatedTrackName;
      string result = newTrack.TrackName;
      Assert.AreEqual(updatedTrackName, result);
    }

    [TestMethod]

    public void GetAll_ReturnsEmptyList_TrackList()
    {
      List<Track> newTrackList = new List<Track> { };
      List<Track> result = Track.GetAll();
      CollectionAssert.AreEqual(newTrackList, result);
    }

    [TestMethod]

    public void GetAll_ReturnsTracks_TrackList()
    {
      string songName1 = "Frozen";
      string songName2 = "Frozen 2";
      Track newTrack1 = new Track(songName1);
      Track newTrack2 = new Track(songName2);
      List<Track> newTrackList = new List<Track> { newTrack1, newTrack2 };
      List<Track> result = Track.GetAll();
      CollectionAssert.AreEqual(newTrackList, result);
    }

    [TestMethod]

    public void Find_ReturnsCorrectTrack_Track()
    {
      string songName1 = "Frozen";
      string songName2 = " Frozen 2";
      Track newTrack1 = new Track(songName1);
      Track newTrack2 = new Track(songName2);
      Track result = Track.Find(2);
      Assert.AreEqual(newTrack2, result);
    }
  }
}



