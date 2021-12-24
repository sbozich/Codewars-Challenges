using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
	public static string DuplicateEncode(string word)
	{

		List <string> lista=new List<string>();
		List <string> lista2=new List<string>();
		List <int> lista3=new List<int>();
		word=word.ToLower();

		for(int i=0; i<word.Length;i++)
		lista2.Add(word[i].ToString());

		string [] wordArr=lista2.ToArray();

		List<string> listWord=wordArr.ToList();
		
		var distinctArray = lista2.Distinct().ToArray();
		
		if (word.Length==distinctArray.Length)
		for (int i=0; i<word.Length; i++)
		for(int j=0; j<i; j++)
		if (word[i]!=word[j])   
		return new string('(', word.Length);


		// Find repeating chars.            
		if (word.Length!=distinctArray.Length)
		for (int i=0; i<word.Length; i++)
		for (int j=0; j<i; j++)
		if (word[i]==word[j])
		lista.Add(word[i].ToString());

		var distinctArrayReps = lista.Distinct().ToArray();

		// Find the positions of the repeating chars.
		for (int i=0; i<distinctArrayReps.Length; i++)
		for (int j=0; j<word.Length; j++)
		if (distinctArrayReps[i]==word[j].ToString())
		lista3.Add(j);

		// Convert brackets to ASCII code to not interfere with input with brackets.
		int leftbracketASCII=Convert.ToInt32('(');
		int rightbracketASCII=Convert.ToInt32(')');
		
		// Convert repeating chars with corresponding bracket detected by ASCII code.
		// If we detect bracket only as a char, it will mess up brackets count in a test string.
		for (int i=0; i<lista3.Count; i++)
		listWord[lista3[i]]=Convert.ToInt32(char.Parse(")")).ToString();
		

		// Convert chars that do not repeat with corresponding bracket.
		for (int i=0; i<listWord.Count; i++)
		if (listWord[i]!=rightbracketASCII.ToString())
		listWord[i]=leftbracketASCII.ToString();
		
		// Some needed conversions to get string output.
		List <string> outcLista=new List<string>();
		foreach (string x in listWord) 
		outcLista.Add(((char)Convert.ToInt32(x)).ToString());
		string [] outcomeArr=outcLista.ToArray();

		string outcome = string.Join( "", outcLista.ToArray() );
		

		return outcome;
	}
	
}