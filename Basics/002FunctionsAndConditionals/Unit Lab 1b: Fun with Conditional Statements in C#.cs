using System;
					
public class Program
{
	public WorkDoneHere AccessWork;//Declaring we have tools at home and the key we sill use to get them. Variable WorkDoneHere with a Value of AccessWork
	public void Main()
	{
	AccessWork = new WorkDoneHere(); //Making a key "AccessWork" for the specific Door we give this key to our workers so they can grab the tools
		
		Console.WriteLine("What is the Tempteture in Celcius");//Asking user for the current tempurture in C is
		int User = Convert.ToInt32(Console.ReadLine());//Converting the users input into a variable that can be used in our function
		AccessWork.CompTemp(User);/* CompTemp is the name of the opporation we created and AccessWork is what lets us go into "WorkDoneHere"
		Our door called WorkDoneHere uses a key we named AccessWork to enter. The tools we use were placed inside the house*/
       
		Console.WriteLine("Enter what percent you got for the exam:");//Prompting user input
		Console.Write("%");
		int Score = Convert.ToInt32(Console.ReadLine());//Conversion of users input into a usable variable to input a value for the ExamGrade
		AccessWork.ExamGrade(Score);
		
	}
    

}
public class WorkDoneHere{//this is our door and inside it are tools we need for work to be done
    public void CompTemp(int User, int C= 30){ // this is our tool it has a specific function and below it is the work we did to creat this tool
		
		
		if(C < User){ //we assigned an int the name of C and gave it a value of 30. So anything greater than 30 will triger our first stat
            Console.WriteLine("Keep hydrated and stay under the shade to avoid the heat.");
        }else{//everything below 30 (C) will triger this stat
            Console.WriteLine("Not Scorching? Enjoy the day!");
        }
    }

  public void ExamGrade(int Score){//ExamGrader int "user inputs Score".
		
        if(Score >= 90 && Score <= 100){//If else chain needing both arguments to be true otherwise we check for the argument below it until we find a match.
            Console.WriteLine("You got an A.");
        }else if(Score <= 89 && Score >= 80  ){
            Console.WriteLine("You got a B.");
        }else if(Score <= 79 && Score >= 60){
            Console.WriteLine("You got a C.");
        }else if(Score <= 59 && Score >= 50){
			Console.WriteLine("You got a D.");
		}else{
            Console.WriteLine("You got an F." + Environment.NewLine+ "Hit the books."); //wanted to use \n but it doesnt seem to work here so I found the Environment.NewLine option in a tutorial.

		}
    }
}
