//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

public class ClassExample
{
    
}

public class ClassWithVariables
{
    public int number = 2; //int stores a numerical value
    number = 8; //this overwrites the previouse number 2 and makes it a 8; so long as I am using the same variable name the stored value in it for int will change
    //This can be kept permanent by assigning a "const" which declairs a variable to be Constant and prevents it from being overwritten
   
    public string userName = "Bob"; //string stores a strig of characters 
    public string userLastName = "Bobby"
    public string userFullName = userName + userLastName // this combines two variables which allowes us to write out both combined at the same line   
    public char tekken8 = 'a'; // char stores single characters 
    
    public bool a = true// bool stores true of false values


}

public class ClassWithFunctions
{
    public void RunFunction()
    {
        Console.WriteLine("Running Function"); //write line fucntion writes a line (in this line it writes what it says)
        Console.WriteLine("is tekken 8 out now?"/n + "a, b, c, d"); /*error. To my knowledge the "+" only works on numeric values. to get this to work I would need to define strings and combine them before using that variable here.
        the commas dont work here but when defining multiple variables for int the commas seperate each variable name (e.g. int = a = 12, b = 4, c = 2,... etc.) */
        Console.WriteLine(tekken8 +" is the answer");
        Console.WriteLine(a);
        Console.WriteLine(userFullName); //instead of writing out a string with "" or writting multiple variabls in at once this lets us write down two variables by refuring to a single one that was defined to combine two other strings
    }
}   
