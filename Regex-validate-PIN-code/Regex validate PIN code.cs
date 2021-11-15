using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    
        string pattern = "^\\d{4}$";
        string pattern2 = "^\\d{6}$";

        Regex rgx = new Regex(pattern);
        Regex rgx2 = new Regex(pattern2);

        if ((pin.Length==4 || pin.Length==6) && int.TryParse(pin.ToString(), out _))
        {
            if ((rgx.IsMatch(pin) || (rgx2.IsMatch(pin))) )
        {
             return true;  
        }
            else return false;
        }   else return false;
    
  }
}