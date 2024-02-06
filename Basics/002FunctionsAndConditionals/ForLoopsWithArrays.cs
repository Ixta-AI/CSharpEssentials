using System;
					
public class Program
{
	public void Main()
	{
		string[] games ={"Tekken", "Guilty Gear", "Persona","Yakuza Like a Dragon: Infinite Wealth"}; //things inside the array are called elements
		Console.WriteLine(games.Length);//this returns the # of elements
		Console.WriteLine(games[2]);//this returns a spacific element
		for (var i = 0; i < games.Length; i++) {Console.WriteLine(i);//nesting a loop lets us write below each individual value
		/*acts like multiplication usfule for visual simple math*/for(int j = 1; j<=3; j++){Console.WriteLine("what a twist" + j);}}
	}
}
