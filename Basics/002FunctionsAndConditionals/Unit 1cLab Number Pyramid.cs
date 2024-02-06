using System;

public class Program
{
	public buildPyramid workerbees;
	public void Main()
	{
		workerbees = new buildPyramid();
		
		Console.WriteLine("Write a positive number; this will be the number of rows");
		int rows = Convert.ToInt32(Console.ReadLine());
		workerbees.building(rows);
	}
}
public class buildPyramid//I struggled hard because of WriteLine. I needed to use Write instead so I wouldnt end up with 122333444 etc.
{
	public void building(int rows)
	{
		for (int i = 1; i <= rows; i++)// will write out column'
		{
			for(int fill=1; fill <=i; fill++)  // to my knowledge this will fill each new line with the value of that line
			Console.Write(i);  //this will write out the i value on this single line Untill it hits the line value. (line 3 would write 333)
			Console.WriteLine();  //this exececutes next and causes the next line to be writen.
		//Swithching this would cause the program to write out 12345 on different lines with increasing space
		}
	}
}//I cannot say I confidently understand this Only that I can do it now.

/*I will Attempt to explain this now. Firstly I prompt my user to enter a whole number and convert their input into an int called rows.
I creat a class to do all the work and keep the code looking clean
under the void "building" I use the user input rows as my value for the argument. This will take user num and plug it in the work.
The First "for" will creat the number of column' in our pyramid based off our user input. (int name = i its value is 1; if i is less than or equal to user input; increase the value of i by one) {when I wrote the code I assumed it would define the rows only}
The Second "for" is writen in the body of the first "for" and will populate our rows with the columns value. (int named fill has a value of 1; if fill is less than or equal to i(which holds whichever current value it has); increase the value of fill by one) (I assume this causes i to start filling that line then increases the line value by one so 2 would hold 22 then go up to 3 which holds 333).
The Console.Write(i) will fill the row until it reaches that rows value then the following Console.WriteLine() command will move down a row 
Finaly the Process will loop until it matches user input value.*/
//To my knowledge this would not work without the second for line but I don't fully comprehend why we dont write out "fill" and how "fill" specifically populates a line.
