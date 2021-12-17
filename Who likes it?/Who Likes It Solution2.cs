using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    
    string message="";
    if (name.Length==0) message="no one likes this";
    else if (name.Length==1) message=(name[0]+" likes this");
    else if (name.Length==2) message=(name[0]+" and " +name[1]+ " like this");
    else if (name.Length==3) message=(name[0]+", "+name[1]+" and "+name[2]+" like this");
    else if (name.Length >3) message=(name[0]+", "+name[1]+" and "+ (name.Length-2)+ " others like this");
    
    return message;
    
  }
}