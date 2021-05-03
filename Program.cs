using System;
using System.Collections.Generic;
using PingPongGame.Models;

namespace PingPongGame {
  public class Program
  {
    public static void Main()
    {
      

      Console.WriteLine("Enter a number:");
      string numberString = Console.ReadLine();
      int numberChoice = int.Parse(numberString);

      PingPong gameOne = new PingPong(numberChoice);

      // Span<int> storage = stackalloc int[numberChoice];
      // int num = 1;
      // foreach(ref int item in storage)
      // {
      //   item = num++;
      // }

      // foreach (ref readonly var item in storage)
      // {
      //   Console.Write($"{item}");
      // }
      for (int index = 1; index <= numberChoice; index++)
      {
        if (gameOne.Divisible(index))
        {
          Console.WriteLine(gameOne.PingPongConversion(index));
        }
        else
        {
          Console.WriteLine(index);
        }
      }
    }
  }
}
