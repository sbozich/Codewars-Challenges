using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
        
       List<int> listA=new List<int>(a);
       List<int> listB=new List<int>(b);
       List<int> outcome = new List <int>();
       foreach(int x in listA)
       {
         if(!listB.Contains(x))
         {
           outcome.Add(x);
         }
       }
        
        int [] arr=outcome.ToArray();
        if (arr.Length==0)
			return new int[] {};
        else return arr; 
    
    }  
}