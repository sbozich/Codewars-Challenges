public class NumberTranslation
{
	public static string Number2Words(int n)
	{
		string outcome = "";
		
		if (n == 0)
		outcome="zero";

		if ((n / 1000) > 0)
		{ 
			if (n%1000==0 && n%100==0 && n%10==0)
			{
				outcome += Number2Words(n / 1000) + " thousand";
				n %= 1000;
			}
			else
			{
				outcome += Number2Words(n / 1000) + " thousand ";
				n %= 1000;
			}
		}

		if ((n / 100) > 0)
		{ 
			if (n%100==0 && n%10==0)
			{
				outcome += Number2Words(n / 100) + " hundred";
				n %= 100;
			}
			else
			{
				outcome += Number2Words(n / 100) + " hundred ";
				n %= 100;
			}
		}

		// Define main recursive part of the function.
		if (n > 0)
		{
			var onesteens = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
			var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

			if (n < 20)
			outcome += onesteens[n];
			else
			{
				outcome += tens[n / 10];
				if ((n % 10) > 0)
				outcome += "-" + onesteens[n % 10];
			}
		}

		return outcome;
	}
}