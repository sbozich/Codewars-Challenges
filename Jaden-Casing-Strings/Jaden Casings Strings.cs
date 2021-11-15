//C# 

using System;
using System.Globalization;

public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    char [] array=phrase.ToCharArray();
    
    if (array.Length>=1)
      {
      if (char.IsLower(array[0]))
        {array[0]=char.ToUpper(array[0]);}
    }
    
    for (int i=1; i<array.Length; i++) 
            {
          if (array[i-1]==' ')
                {
          if (char.IsLower(array[i]))
          {
                    array[i]=char.ToUpper(array[i]);
          }
                }
            }
    return (new string(array));
  }
}