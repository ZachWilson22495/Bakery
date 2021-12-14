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
        if ((number == "1") || (number == "one") || (number == "2") || (number == "two") || (number == "3") || (number == "three") || (number == "4") || (number == "four") || (number == "5") || (number == "five") || (number == "6") || (number == "six") || (number == "7") || (number == "seven") || (number == "8") || (number == "eight") || (number == "9") || (number == "nine") || (number == "10") || (number == "ten") || (number == "11") || (number == "eleven") || (number == "12") || (number == "twelve"))
        {
          Bread breadPurchase = new Bread(number);
          int breadTotal = breadPurchase.GetBreadPrice(number);
          Console.WriteLine("Lovely. That'll be $" + breadTotal.ToString() + " total. Have a great day! Tell your friends!");
        }
        else
        {
          Console.WriteLine("Can't sell ya that much. Sorry boss.");
        }
      }
      else if ((answer == "pastries") || (answer == "pastry"))
      {
        Console.WriteLine("How many pastries are we getting today? They're each 2$, but if you buy in bulk, I'll reduce the total cost by $1. If you buy six, I'll make it an even $10.");
        string number = (Console.ReadLine()).ToLower();
        if ((number == "1") || (number == "one") || (number == "2") || (number == "two") || (number == "3") || (number == "three") || (number == "4") || (number == "four") || (number == "5") || (number == "five") || (number == "6") || (number == "six"))
        {
          Pastry pastryPurchase = new Pastry(number);
          int pastryTotal = pastryPurchase.GetPastryPrice(number);
          Console.WriteLine(" That'll be $" + pastryTotal.ToString() + " total! Have yourself a wonderful day, and try to enjoy those pastries as much as I enjoyed making them!");
        }
        else
        {
          Console.WriteLine("Can't sell ya that much. Sorry boss.");
        }
      }
      else if (answer == "both")
      {
        Console.WriteLine("Sure thing! Let's start with the bread. Bread goes for $5 each and we're having a 'buy 2, get 1 free' deal. Also, I can only sell up to 12 loaves per customer. How many loaves are we picking up?");
        string breadNumber = (Console.ReadLine()).ToLower();
        if ((breadNumber == "1") || (breadNumber == "one") || (breadNumber == "2") || (breadNumber == "two") || (breadNumber == "3") || (breadNumber == "three") || (breadNumber == "4") || (breadNumber == "four") || (breadNumber == "5") || (breadNumber == "five") || (breadNumber == "6") || (breadNumber == "six") || (breadNumber == "7") || (breadNumber == "seven") || (breadNumber == "8") || (breadNumber == "eight") || (breadNumber == "9") || (breadNumber == "nine") || (breadNumber == "10") || (breadNumber == "ten") || (breadNumber == "11") || (breadNumber == "eleven") || (breadNumber == "12") || (breadNumber == "twelve"))
        {
          Bread breadPurchase = new Bread(breadNumber);
          int breadTotal = breadPurchase.GetBreadPrice(breadNumber);
          Console.WriteLine("Your order currently totals $" + breadTotal.ToString() + ". Now for the pastries. They're each 2$, but if you buy in bulk, I'll reduce the total cost by $1. If you buy six, I'll make it an even $10.");
          string pastryNumber = (Console.ReadLine()).ToLower();
          if ((pastryNumber == "1") || (pastryNumber == "one") || (pastryNumber == "2") || (pastryNumber == "two") || (pastryNumber == "3") || (pastryNumber == "three") || (pastryNumber == "4") || (pastryNumber == "four") || (pastryNumber == "5") || (pastryNumber == "five") || (pastryNumber == "6") || (pastryNumber == "six"))
          {
            Pastry pastryPurchase = new Pastry(pastryNumber);
            int pastryTotal = pastryPurchase.GetPastryPrice(pastryNumber);
            int finalTotal = breadTotal + pastryTotal;
            Console.WriteLine("Alrighty. $" + breadTotal.ToString() + " for the bread, plus $" + pastryTotal.ToString() + " for the pastries brings your total to $" + finalTotal.ToString() + ". Thanks for visiting Pierre's today! Hope to see you again soon.");
          }
          else
          {
            Console.WriteLine("Can't sell ya that much. Sorry boss.");
          }
        }
        else
        {
          Console.WriteLine("Can't sell ya that much. Sorry boss.");
        }
      }
      else 
      {
        Console.WriteLine("What was that? I don't think I sell those. Could you say that again? Pierre's ears aren't what they used to be.");
      }
    }
  }
}
