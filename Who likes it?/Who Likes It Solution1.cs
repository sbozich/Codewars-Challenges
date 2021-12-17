using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    
    string message="";
    switch (name.Length)
    {
      case 0:
      message="no one likes this";
      break;
      case 1:
      message=(name[0]+" likes this");
      break;
      case 2:
      message=(name[0]+" and " +name[1]+ " like this");
      break;
      case 3:
      message=(name[0]+", "+name[1]+" and "+ name[2] +" like this");
      break;
      case 4:
      default:
      message=(name[0]+", "+name[1]+" and "+ (name.Length-2)+ " others like this");
      break;

    } 
    
       
    return message;
    
  }
}