using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string Amount { get; }
    private static Dictionary<string, int> BreadDictionary = new Dictionary<string, int>()
    {
      {"1", 5}, {"one", 5}, {"2",10}, {"two",10}, {"3", 10}, {"three", 10}, {"4", 15}, {"four", 15}, {"5", 20}, {"five", 20}, {"6", 20}, {"six", 20}, {"7", 25}, {"seven", 25}, {"8", 30}, {"eight", 30}, {"9", 30}, {"nine", 30}, {"10", 35}, {"ten", 35}, {"11", 40}, {"eleven", 40}, {"12", 40}, {"twelve", 40}, {"13", 45}, {"thirteen", 45},
    };

    public Bread(string amount)
    {
      Amount = amount;
    }

    public static int GetBreadPrice(string number)
    {
      return BreadDictionary[number.ToLower()];
    }
  } 

  public class Pastry
  {
    public string Amount { get; }
    private static Dictionary<string, int> PastryDictionary = new Dictionary<string, int>()
    {
      {"1", 2}, {"one", 2}, {"3", 5}, {"three", 5}, {"4", 7}, {"four", 7}, {"5", 9}, {"five", 9}, {"6", 10}, {"six", 10}
    };

    public Pastry(string amount)
    {
      Amount = amount;
    }

    public static int GetPastryPrice(string number)
    {
      return PastryDictionary[number.ToLower()];
    }
  } 
}