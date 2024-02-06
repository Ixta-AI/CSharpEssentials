using System;

public class Program
{
	public List myWrite;//refering to our created class "List"
	public void Main()
	{
		myWrite = new List();//Grabing our information/code by creating a usable object
		myWrite.WriteOutList();//using the object and plugging in specific functions 
		myWrite.WriteOutNum();//the order of each function is determend by the line each is found on
		//this will write out the name of games before it writes out numbers
	}
}

public class List//creating classes to try and keep it fresh in my mind
{
	public void WriteOutList()//oporator in class that specifically will write out lists 
	{
		String[] GameNames =//a string of game names
		{
			"Tekken",
			"Persona",
			"Guilty Gear",
			"Mortal Kombat"
		};
		foreach (string i in GameNames)//for each string(a string of characters like ABCD or Adrian) i (the characters inside our array) GameNames(Our array)
		{
			Console.WriteLine(i);//Write out each name (Display)
		}
	}

	public void WriteOutNum()
	{
		int[] entries =//these are the current entreis for each game I listed.
		{
			8,
			5,
			7,
			1
		};
		int totalValue = 0;
		foreach (int item in entries)//I dont know how but I eventually want to match these to their respective games
		{//int(num) item(element in the array) in entries(my array list)
			Console.WriteLine(item);
			totalValue += item;//for now I did simple math and added up all main entries
		}

		Console.WriteLine(totalValue);
	}
}
