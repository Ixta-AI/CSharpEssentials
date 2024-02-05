using System;

public class Program
{
	public LoopAccess Rloop;//public reference to grab our LoopAccess class and named it Rloop
	
	public void Main()
	{
	Rloop = new LoopAccess();//class practice creating a new object
	
	Console.WriteLine("i2 will need to be less than 12 to work. " + "Write anything between 0 and 11:" );//prompt to write a number
	//No error message has ben written so if I input a string or char instead of an Int this will just stop with no prompt as to why.	
	int i2 = Convert.ToInt32(Console.ReadLine());//take user input and convert their string into an int
		do{//the do/while loop is basically saying if i2 is less than or equal to 12 write out the current int and go up one
		Console.WriteLine(i2);
			i2++;
		}
		while (i2 <= 12);
		
	Console.WriteLine("int i loop regression example.");
		Rloop.Loop();//this is just accessing the class LoopAccess where we have all the actual code done. it makes this portion cleaner looking
		}
	}

public class LoopAccess //creating a class with our work done in it
{
	public void Loop(){ //our public void named Loop does work here and will not display anything on its own
		int i = 45;
		while (i >= 12)//while i is greater than or equal to 12 write that int and go down by one then repeat.
		{
			Console.WriteLine(i);// since i holds a value of 45 it will count down till it reaches 12.
			i--;//if I did not have the = sign it would stop at 13
		}
	}
}
