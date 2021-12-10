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
      Bread testBread = new Bread("3");
      Assert.AreEqual(typeof(String), testBread.Amount.GetType());
    }
    [TestMethod]
    public void GetBreadAmount_ReturnsAString_Returns3()
    {
      Bread testBread = new Bread("3");
      Assert.AreEqual("3", testBread.Amount);
    }
    [TestMethod]
    public void GetBreadAmount_ReturnsPriceForAmount_int()
    {
      Assert.AreEqual(Bread.GetBreadPrice("3"), 10);
      Assert.AreEqual(Bread.GetBreadPrice("sEven"), 25);
      Assert.AreEqual(Bread.GetBreadPrice("12"), 40);
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry testPastry = new Pastry("3");
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
    [TestMethod]
    public void GetPastryAmount_ReturnsAString_String()
    {
      Pastry testPastry = new Pastry("3");
      Assert.AreEqual(typeof(String), testPastry.Amount.GetType());
    }
    [TestMethod]
    public void GetPastryAmount_ReturnsAString_Returns3()
    {
      Pastry testPastry = new Pastry("3");
      Assert.AreEqual("3", testPastry.Amount);
    }
    [TestMethod]
    public void GetPastryAmount_ReturnsPriceForAmount_int()
    {
      Assert.AreEqual(Pastry.GetPastryPrice("1"), 2);
      Assert.AreEqual(Pastry.GetPastryPrice("thrEe"), 5);
      Assert.AreEqual(Pastry.GetPastryPrice("6"), 10);
    }

  }
}