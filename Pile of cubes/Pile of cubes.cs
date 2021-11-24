using System;

public class ASum {
  
  public static long findNb(long m) {
    
        double res=(Math.Sqrt(Math.Sqrt(m)*2));
        long squareM=(long) Math.Sqrt(m);
        if (squareM*squareM !=m) return -1;

        long delta=1+8*squareM;
        long squareDelta=(long) Math.Sqrt(delta);
        if (squareDelta*squareDelta!=delta) return -1;

        return (squareDelta-1)/2;
    
  }
  
}