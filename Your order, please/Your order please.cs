using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Kata
{
  public static string Order(string words)
  {
    if (words.Length==0)
		return String.Empty;
    else 
    {
		string [] array=words.Split(" ");
      
		// Using regex filter only numbers to be able to sort it lately.   
		string numberOnly = Regex.Replace(words, "[^0-9.]", "");
		int number=int.Parse(numberOnly);
		int [] numbers=new int[numberOnly.ToString().Length];
		var result=new List<int>();
      
		// Convert int number to list.  
		while (number!=0)
		{
			result.Insert(0, number%10);
			number=number/10;
		}
      
		// And then convert to array.  
		int [] arr=result.ToArray();
		var outcome=new List<string>();
      
		// Using one array as a key values to sort another one.
		Array.Sort(arr,array);
		Array.ForEach<string>(array, s => outcome.Add(s));
		string outcomeArr = string.Join( " ", outcome);
		return outcomeArr;
    }
  }
}