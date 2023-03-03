using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class CDTests : IDisposable
  {
    public void Dispose()
    {
      CD.ClearAll();
    }

    [TestMethod]
    public void CDConstructor_CreatesInstanceOfCD_CD()
    {
      CD newCD = new CD("test CD", "test Artist");
      Assert.AreEqual(typeof(CD), newCD.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsCDName_String()
    {
      string name = "Test CD";
      string artist = "Test artist";
      CD newCD = new CD(name, artist);
      string result = newCD.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetArtist_ReturnsCDsArtistName_String()
    {
      string name = "Test CD";
      string artist = "Test artist";
      CD newCD = new CD(name, artist);
      string result = newCD.Artist;
      Assert.AreEqual(artist, result);
    }

    [TestMethod]
    public void GetId_ReturnsCDId_Int()
    {
      string name = "Test CD";
      string artist = "Test artist";
      CD newCD = new CD(name, artist);
      int result = newCD.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllCDObjects_CDList()
    {
      string name1 = "CD1";
      string name2 = "CD2";
      string artist1 = "Test artist1";
      string artist2 = "Test artist2";
      CD newCD1 = new CD(name1, artist1);
      CD newCD2 = new CD(name2, artist2);
      List<CD> newList = new List<CD> { newCD1, newCD2 };
      List<CD> result = CD.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void AddTrack_AssociatesTrackWithCD_TrackList()
    {
      string trackName = "Frozen";
      Track newTrack = new Track(trackName);
      List<Track> newList = new List<Track> { newTrack };

      string name = "Songs";
      string artist = "Test artist";
      CD newCD = new CD(name, artist);
      newCD.AddTrack(newTrack);

      List<Track> result = newCD.Tracks;
      CollectionAssert.AreEqual(newList, result);
    }
    
    [TestMethod]
    public void FindByArtist_ReturnsAllCDsOfTheArtist_List()
    {
      string name = "Disk1";
      string artist = "Singer1";
      CD newCD = new CD(name, artist);
      List<CD> newCD1 = new List<CD> { newCD };
      List<CD> result = CD.FindByArtist(artist);
      CollectionAssert.AreEqual(newCD1, result);
    }

  }

}