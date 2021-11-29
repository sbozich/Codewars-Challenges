using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
      Array.Sort(seq);
      
      List<int> lista=new List<int>();
      
      for (int i=0; i<seq.Length; i++)
      {
        // This adds in a list number of repetitions of array seq's elements.  
        lista.Add(seq.Count(a => a == (seq[i])));
      }
      
        // Loop finds first odd number in the list and puts it at the last place.
        // According to the specifications, there is only one number with an odd number of repetitions.
        // This finds only first odd number which is repetition, not the actual number though!
      for (int i=0; i<lista.Count; i++)
      {
        if (lista[i]%2!=0)
        {
          lista.Add(lista[i]);
         
          break;
          
        }
      
      }
        // Here we search for a position of a number in the list, because the length of list and
        // original array seq is equal, we find the number.
        int index = Array.IndexOf(lista.ToArray(), lista.Last());
    
        return seq[index];
      
      
      
      }
       
    }
}