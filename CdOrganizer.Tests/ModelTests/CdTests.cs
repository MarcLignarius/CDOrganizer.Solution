using Microsoft.VisualStudio.TestTools.UnitTesting;
using CdOrganizer.Models;
using System.Collections.Generic;

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

      [TestMethod]
      public void GetTitle_ReturnsTitle_String()
      {
          //Arrange
          string title = "Rust In Peace";
          CD newCd = new CD(title);

          //Act
          string result = newCd.GetTitle();

          //Assert
          // Assert.AreEqual("Ride The Lightning", result); //Makes this test fail
          Assert.AreEqual(title, result); //Makes this test pass
      }

      [TestMethod]
      public void SetTitle_SetTitle_String()
      {
          //Arrange
          string title = "Rust In Peace";
          CD newCd = new CD(title);

          //Act
          string updatedTitle = "Master Of Puppets";
          newCd.SetTitle(updatedTitle);
          string result = newCd.GetTitle();

          //Assert
          Assert.AreEqual(updatedTitle, result);
          // Assert.AreEqual(title, result); //Makes this test fail
      }

  }
}
