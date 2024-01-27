//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	public string heroOneName = "Jhon";
    public string heroTwoName = "Dark";
    public string heroThreeName = "Azucina";

    public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();

		heroOne.mana = 7;
        heroOne.health = 2;
		heroOne.powerLevel = 5;
        heroOne.defense = 4;
		
        heroTwo.mana = 2;
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
        heroTwo.defense = 4;

        heroThree.mana = 5;
        heroThree.health = 1;
		heroThree.powerLevel = 4;
        heroThree.defense = 8;

        Console.WriteLine(heroOneName);
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine(heroOne.mana);
        Console.WriteLine(heroOne.defense);

        Console.WriteLine(heroTwoName);
        Console.WriteLine(heroTwo.mana);
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.defense)
        Console.WriteLine(heroTwo.powerLevel);

        Console.WriteLine(heroThreeName);
        Console.WriteLine(heroThree.health);
        Console.WriteLine(heroThree.powerLevel);
        Console.WriteLine(heroThree.mana);
        Console.WriteLine(heroThree.defense);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
    public int defense;
    public int mana;

}