using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string Amount { get; }

    public Bread(string amount)
    {
      Amount = amount;
    }
  } 
}