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
		
		Console.WriteLine("Name a subject you might be strugling in and Ill give a sugestion");//we added this to prompt our user to input a subject they may need help with.
		string Cours = Console.ReadLine();
		AccessWork.Subjects(Cours);
	}
//--------------------------------------------------------------------------------------------------------------------------------------------------------
}
public class WorkDoneHere{//this is our door and inside it are tools we need for work to be done
//--------------------------------------------------------------------------------------------------------------------------------------------------------
	public void CompTemp(int User, int C= 30){ // this is our tool it has a specific function and below it is the work we did to creat this tool
		
		
		if(C <= User){ //we assigned an int the name of C and gave it a value of 30. So anything greater than 30 will triger our first stat
            Console.WriteLine("Watch out for heat stroke!");
        }else if(User <= 29 && User >= 25){   
            Console.WriteLine("Hot! Stay hydrated!");
		}else if(User <= 24 && User >= 20){
			Console.WriteLine("The temperature is great, why not go for picnic."); //I extended and refined this script to include a more accurate message for various tempetures.
		}else if(User <= 19 && User >= 10){
			Console.WriteLine("Its cooling down out here. Try out a light jacket.");
		}else if(User <= 9 && User >= 0){
			Console.WriteLine("Its cold. Stay warm out there with warmer clothes.");
		}else if(User <= -1 && User >= -10){
			Console.WriteLine("Stay indoors its much warmer than it is outside");
		}else{
			Console.WriteLine("No way you still have fingers!");
			
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
    public void Subjects(string Course){ //new section added to take user input and compare them to switch.

        switch(Course){
			case "Math":
                Console.WriteLine("Try a tutor in the lab, they are there to help");
                break;
            case "Science": 
                Console.WriteLine("Try the Sample Problems. They are there to help reinforce what you just read.");
                break;
            case "English":
                Console.WriteLine("Speak with your instructer, They have many tips and resources they can provide.");
                break;
            case "History":
                Console.WriteLine("Memorisation of all the dates can be difficult. Try connecting events to concepts you understand. like July 4th and fireworks. fireworks are for celibrations and people celebrate when they move out and become independent.");
                break;
            default:
                Console.WriteLine("Im sorry I don't know that class");//default line will play if anything not in the case scenarios is matched. 
                break;

        }
	}
}
