public class Kata
{
  public static string BreakCamelCase(string str)
  {
    string outcome="";
    for (int i=0; i<str.Length;i++)
    {
      if (char.IsUpper(str[i]))
      {
        outcome+=" ";
        
      }
      outcome+=str[i];
      
    }
    return outcome.Trim();
  }
}