using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string Amount { get; }
    private static Dictionary<string, int> BreadDictionary = new Dictionary<string, int>()
    {
      {"1", 5}, {"2",10}, {"3", 10}, {"4", 15}, {"5", 20}, {"6", 20}, {"7", 25}, {"8", 30}, {"9", 30}, {"10", 35}, {"11", 40}, {"12", 40}, {"13", 45},
    };

    public Bread(string amount)
    {
      Amount = amount;
    }
  } 
}