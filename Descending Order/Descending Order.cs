using System;
using System.Collections.Generic;

public static class Kata
{
	public static int DescendingOrder(int num)
	{
		var digits = new List<int>();

		while (num > 0)
		{
			digits.Add(num % 10); //use modulo to separate digits
			num /= 10;
		}

		digits.Sort(); // first sort from 0-9
		digits.Reverse(); // then sort from 9-0 which is asked in this task

		int [] array=digits.ToArray();

		int finalScore = 0;
		for (int i = 0; i < array.Length; i++)
		{
			finalScore += array[i] * Convert.ToInt32(Math.Pow(10, array.Length-i-1));
		}


		return finalScore;
	}
}