using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Anthony";
      Console.WriteLine(name); 
      int number = 11;
      Console.WriteLine(number);
     }
  }
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
       string name = "Tekken 8"; //string stores text and is surounded by ""
      Console.WriteLine(name);  //Console.WriteLine can print text/data from variables
     }
  }
}
-----------------------------------------------------------------------------------------
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args) //Void means this operation or line does not need to return a value
    {
      int myNum = 8; //int= the type of variable we are attempting to make. "myNum" is the name we are assigning to the variable and the = assigns a value to our variable
      Console.WriteLine(myNum);
     }
  }
}
/* It is possible to assign a variable later in the code space and assigning more than one to the same variable name overwrites the previous entry
so we could write int myNum continue the code and then later write myNum=x. this workes because the name myNum is now assigned to recieve an int. */
-------------------------------------------------------------------------------------------
  using System;
					
public class Program
{
	public Spell fireBall;
	public ShardBlessing spellStrength;
	
	public void Main()
	{
		fireBall = new Spell(); //the () makes "Spell" a function that we define further down the code
		spellStrength = new ShardBlessing(); // same as comment above
		
		fireBall.manaCount += 10; //+= opporation add's valu to already input value i.e. manaCount = 50 + 10, making it 60.
		fireBall.firePower += spellStrength.blessingStrength; //this line serves to add the floating point in "blessingStrenght" which is 4.5f to "fireBall"(s) fire power which is another floating point 12.5f 
		Console.WriteLine(fireBall.spellName + " has a mana count of " + fireBall.manaCount + "."); //this line will write out the message "Fire ball has a mana count of 60."
		Console.WriteLine("Spell increased to " + fireBall.firePower + ", Blessing added."); //this line adds "Spell increased to 17, Blessing added." below the first line
	}
}

public class Spell { //we define the peramenters of the new Spell function here
	public int manaCount = 50; //we give it a value of 50 representing mana in the spell
	public string spellName = "Fire ball"; //we name the spell with a string
	public float firePower = 12.5f; //we give it a representation of damage with a floating point 
}

public class ShardBlessing {
	public float blessingStrength = 4.5f; //we represent a buff here by adding using a floating point for "blessingStrength"
}
/*Everything in between the {} brackets defines that class
public class spell { "Start" The middle is where we enter our peramiters like int/string/float which each represent something different }"end" this closes this class off
anything after the "end" bracket has nothing to do with the stuff in the class. */
