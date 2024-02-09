using System;
					
public class Program
{
	public static void Main()
	{
		bool isCorrectGuess = false; //this is a conditional we creat to initilize and end the loop. basicaly our argument for starting the loop
		Random random = new Random();// this is a built in function to C and we call it by creating the "Random()" object and naming it random
    //it's to use the random function
		
		
		int attempts = 0; // attempt tracker (side note it did not work correctly some times. I assume whatever stoped random from working correctly aslo made each atempt ocasinaly reset to 1)
		int randomNum = random.Next(1,11); //Generator for a random number (side note it still did not function appropriatly in fiddle .net 8) 
		
		Console.WriteLine("Hello I would like you to guess a number between 1 and 10."); //prompt to input a number
		
		while (!isCorrectGuess)// here we used our bool value to start. it says "while is not correct" "!" basicaly saying whatever it proceeds is false 
		{
			Console.WriteLine("Please, what is your number: ");
			int guess = Convert.ToInt32(Console.ReadLine()); //converting user input, which is usualy taken as a string, into an integer that we can use to compare
			attempts++; //This is supposed to increase attempts counter by one for every loop we make but sometimes it returns "1" after more than one attempt
			
			if(guess > randomNum) //our condition to execute the associated block of code.
			{
				Console.WriteLine("You guessed to high."); //feedback to be displayed if the associated condition is true
			}
			else if(guess < randomNum)
			{
				Console.WriteLine("You guessed to low");
			}
			else //if niether argumetns before this are true it signifies that we matched the correct number; it is equal to, since it is niether less than or grater than the else block is executed.
			{
				Console.WriteLine("Correct!");
				isCorrectGuess= true; //this will end the loop. wihtout it the loop will start over again even if the number we enterd was correct
			}
		}
		//this block of code is executed after the loop ends line by line displaying a victory message and subsequent information like number of attempts and what the exact random number was.
		Console.WriteLine("You win!");
		Console.WriteLine("you made: "+ attempts +" attempts");
		Console.WriteLine("The Numebr Was: " + randomNum);
	}
}
//If using a do while loop we can basicaly ignore the bool requirement by assigning a simple equil value like " do {block of code and conditions} while (guess != random). the moment the while conditon becomes false the loop ends.
// A for loop would be a bit messy to read I think but if done would first " for (int = randomNum; Guses != randomNum; attempts++) and then we could insert the if, else if, statements we have here to acomplish basically the same thing. (... I think)
