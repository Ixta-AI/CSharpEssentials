//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables

/*using System;

public class myClass
{
    public characterClass;
        string characterClass = "Necromancer";
    
    public characterName;
        string characterName = "Azucina";
    
    public characterHight;
        public string mesurment = "ft";
            int characterHight = 7;
    
    public characterType;
        string characterType = "Type 2";
    
    public characterAge;
        int characterAge = 22;
}
    public static void Main(string[] args)
    {
        characterClass = new character();
        
        characterClass.level = 6;
        characterClass.health = 15;
        characterClass.maxMana = 50;
        characterClass.summonMaxCount = 4;

        Console.writeline(characterName);
        Console.WriteLine(characterClass);
        Console.writeline(characterAge);
        Console.writeline(characterType);
        Console.writeline(characterHight);
    }

public class characterClass{
    public int level;
    public int health;
    public int maxMana;
    public int summonMaxCount;
*/
}using System; //always present it allows for the program to interact with the library.
					
public class Program //public is the access modifier (meaning everything can access this and "class" defines a new class or bluprint and Program is the name
{
	public myClass Necromancer; //public lets this be interacted with outside its {} block
 

    public void Main() //Public= method of access, void= no value returned, Main is the name of the method (main is a defined name i assume in the c# library), (), usualy empty apparently. I dont know why this is needed but it is.
	{
		Necromancer = new myClass();
	

		Necromancer.mana = 50; 
        Necromancer.health = 2;
		Necromancer.summonsLevel = 5;
        Necromancer.defense = 4;
		

        Console.WriteLine("Class:" + Necromancer.ClassName);
		Console.WriteLine("Name:" + Necromancer.Name);
		Console.WriteLine("Health:" + Necromancer.health);
		Console.WriteLine("Summons Level:" + Necromancer.summonsLevel);
		Console.WriteLine("Mana:" + Necromancer.mana);
        Console.WriteLine("Defense:" + Necromancer.defense);


	}
}

public class myClass {
	public int health;
	public int summonsLevel;
    public int defense;
    public int mana;
	public string Name = "Azucina";
	public string ClassName = "Necromancer";
}