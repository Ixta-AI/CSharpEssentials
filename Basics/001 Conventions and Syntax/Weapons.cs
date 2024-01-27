using System;
					
public class Program
{
	public Spell fireBall;
	public ShardBlessing spellStrength;
	
	public void Main()
	{
		fireBall = new Spell();
		spellStrength = new ShardBlessing();
		
		fireBall.manaCount += 10;
		fireBall.firePower += spellStrength.blessingStrength;
		Console.WriteLine(fireBall.spellName + " has a mana count of " + fireBall.manaCount + ".");
		Console.WriteLine("Spell increased to " + fireBall.firePower + ", Blessing added.");
	}
}

public class Spell {
	public int manaCount = 50;
	public string spellName = "Fire ball";
	public float firePower = 12.5f;
}

public class ShardBlessing {
	public float blessingStrength = 4.5f;
}
