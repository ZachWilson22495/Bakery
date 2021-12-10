namespace Bakery.Models.Tests
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread testBread = new Bread("3");
      Assert.AreEqual(typeof(Bread), testBread.GetBread());
    }

  }
}