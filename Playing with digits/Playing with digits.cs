using System;
using System.Collections.Generic;

public class DigPow {
  public static long digPow(int n, int p) {
    
    // Preserve original int n.
    int nn=n;
    List<int> lista=new List<int>() ;
    
    // Convert int n to list for easier manipulation.
    while (n != 0) 
	{
		lista.Insert(0, n % 10);
		n = n / 10;
    }
    int [] array=lista.ToArray();
    int sum=0;
    
    // Sum digit powers in list.
    for (int i =0, j=p; i<array.Length; i++)
    {
     sum+=(int)Math.Pow(array[i],j);
     j++;
    }
      
   if (sum/nn*nn==sum) 
     return sum/nn;
   else return -1;
  }
}