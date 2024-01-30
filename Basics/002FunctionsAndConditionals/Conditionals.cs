using System;
					
public class Program
{
	public Conditionals myCon;//We creat myCon value for our Conditionals class.
	
	public void Main()
	{
		myCon = new Conditionals();//This is an "Object". it uses the bluprint we built. myCon is assigned the bluprint Conditionals. ()I think is what lets us use the arguments in the bluprint
		
		Console.WriteLine("Rock, Paper, Scisors, Shoot!");
		String RPS = Console.ReadLine(); //I get user input to creat a unfair "Game". its not really a game its just comparing input statement to my if, if else, code and returning a result.
		myCon.rockPaperScicors(RPS);
		
		Console.WriteLine("When did Tekken 8 release?");
		string Date = Console.ReadLine();
		myCon.TekkenOut(Date); //this is a match statement since tekken 8 has a set release date I just check to see if the user inputs the right date then return correct.
		
		myCon.simpleValue(1, 2);// I dont know what to do differently from this math section so I simply made it output 1+2.
	}

public class Conditionals  //This is a sort of mini library that we use to hold things we want.
    {
	
	public void rockPaperScicors (string User)//Compare
        {
	
			if(User == "Rock") 
			{
			Console.WriteLine("Papper beats Rock");
			}
			else if(User =="Scicors") {
			Console.WriteLine("Rock beats Scicors");
			}
			else 
			{
			Console.WriteLine("Scicors beats Paper"); //you never win in this version
			}
		
		}
  public void TekkenOut (string Date)//Check
    {
		
		if(Date == "26")
            {
			Console.WriteLine("Correct");
		    }
        else 
            {
			Console.WriteLine("Incorrect");
		    }
    }
	
	public void simpleValue(int value, int value2){ //this can work as a power up.
			var number = value + value2;
			Console.WriteLine(number);
			}
		
		
		}
    }//I found organizing this withought VS to be difficult. 
