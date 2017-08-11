using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Testing.Models;

namespace Testing.Tests
{
  [TestClass]
  public class TestTest : IDisposable
  {
    [TestMethod]
    public void Test()
    {
      //Arrange
      Test test = new Test ("testing");
      string expected = test.Tests("false");
      List<string> expected = new List<string> {"expectedOutput"};
      ClassName newVariable = new ClassName("input");

      //Act
      string actual = test.Tests()

      //Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
