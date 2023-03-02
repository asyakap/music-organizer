using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class CDTests
  {

    [TestMethod]
    public void CDConstructor_CreatesInstanceOfCD_CD()
    {
      CD newCD = new CD("test CD");
      Assert.AreEqual(typeof(CD), newCD.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test CD";
      CD newCD = new CD(name);
      string result = newCD.Name;
      Assert.AreEqual(name, result);
    }


  }

}