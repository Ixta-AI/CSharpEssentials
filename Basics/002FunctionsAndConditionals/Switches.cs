using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Who do you main in Tekken 8?" );
		String[] names = new string[32];
		names[0] = "Kazuya";
		names[1] = "Jin";
		names[2] = "King";
		names[3] = "Jun";
		names[4] = "Paul";
		names[5] = "Law";
		names[6] = "Jack-8";
		names[7] = "Lars";
		names[8] = "Xiaoyu";
		names[9] = "Nina";
		names[10] = "Leroy";
		names[11] = "Asuka";
		names[12] = "Lili";
		names[13] = "Bryan";
		names[14] = "Hwoarang";
		names[15] = "Claudio";
		names[16] = "Azucena";
		names[17] = "Reina";
		names[18] = "Raven";
		names[19] = "Leo";
		names[20] = "Steve";
		names[21] = "Kuma";
		names[22] = "Yoshimitys";
		names[23] = "Shaheen";
		names[24] = "Dragunov";
		names[25] = "Feng";
		names[26] = "Panda";
		names[27] = "Lee";
		names[28] = "Alisa";
		names[29] = "Zafina";
		names[30] = "Devil Jin";
		names[31] = "Victor";
		
		foreach (string item in names)
		{
			Console.WriteLine(item);
		}
			string main = Console.ReadLine();
		
			switch (main)
			{
				case "Kazuya":
					Console.WriteLine("Mishima!");
					break;
				case "Jin":
					Console.WriteLine("Mishima!!");
					break;
				case "King":
					Console.WriteLine("Luchador!");
					break;
				case "Jun":
					Console.WriteLine("Mother Mishima!");
					break;
				case "Paul":
					Console.WriteLine("HE NEVER WINS!");
					break;
				case "Law":
					Console.WriteLine("Bruce Lee Must be IN EVERY FIGHTING GAME!");
					break;
				case "Jack-8":
					Console.WriteLine("ONE FOR EVERY ENTRY");
					break;
				case "Lars":
					Console.WriteLine("MISHIMA technically");
					break;
				case "Xiaoyu":
					Console.WriteLine("You're not getting off easy");
					break;
				case "Nina":
					Console.WriteLine("Spy");
					break;
				case "Leroy":
					Console.WriteLine("Wing Chun never looked cooler");
					break;
				case "Lili":
					Console.WriteLine("French");
					break;
				case "Asuka":
					Console.WriteLine("BRICK WALL");
					break;
				case "Bryan":
					Console.WriteLine("Monster!");
					break;
				case "Hwoarang":
					Console.WriteLine("Taekwondo has never been more rage filled");
					break;
				case "Claudio":
					Console.WriteLine("The Exorcist");
					break;
				case "Raven":
					Console.WriteLine("Ninja");
					break;
				case "Azucena":
					Console.WriteLine("Coffee Queen");
					break;
				case "Reina":
					Console.WriteLine("Mishima?");
					break;
				case "Leo":
					Console.WriteLine("Bajiquan user. The German with the chinies fighting style");
					break;
				case "Steve":
					Console.WriteLine("He can't kick");
					break;
				case "Kuma":
					Console.WriteLine("Bear... and a MISHIMA!");
					break;
				case "Yoshimitys":
					Console.WriteLine("Space Ninja with a thirsty sword");
					break;
				case "Shaheen":
					Console.WriteLine("Everything is a skateboard to you");
					break;
				case "Dragunov":
					Console.WriteLine("CQC workaholic");
					break;
				case "Feng":
					Console.WriteLine("Ever growing strength");
					break;
				case "Panda":
					Console.WriteLine("Pet body gaurd");
					break;
				case "Lee":
					Console.WriteLine("...um... rich?");
					break;
				case "Alisa":
					Console.WriteLine("Here hold my head");
					break;
				case "Zafina":
					Console.WriteLine("Demon magic");
					break;
				case "Devil Jin":
					Console.WriteLine("Jhin but evil");
					break;
				case "Victor":
					Console.WriteLine("Behind the scenes Ninja boss");
					break;
				default:
					Console.WriteLine("every character is good");
					break;
			}
	}
		
}
