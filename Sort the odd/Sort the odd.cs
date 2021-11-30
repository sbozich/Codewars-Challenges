using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] SortArray(int[] array)
  {
   List<int> listOdd=new List<int>();
   foreach (int i in array) 
	if (i%2!=0) 
		{
			listOdd.Add(i);
		}
	int [] oddArr=listOdd.ToArray();
    Array.Sort(oddArr);

   for (int i=0, j=0; i<array.Length; i++)
   {
     if (array[i]%2!=0)
     {
		array[i]=oddArr[j];
		j++;
     }
   }

    foreach(int i in array) Console.WriteLine(i);
	return array;
  }
}