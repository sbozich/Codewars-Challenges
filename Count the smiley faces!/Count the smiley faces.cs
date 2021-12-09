using System.Linq;

public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
     
    
    int count=0;
    if (smileys.Length==0) return count;
    else 
    {
    
		string [] arrS={":)", ":D", ":-)", ":~)", ":-D", ":~D", ";)", ";D", ";-)", ";~)", ";-D", ";~D"};
		for (int i=0; i<arrS.Length; i++)
		count+=smileys.Count(s=>s ==arrS[i]);

     
     return count ;
	}
  }
}