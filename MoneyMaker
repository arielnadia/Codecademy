using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.Write("Enter an amount to convert to coins: ");
      double initialValue = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("{0} cents is equal to...", initialValue);
      
      double gold = 10;
      double silver = 5;
      double bronze = 1;
      
      double goldCoins = Math.Floor(initialValue / gold);
      double remainder = initialValue % gold;
      double silverCoins = Math.Floor(remainder / silver);
      remainder = remainder % silver;
      double bronzeCoins = remainder;
      
      Console.WriteLine("Gold Coins: " + goldCoins);
      Console.WriteLine("Silver Coins: " + silverCoins);
      Console.WriteLine("Bronze Coins: " + bronzeCoins);
    }
  }
}
