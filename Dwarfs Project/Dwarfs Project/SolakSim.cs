//Programmer: Jackson Bruening
// SOLAK KILL SIM

using System;
using System.Collections.Generic;
using System.Text;

namespace Dwarfs_Project

{
	public class SolakSim
		{
		
			public static void Main(string[] args)
				{

					/*Basic Variables*/
			bool logComplete = false;
			int logCompletionKC = 0;
			Random random = new Random();

					/*Pet Handling*/
			int petThresh = 1;
			int sollyPet = 0;

			/*Common Drop Variables*/

			float commonsValue = 0;

			Drop[] commonDrops = new Drop[17];
			int[] dropValueMod = { 1, 15176, 22631, 3150, 7563, 41050, 428784, 6732, 112318, 3576, 5757, 4465, 4453, 2397, 3357, 3289241, 9427 };
            string[] dropNames = { "Coins", "kwuarms", "Medium Rune Salvage", "Battlestaffs", "Onyx Bolt Tips", "Hydirx Bolt Tips",
									"Sirenic Scales", "Tiny Rune Salvage", "Saradomin Wines", "Crushed Nests", "Cadantines", "Banite Stone Spirits",
									"Light Animica Stone Spirits", "Black Dragonhide", "Irits", "Uncut Onyx", "Uncut Dragonstone" };

			for (int i = 0; i < commonDrops.Length; i++)
			{
				commonDrops[i] = new Drop(dropNames[i], dropValueMod[i]);		
			}
			/*Unique Drop Variables*/

			float uniqueValue = 0;

			Unique[] uniqueDrops = new Unique[8];
			int[] uniqueValMods = { 950000000, 1600000000, 370000000, 3000000, 4000000, 80000000, 16000000, 6000000 };
			string[] uniqueName = {"Blightbound Crossbow", "Off-Hand Blightbound Crossbow", "Erethdor's Grimoire", "Merethiel's Stave", "Purple Mushroom", 
									"Cinderbane Gloves", "Ancient Elven Ritual Shard", "Griomoire Page" };

			for (int i = 0; i < uniqueDrops.Length; i++)
			{
				uniqueDrops[i] = new Unique(uniqueName[i], uniqueValMods[i]);
			}
						
			
			//Main Program Function


			SolakSim.WelcomeMessage();
			int numberOfKills = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("At what team size?");
			int teamSize = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Thank you! Your kills will begin simulating.");
					
			for (int i = 1; i <= numberOfKills;i++ ) /*Simulating all drop chances for ammount of specified kills*/
			{
				int dropRandomizer = random.Next(0, 2000000); /*Randomizes drop chances*/
			
				for (int j = 1; j <= teamSize; j++) /*Cross Bow and Grim Rolls*/
				{
					dropRandomizer = random.Next(0, 2000000);

					if (dropRandomizer%400 == 0 ) /*MH Success*/
					{
						
						//MH CrossBow
						if (j == 1)
						{
							//personal
							Console.WriteLine($"Congratulations on kill {i} you recieved a personal {uniqueDrops[0].Name}!");
							uniqueDrops[0].Personal++;
							uniqueDrops[0].DropAmount++;
						}
						else
						{
							//split
							Console.WriteLine($"Congratulations on kill {i} a member of your team recieved a {uniqueDrops[0].Name}!");
							uniqueDrops[0].DropAmount++;

						}
								
					}
					else if(dropRandomizer%400 == 1) /*OH Success*/
					{
						//OH CrossBow
						if(j == 1)
						{
							//personal
							Console.WriteLine($"Congratulations on kill {i} you recieved a personal {uniqueDrops[1].Name}!");
							uniqueDrops[1].Personal++;
							uniqueDrops[1].DropAmount++;
						}
						else
						{
							//Split
							Console.WriteLine($"Congratulations on kill {i} a member of your team recieved a {uniqueDrops[1].Name}!");
							uniqueDrops[1].DropAmount++;
						}
					}
					else if(dropRandomizer%400 == 2 || dropRandomizer % 400 == 3) /*Grim Success*/
					{
						if(j == 1)
						{
							//Personal
							Console.WriteLine($"Congratulations on kill {i} you recieved a personal {uniqueDrops[2].Name}!");
							uniqueDrops[2].Personal++;
							uniqueDrops[2].DropAmount++;
						}
						else
						{
							//Split
							Console.WriteLine($"Congratulations on kill {i} a member of your team recieved a {uniqueDrops[2].Name}!");
							uniqueDrops[2].DropAmount++;
						}
					}
							
							
				}	
						
				/*tertiary "rare" drops*/		
				if (dropRandomizer%500 == 0)
				{
					//Staff
					Console.WriteLine($"Congratulations on kill {i} you recieved a {uniqueDrops[3].Name}!");
					uniqueDrops[3].DropAmount++;
				}
				if (dropRandomizer%500 == 1)
				{
					//Mushroom
					Console.WriteLine($"Congratulations on kill {i} you recieved a {uniqueDrops[4].Name}!");
					uniqueDrops[4].DropAmount++;
				}
				if (dropRandomizer%1000 == 2)
				{
					//Cinderbanes
					Console.WriteLine($"Congratulations on kill {i} you recieved a {uniqueDrops[5].Name}!");
					uniqueDrops[5].DropAmount++;
				}
				if (dropRandomizer % 1000 == 3)
				{
					//Ancient Elven Ritual Shard
					Console.WriteLine($"Congratulations on kill {i} you recieved a {uniqueDrops[6].Name}!");
					uniqueDrops[6].DropAmount++;
				}

				/*Pages*/
				if (dropRandomizer%4 == 0)
				{
					//Pages
					uniqueDrops[7].DropAmount += (dropRandomizer%2) + 1;
				}
						
				/*Pet Chances and Thresholds*/
				if(i%240 == 0 && petThresh < 10)
				{
					petThresh = (i/240) + 1;
				}	
				if(dropRandomizer%(1200/petThresh) == 0 )
				{
					if(sollyPet < 1)
					{
						Console.WriteLine($"Congratulations on kill {i} you recieved the Solly Pet!");
						sollyPet++;
					}
					else
					{
						Console.WriteLine($"Congratulations on kill {i} you would have recieved another Solly Pet!");
						sollyPet++;
					}
				}
						
				/*Common Loot*/
				switch(dropRandomizer%17)
				{
					case 0 :
						//coins
						commonDrops[0].DropAmount += (dropRandomizer%151512) + 748333;
						break;
								
					case 1 :
						//Kwuarm
						commonDrops[1].DropAmount += (dropRandomizer%46) + 155;
						break;
								
					case 2 :
						//Med Salvage
						commonDrops[2].DropAmount += (dropRandomizer%16) + 30 ;
						break;
								
					case 3 :
						//BattleStaff
						commonDrops[3].DropAmount += (dropRandomizer%51) + 75;
						break;
								
					case 4 :
						//Onyx Bolt Tips
						commonDrops[4].DropAmount += (dropRandomizer%45) +128 ;
						break;
								
					case 5 :
						//Hydrix Bolt Tips
						commonDrops[5].DropAmount += (dropRandomizer%84) + 100;
						break;
								
					case 6 :
						//Sirenic Scale
						commonDrops[6].DropAmount += (dropRandomizer%3) + 3;
						break;
								
					case 7 :
						//Tiny Salvage
						commonDrops[7].DropAmount += (dropRandomizer%57) + 29;
						break;
								
					case 8 :
						//Sara Wines
						commonDrops[8].DropAmount += (dropRandomizer%11) + 15;
						break;
								
					case 9 :
						//Crushed Nest
						commonDrops[9].DropAmount += (dropRandomizer%51) + 200;
						break;
								
					case 10 :
						//Cadantine
						commonDrops[10].DropAmount += (dropRandomizer%50) + 151;
						break;
								
					case 11 :
						//Banite Spirits
						commonDrops[11].DropAmount += (dropRandomizer%55) + 50;
						break;
								
					case 12 :
						//Light Animica Spirits
						commonDrops[12].DropAmount += (dropRandomizer%65) + 40;
						break;
								
					case 13 :
						//Black Dragonhide
						commonDrops[13].DropAmount += (dropRandomizer%90) + 252;
						break;
								
					case 14 :
						//Irit
						commonDrops[14].DropAmount += (dropRandomizer%45) + 156;
						break;
								
					case 15 :
						//Onyx
						commonDrops[15].DropAmount += (dropRandomizer%2) + 1;
						break;
								
					case 16 :
						//Dragonstone
						commonDrops[16].DropAmount += (dropRandomizer%26) + 75;
						break;
							
				}
						
				/*Log Completion*/
				if (uniqueDrops[0].Personal >= 1 && uniqueDrops[1].Personal >= 1 && uniqueDrops[2].Personal >= 1 && uniqueDrops[3].DropAmount >= 1 && uniqueDrops[4].DropAmount >= 1 && uniqueDrops[5].DropAmount >= 1 && sollyPet >= 1 && !logComplete)
				{
					logCompletionKC = i;
					logComplete = true;
				}
						
			}
					
			for (int i = 0; i < commonDrops.Length; i++)
			{
				commonDrops[i].CalculateValue();
				commonsValue += commonDrops[i].DropValue;
				Console.WriteLine($"{commonDrops[i].Name}: {commonDrops[i].DropAmount}");
			}

			Console.WriteLine();

			for (int i = 0; i < uniqueDrops.Length; i++)
			{
				uniqueDrops[i].CalculateValue();
				uniqueDrops[i].DropValue = (uniqueDrops[i].DropValue / teamSize);
				uniqueValue += uniqueDrops[i].DropValue;
				if (i < 3)
				{
					Console.WriteLine($"{uniqueDrops[i].Name} (Personals): {uniqueDrops[i].DropAmount} ({uniqueDrops[i].Personal})");
				}
				else 
				{
					Console.WriteLine($"{uniqueDrops[i].Name}: {uniqueDrops[i].DropAmount}");
				}
			}

			Console.WriteLine();

			Console.WriteLine($"You would have recieved {sollyPet} Pet(s)!");
			Console.WriteLine($"Your total value from unique drops is {uniqueValue}M! ");
			Console.WriteLine($"Your total value from common drops is {commonsValue}M! ");
			Console.WriteLine($"Your average GP gained per kill was {(uniqueValue + commonsValue)/numberOfKills}M! ");
			Console.WriteLine($"Congratulations you have completed the So-Lacking in drops feat at killcount {logCompletionKC}!");

			}
								
			static void WelcomeMessage()
			{
				Console.WriteLine("Welcome to Jackson's Solak Kill Simulator");
				Console.WriteLine("How many kills would you like to Simulate?");
			}

	}		
}
