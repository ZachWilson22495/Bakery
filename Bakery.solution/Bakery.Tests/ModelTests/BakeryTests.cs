using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Models.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread testBread = new Bread("3");
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void GetBreadAmount_ReturnsAString_String()
    {
      Bread testBread = new Bread ("3");
      Assert.AreEqual(typeof(String), testBread.Amount.GetType());
    }

  }
}