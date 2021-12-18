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
      string testBread = "3";
      Bread newBreadOrder = new Bread(testBread);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
    [TestMethod]
    public void GetBreadAmount_ReturnsAString_String()
    {
      string testBread = "3";
      Bread newBreadOrder = new Bread(testBread);
      Assert.AreEqual(typeof(String), newBreadOrder.Amount.GetType());
    }
    [TestMethod]
    public void GetBreadAmount_ReturnsAString_Returns3()
    {
      string testBread = "3";
      Bread newBreadOrder = new Bread(testBread);
      Assert.AreEqual("3", newBreadOrder.Amount);
    }
    [TestMethod]
    public void GetBreadAmount_ReturnsPriceForAmount_int()
    {
      string testBread = "3";
      Bread newBreadOrder = new Bread(testBread);
      Assert.AreEqual(newBreadOrder.GetBreadPrice("3"), 10);
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      string testPastry = "3";
      Pastry newPastryOrder = new Pastry(testPastry);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }
    [TestMethod]
    public void GetPastryAmount_ReturnsAString_String()
    {
      string testPastry = "3";
      Pastry newPastryOrder = new Pastry(testPastry);
      Assert.AreEqual(typeof(String), newPastryOrder.Amount.GetType());
    }
    [TestMethod]
    public void GetPastryAmount_ReturnsAString_Returns3()
    {
      string testPastry = "3";
      Pastry newPastryOrder = new Pastry(testPastry);
      Assert.AreEqual("3", newPastryOrder.Amount);
    }
    [TestMethod]
    public void GetPastryAmount_ReturnsPriceForAmount_int()
    {
      string testPastry = "3";
      Pastry newPastryOrder = new Pastry(testPastry);
      Assert.AreEqual(newPastryOrder.GetPastryPrice("3"), 5);
    }

  }
}