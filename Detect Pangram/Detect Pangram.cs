using System;
using System.Collections.Generic;


public static class Kata
{
  public static bool IsPangram(string str)
  {
    str=str.ToLower(); //to avoid capital leters checking
    string alphabet="abcdefghijklmnopqrstuvwxyz"; 
    List<char>lista=new List<char>();
    for (int i=0; i<alphabet.Length;i++)
    {
        if (str.Contains(alphabet[i]))
        {
            lista.Add(alphabet[i]);
        }
    }
    bool outcome=false;
    if (lista.Count==26) outcome=true;
    return outcome;

  }
}