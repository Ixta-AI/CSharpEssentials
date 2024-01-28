//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public void Main()
	{
	//Arithmetic Operators
		int x, y;
		x = 6;
		y =11;
		Console.WriteLine("Arithmetic Output");
		Console.WriteLine(x+y);//Don't Know why but + clashes with the opporation and causes the two numbers to be writen out as a string instead of an int
		Console.WriteLine(x-y);// Cant add comment "+" does not mesh well with the oporation taking place creating an error
		Console.WriteLine("Multiplication= " +x*y);
		Console.WriteLine("Division " +x/y);
		Console.WriteLine("Remainder " + x%y);//remainder (130 %60=10)
		//Console.WriteLine(x++);//add one.( they dont seem to work in write line statement )
		//Console.WriteLine(y--);//subtract one
		Console.WriteLine("Assignment Output");//Assignment Operators
		int myNum = 8; //(=) assigns a value of 8
		Console.WriteLine(myNum += 8);//(+=) adds a value of 8 to 8
		Console.WriteLine(myNum -= 6);//(-=) subbtracts value of 6 from 8 (the code output is taking the last oporation and subtracting 6 from 16
		Console.WriteLine(myNum *= 3);//this has become 3*10 making 30
		Console.WriteLine(myNum /= 7);//this has become 30/7 and since no floating point is displaye it returns a 4 (this would be a logical error not a syntax error)
		Console.WriteLine(myNum %= 7);
		Console.WriteLine("Comparison Operators");
		int a, b;//Comma makes a list of assigned names for this int
		a = 12;//If I used a comma to list names for int I can assign values later with less text
		b = 9;//this makes the code look cleaner too.
		
		//Console.WriteLine("is a = b " + a==b);//this means equal to and since they are not it returns a value of False
		//Comparison Operations cannot contain "strings". it creats an error
		Console.WriteLine(a!=b);//this means not equal
		Console.WriteLine(a>b);//this means grater than
		Console.WriteLine(a<b);//this means less than
		Console.WriteLine(a>=b);// this means grater than or equal to
		Console.WriteLine(a<=b);//this means less than or equal to
		
		Console.WriteLine("Logical Operators");//these also return true or false values
		int num1, num2;
		num1= 4;
		num2 = 6;
		Console.WriteLine(num1 != num2 && num1 == num2);//this will return a true value if both are true. It means if 1 is true and 2 is true return true.
		Console.WriteLine(num1 == num2 || num2==6); //this is if 1 is true OR if 2 is true. if even oen statement is true then it returns true
		Console.WriteLine(!(num1==12));//this means if this statement is false.
		//Console.WriteLine(!(num1=4)&& num2=6); the ! operator seems to not be able to be aplied to other logical Operators.
	}
	
}
