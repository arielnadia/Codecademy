using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      CalculateTotalCost();
    }
    public static double Rectangle(double length, double width)
    {
      double area = length * width;
      return area;
    }
    public static double Circle(double radius)
    {
      double area = (Math.PI * Math.Pow(radius, 2)) / 2;
      return area;
    }
    public static double Triangle(double bottom, double height)
    {
      double area = 0.5 * bottom * height;
      return area;
    }
    public static void CalculateTotalCost()
    {
      double rectArea = Rectangle(2500, 1500);
      double circleArea = Circle(375);
      double triArea = Triangle(500, 750);
      double totalArea = rectArea + circleArea + triArea;
      double cost = totalArea * 180;
      Console.WriteLine($"The total cost for this building with {totalArea.ToString("N2")} square feet will be {cost.ToString("N2")} Mexican Pesos.");
    }
  }
}
