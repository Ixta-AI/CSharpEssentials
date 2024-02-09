using System;
					
public class Program
{
	public static void Main()
	{
		string[] foodList= new string[3];//Created an empty Array with a limited amount of elements
		Console.WriteLine("Hello What are your three favorite food's?");//Intro prompt
		
		for(int itemOnList = 0; itemOnList < 3; itemOnList++) //for statement that takes the curent index we are on and alters the element held inside then goes up to the next index.
		{
			Console.WriteLine("What is your: #" + (itemOnList + 1) +" favorite ?" ); //prompting user to enter a value for each item on a list. without the (i + 1) the index num of 0 will display
			foodList[itemOnList] = Console.ReadLine();// taking user input to assign a string value to one of the elements in our array
		}
		Console.WriteLine("What a list.");
		foreach (string food in foodList) //foreach loop that takes each individual index in our array and writes out the element name
		{
			Console.WriteLine("I love "+ food + "."); //this is the code that will print "i love" and the elemen names
		}
	}
}
//I found this one much easeir to do because I did this before for switch statements when I wanted to display a list of names
