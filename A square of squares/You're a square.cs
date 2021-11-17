using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
            double test=Math.Truncate((Math.Sqrt(n)));
            if (n<0)
                return false;
            else if (Math.Sqrt(n)==(int)(test)) 
            {
                return true;
            } 
            else 
				return false;
  }
}