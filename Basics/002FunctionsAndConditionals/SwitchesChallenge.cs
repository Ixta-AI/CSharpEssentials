// The Expectation is that you write your own code based
// on what you have learned in the class, it can be what you want
// If you are havind trouble thinging of something, write conditionals
// with the topic of PowerUps, what happens if the powerUp is good or bad.
using System;
					
public class Program
{
	public CharacterSheet Cinfo;//created two classes to combine different info
	public ChoiceMade consequence;//wanted to test stuff out with one extra class
	public void Main()
	{
	Cinfo = new CharacterSheet();//my newly created object
	consequence = new ChoiceMade();
	
	Console.WriteLine("What is your characters name?");
	string userName = Console.ReadLine();
	Console.WriteLine(userName +" What is you're Vitality?");
	int UserVit = Convert.ToInt32(Console.ReadLine());
	
Console.WriteLine("Well welcome " + userName + "!");
		
		
		Console.WriteLine("Look a red mushroom with white spots");
		Console.WriteLine("Will you pick it up or leave it?");
		Console.WriteLine("Write 1 for: Pick up or 2: Leave: "); 
		int UserIn = Convert.ToInt32(Console.ReadLine());
		
		
		Cinfo.Vitality(UserVit);
		consequence.PickedUp(UserIn);
		consequence.DoYouLive(UserVit);
		
	}
}

public class ChoiceMade{ //path created for choices and consequences

	public void PickedUp(int UserIn)
	{
		switch (UserIn){
			case 1:
			Console.WriteLine("You pick up the Power Up");
				break;
			case 2:
				Console.WriteLine("Ignore it and move on");
				break;
			default: 
				Console.WriteLine("Unrecognized input "+ "please use either 1 or 2");
				break;
				}
	}
		public void DoYouLive(int UserVit){//in hind sight to orginize this better powerup effects should be their own class so that they can be used in different areas. as it stands now there could be logic errors created through referencing actions
			if(UserVit >= 12){
				Console.WriteLine("You feel healthier");
					UserVit++;
				Console.WriteLine("Vitality + 1, "+ "New Vit: " + UserVit++);
			}else{
				Console.WriteLine("Died");
			}
		}
}

public class CharacterSheet{//second class created to store character information
	public void Name(string userName){}
/*________________________________________*/
	public void Vitality(int UserVit){}
}
