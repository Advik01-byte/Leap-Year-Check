using System;

namespace LeapYearCheck
{
  class Program
  {
    static void Main()
    {
      Console.Write("\nPlease enter a year: ");
      int year = Convert.ToInt32(Console.ReadLine());

      if (!(year % 100 == 0))
      {
        if (year % 4 == 0)
        {
          Console.WriteLine("It is a leap year.\n");
        }
        else
        {
          Console.WriteLine("It is not a leap year.\n");
        }
      }
      else
      {
        if (year % 400 == 0)
        {
          Console.WriteLine("It is a leap year.\n");
        }
        else
        {
          Console.WriteLine("It is not a leap year.\n");
        }
      }
    }
  }
}