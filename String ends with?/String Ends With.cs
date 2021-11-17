public class Kata
{
  public static bool Solution(string str, string ending)
  {
        int lengthStr=str.Length-1;
        int lengthEnding=ending.Length-1;
        bool outcome;
        
		if (ending.Length==0)
			return true;
        else if (str.Contains(ending) && (ending[lengthEnding].Equals(str[lengthStr])))
			outcome=true;
        else 
			outcome=false;
		
		return outcome;
  }
}