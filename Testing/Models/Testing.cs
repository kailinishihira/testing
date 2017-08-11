using System.Collections.Generic;
using System;

namespace Testing.Models
{

  public class Test
  {
    private string _test;

    public Test (string test)
    {
      _test = test;
    }

    public string GetTest()
    {
      return _test;
    }

    public string Tests()
    {
      return "hello";
    }
  }
}
