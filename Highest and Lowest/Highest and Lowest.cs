using System;

public static class Kata
{
	public static string HighAndLow(string numbers)
	{
		string [] array=numbers.Split(" "); //convert to array using spaces as delimiter
		int [] arrayInt=new int [array.Length];
		for (int i=0; i<array.Length;i++)
		{
			arrayInt[i]=Convert.ToInt32(array[i]); //copy values from string to int array with conv.
		}

		Array.Sort(arrayInt); //now we can easily sort the array
		string max=(arrayInt[arrayInt.Length-1]).ToString();
		string min=(arrayInt[0]).ToString();
		return (max+" "+min);
	}
}