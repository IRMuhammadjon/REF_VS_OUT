// C# program to illustrate the
// concept of ref parameter
using System;

class GFG
{

	
	public static void Main()
	{

		
		string str = "muhammadjon";

	
		SetValue(ref str);

		Console.WriteLine(str);
	}

	static void SetValue(ref string str1)
	{

		if (str1 == "muhamamdjon")
		{
			Console.WriteLine("Salom! MUhammadjon");
		}

		str1 = "Rahmatullayev ";
	}
}
