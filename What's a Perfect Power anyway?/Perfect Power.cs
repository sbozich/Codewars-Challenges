using System;
using System.Collections.Generic;
public class PerfectPower
{
	public static (int, int)? IsPerfectPower(int n)
	{
		
		if (n<2) return null;
		List <int> lista=new List<int> ();
		int [] arr1=new int [500] ;
		int [] arr2=new int [500] ;
		for (int i=2; i<arr1.Length;i++)
		{
			arr1[i]=i;
		}

		for (int i=2; i<arr2.Length;i++)
		{
			arr2[i]=i;
		}

		for (int i=0; i<arr1.Length;i++)
		for (int j=0; j<arr2.Length; j++)
		if (Math.Pow(i,j)==n && i!=1 && j!=1)
		lista.AddRange(new List<int>() {i,j});

		if (lista.Count>0)
		{
			int a=lista[0];
			int b=lista[1];
			return (a,b);
		}
		else return null;
		

	}
	
}