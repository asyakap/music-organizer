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
      CD newCD = new CD("test CD");
      Assert.AreEqual(typeof(CD), newCD.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsCDName_String()
    {
      string name = "Test CD";
      CD newCD = new CD(name);
      string result = newCD.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsCDId_Int()
    {
      string name = "Test CD";
      CD newCD = new CD(name);
      int result = newCD.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllCDObjects_CDList()
    {
      string name1 = "CD1";
      string name2 = "CD2";
      CD newCD1 = new CD(name1);
      CD newCD2 = new CD(name2);
      List<CD> newList = new List<CD> { newCD1, newCD2 };
      List<CD> result = CD.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

  }

}