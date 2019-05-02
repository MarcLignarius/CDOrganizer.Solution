using Microsoft.VisualStudio.TestTools.UnitTesting;
using CdOrganizer.Models;

namespace CdOrganizer.Tests
{
  [TestClass]
  public class CDTest
  {

      [TestMethod]
      public void ItemConstructor_CreatesInstanceOfItem_Item()
      {
          //Arrange
          CD newCd = new CD("Number");

          //Assert
          Assert.AreEqual(typeof(CD), newCd.GetType()); //Makes this test pass
          // Assert.AreEqual(typeof(int), newCd.GetType()); //Makes this test fail
      }

  }
}
