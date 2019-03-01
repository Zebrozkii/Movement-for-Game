using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest
  {
    [TestMethod]

    public void GetName()
    {
      string name = "Jimmy Zebroski";
      Stylist test = new Stylist(name);
      Assert.AreEqual(name,"Jake");
    }
  }
}
