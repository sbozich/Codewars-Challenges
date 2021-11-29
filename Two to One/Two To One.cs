using System;
using System.Linq;

public class TwoToOne 
{
  
  public static string Longest (string s1, string s2) 
  {
        char [] arrayChar=(s1+s2).ToCharArray();
        string [] arrayString=new string [arrayChar.Length];
        
        for (int i=0; i<arrayChar.Length; i++)
        {
			arrayString[i]=arrayChar[i].ToString();
        }
        
        Array.Sort(arrayString);
        string [] arrayStringSorted=arrayString.Distinct().ToArray();
        
        return String.Join("",arrayStringSorted);
  }
}