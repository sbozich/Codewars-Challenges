using System;
using System.Collections.Generic;
using System.Numerics;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
     
      List<int> lista=new List<int>();
     
      // Using BigInteger type of data because Math.Pow don't function with long type.
      List<BigInteger> lista2=new List<BigInteger>();
 
      string numbers=num.ToString();
    
      for (int i=0; i<numbers.Length; i++)
      {
        lista.Add(int.Parse(numbers[i].ToString()));
      }
    
    // Using loop with a two iterators, 'i' to iterate list elements and 'j' for power.
    // Note how boundaries with two iterators can be set with &&.
    for (int i=0, j=lista.Count-1; i<lista.Count && j>-1; i++, j--)
    {
        if (lista[i]!=0)
     // Math.Pow doesn't function with long datatype so using BigInteger.Pow.   
        lista2.Add((lista[i])*(BigInteger.Pow(10,j)));
    } 
    
    string outcome=string.Join( " + ", lista2);
    return outcome;    
          
    }
}