//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
using System;

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

}