using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CdOrganizer.Controllers;
using CdOrganizer.Models;

namespace CdOrganizer.Tests
{
    [TestClass]
    public class CDsControllerTest
    {

      [TestMethod]
      public void Index_HasCorrectModelType_CDList()
      {
          //Arrange
          ViewResult indexView = new CDsController().Index() as ViewResult;

          //Act
          var result = indexView.ViewData.Model;

          //Assert
          Assert.IsInstanceOfType(result, typeof(List<CD>));
      }

      [TestMethod]
      public void Create_RedirectsToCorrectAction_Index()
      {
          //Arrange
          CDsController controller = new CDsController();
          RedirectToActionResult actionResult = controller.Create("The Number Of The Beast") as RedirectToActionResult;

          //Act
          var result = actionResult.ActionName;

          //Assert
          Assert.AreEqual(result, "Index");
      }

    }
}
