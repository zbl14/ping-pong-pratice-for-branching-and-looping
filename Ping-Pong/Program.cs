using System;
// using System.Collections.Generic;
// using Ping-Pong.Models;

// namespace Ping-Pong
// {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a number");
      string strCountUpto = Console.ReadLine();
      int countUpTo = int.Parse(strCountUpto);
      Console.WriteLine("----------------------");

      for (int i = 1; i <= countUpTo; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("ping-pong");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("ping");
        }
        else if (i % 5 ==0)
        {
          Console.WriteLine("pong");
        }
        else {
          Console.WriteLine(i);
        }
      }
    }  
  }
// }