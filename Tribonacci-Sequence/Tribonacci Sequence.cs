using System.Collections.Generic;

public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {

     List<double> lista=new List<double>(signature);
     double sum=0;
     if (n==0)
		return new double [] { };
     else if (n==1)
		{
        return new double [] {lista[0]};
        }
     else if (n==2)
        {
        return new double [] {lista[0], lista[1]};
        }
     else if (n==3)
        {
        return new double [] {lista[0], lista[1], lista[2]};
        }
     else 
		{
        for (int i=0; i<n-3; i++)
        {
        sum=0;
        for (int j=lista.Count-3; j<lista.Count;j++)
            {
            sum+=lista[j];
            }
            lista.Add(sum);
            }
            return lista.ToArray();
            }
    
	}
}