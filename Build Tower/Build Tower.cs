using System.Collections.Generic;

public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
     int blank=nFloors*2-1;
     List <string> lista=new List<string>(); 
	 // create a list because of the array's indexing limitations
     int j;
     for(j=1;j<nFloors*2;j+=2) // looping from 1 with +2 to get an odd numbers
     {
       //creating strings of spaces before stars and after and joining them with concantenation with stars 
       lista.Add(((new string(' ', (blank-j)/2))+(new string('*', j)))+(new string(' ', (blank-j)/2)));
     }
       
        return lista.ToArray();   
  }
}