namespace Main{

	using System;
	public class Kata
	{
		public static int[] DataReverse(int[] data)
		{
			string dataString=string.Join("", data);
			string outcome="";
			for (int i=dataString.Length-8; i>=0; i-=8)
			outcome+=dataString.Substring(i,8);

			char [] charArr=outcome.ToCharArray();
			int [] result=new int[charArr.Length];
			for (int i=0; i<charArr.Length; i++)
			result[i]=Convert.ToInt32(charArr[i].ToString());
			
			return result;
			
		}
	}
}