using System;

public class Persist 
{
  public static int Persistence(long n) 
  {
      
    int product=1;
    int persistence=0;

    if (n<10) return persistence;
    else
    {
    while (n>9)
    {
      while (n!=0)
      {
        product*= (int) n%10;
        n=n/10;
      }
      persistence++;

    n=product;
    product=1;
     
  }

}
return persistence;
    
  }
}