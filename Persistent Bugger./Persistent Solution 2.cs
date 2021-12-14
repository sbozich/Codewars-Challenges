using System.Collections.Generic;

using System;

public class Persist 
{
  public static int Persistence(long n) 
  {
    
     if (n<10) 
     {
       return 0;
     }

     long persistence=1;
     while (n>0)
     {
       persistence*=n%10;
       n/=10;
     }
     // Using a recursive function.
     return 1+Persistence(persistence);
    
  }
}