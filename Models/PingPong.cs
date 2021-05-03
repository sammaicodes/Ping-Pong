using System;

namespace PingPongGame.Models {
  public class PingPong
  {
    private int _number;
    public PingPong(int number)
    {
      _number = number;
    }

    public int GetNumber() 
    {
      return _number;
    }
    public bool Divisible(int number)
    {
      _number = number;
      if (number % 15 == 0 || number % 3 == 0 || number % 5 == 0) 
      {
        return true;
      }
      return false;
    }

    public string PingPongConversion(int number)
    {
      _number = number;
      if (number % 15 == 0)
      {
        return "Ping-Pong";
      }
      else if (number % 3 == 0)
      {
        return "Ping";
      }
      else 
      {
        return "Pong";
      }
    }  
  }
}