using System;
using Bakery.Models;

namespace UI
{
  public class Program
  {
    static void Main ()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! 'Finest Dough You'll Ever Know!' What can I get for you today? Bread, Pastries, or both?");
      string answer = (Console.ReadLine()).ToLower();
      if (answer == "bread") 
      {
        Console.WriteLine("How many loaves would you like? They're $5 each and we're currently doing a 'buy 2, get 1 free' deal. For supply reasons, I can only sell up to 12 loaves per customer.");
        string number = (Console.ReadLine()).ToLower();
        Bread breadPurchase = new Bread(number);
        int breadTotal = breadPurchase.GetBreadPrice(number);
        Console.WriteLine("Lovely. That'll be $" + breadTotal.ToString() + " total. Have a great day! Tell your friends!");
      }
      else if ((answer == "pastries") || (answer == "pastry"))
      {
        Console.WriteLine("How many pastries are we getting today? They're each 2$, but if you buy in bulk, I'll reduce the total cost by $1. If you buy six, I'll make it an even $10.");
        string number = (Console.ReadLine()).ToLower();
        Pastry pastryPurchase = new Pastry(number);
        int pastryTotal = pastryPurchase.GetPastryPrice(number);
        Console.WriteLine(" That'll be $" + pastryTotal.ToString() + " total! Have yourself a wonderful day, and try to enjoy those pastries as much as I enjoyed making them!");
      }
      else if (answer == "both")
      {
        Console.WriteLine("Sure thing! Let's start with the bread. Bread goes for $5 each and we're having a 'buy 2, get 1 free' deal. Also, I can only sell up to 12 loaves per customer. How many loaves are we picking up?");
        string breadNumber = (Console.ReadLine()).ToLower();
        Bread breadPurchase = new Bread(breadNumber);
        int breadTotal = breadPurchase.GetBreadPrice(breadNumber);
        Console.WriteLine("Your order currently totals $" + breadTotal.ToString() + ". Now for the pastries. They're each 2$, but if you buy in bulk, I'll reduce the total cost by $1. If you buy six, I'll make it an even $10.");
        string pastryNumber = (Console.ReadLine()).ToLower();
        Pastry pastryPurchase = new Pastry(pastryNumber);
        int pastryTotal = pastryPurchase.GetPastryPrice(pastryNumber);
        int finalTotal = breadTotal + pastryTotal;
        Console.WriteLine("Alrighty. $" + breadTotal.ToString() + " for the bread, plus $" + pastryTotal.ToString() + " for the pastries brings your total to $" + finalTotal.ToString() + ". Thanks for visiting Pierre's today! Hope to see you again soon.");
      }
      }
    }
  }
