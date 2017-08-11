using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Testing.Models;

namespace Testing.Tests
{
  [TestClass]
  public class TestTest
  {
    [TestMethod]
    public void Test()
    {
      //Arrange
      Test test = new Test ("testing");
      string expected = "testing";

      //Act
      string actual = test.Tests();

      //Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
