using System;

namespace Solution
{
  class Solution
  {
    public static int[,] MultiplicationTable(int size)
    {
      // Declaration of a 2D array.
      int [,] array=new int[size, size];
      
      // Loop from 1 to be able to multiple values later.
      for (int i=1; i<=size; i++)
        {
         for (int j=1; j<=size; j++ )
         { 
      // Add -1 to start with index 0, since loop begins from number 1.    
          array[i-1, j-1]=i*j;
         }
        }

     return array;   
      
    }
  }
}