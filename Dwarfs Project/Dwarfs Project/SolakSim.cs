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
			/* Slamjam note: Don't use object names e.g int, random, etc when naming your classes.  I've named this class something else for you already, that's probably why it didn't work.*/
			Random random = new Random();

			/*Pet Threshold*/
			int petThresh = 1;

			/*Common Drop Variables*/

			Drop[] commonDrops = new Drop[17];
			int[] dropValueMod = { 1, 15176, 22631, 3150, 7563, 41050, 428784, 6732, 112318, 3576, 5757, 4465, 4453, 2397, 3357, 3289241, 9427 };
           		 string[] dropNames = { "Coins", "kwuarms", "Medium Rune Salvage", "Battlestaffs", "Onyx Bolt Tips", "Hydirx Bolt Tips",
						"Sirenic Scales", "Tiny Rune Salvage", "Saradomin Wines", "Crushed Nests", "Cadantines", "Banite Stone Spirits",
						"Light Animica Stone Spirits", "Black Dragonhide", "Irits", "Uncut Onyx", "Uncut Dragonstone" };

			for (int i = 0; i < commonDrops.Length; i++)
			{
				commonDrops[i] = new Drop(dropNames[i], dropValueMod[i]);		
			}



            		/*Rare Drop Variables*/
            		float mainHandBowSplits = 0;
			float offHandBowSplits = 0;
			float mainHandBowPersonal = 0;
			float offHandBowPersonal = 0;
			float grimPersonal = 0;
			float grimSplits = 0;
			float mStaffs = 0;
			float pMushroom = 0;
			float cinders = 0;
			float ritualShard = 0;
			float grimPages = 0;
			float sollyPet = 0;



			/*Value Variables*/
			float uniqueValue = 0;
			float commonsValue = 0;
					
			float mhBowValue = 0;
			float ohBowValue = 0;
			float grimValue = 0;
			float staffValue = 0;
			float shroomValue = 0;
			float cinderValue = 0;
			float shardValue = 0;
			float pageValue = 0;
					
					
					
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
							Console.WriteLine($"Congratulations on kill {i} you recieved a personal Main Hand Crossbow!");
							mainHandBowPersonal++;
						}
						else
						{
							//split
							Console.WriteLine($"Congratulations on kill {i} a member of your team recieved a Main Hand Crossbow!");
							mainHandBowSplits++;
									
						}
								
					}
					else if(dropRandomizer%400 == 1) /*OH Success*/
					{
						//OH CrossBow
						if(j == 1)
						{
							//personal
							Console.WriteLine($"Congratulations on kill {i} you recieved a personal Off Hand Crossbow!");
							offHandBowPersonal++;
						}
						else
						{
							//Split
							Console.WriteLine($"Congratulations on kill {i} a member of your team recieved a Off Hand Crossbow!");
							offHandBowSplits++;
						}
					}
					else if(dropRandomizer%400 == 2 || dropRandomizer % 400 == 3) /*Grim Success*/
					{
						if(j == 1)
						{
							//Personal
							Console.WriteLine($"Congratulations on kill {i} you recieved a personal Grimoire!");
							grimPersonal++;
						}
						else
						{
							//Split
							Console.WriteLine($"Congratulations on kill {i} a member of your team recieved a Grimoire!");
							grimSplits++;
						}
					}
							
							
				}
						
						
								
						
						
				/*tertiary "rare" drops*/
						
				if (dropRandomizer%500 == 0)
				{
					//Staff
					Console.WriteLine($"Congratulations on kill {i} you recieved a Merethiels Staff!");
					mStaffs++;
				}
				if (dropRandomizer%500 == 1)
				{
					//Mushroom
					Console.WriteLine($"Congratulations on kill {i} you recieved a Purple Mushroom!");
					pMushroom++;
				}
				if (dropRandomizer%1000 == 2)
				{
					//Cinderbanes
					Console.WriteLine($"Congratulations on kill {i} you recieved a pair of Cinderbanes!");
					cinders++;
				}
				if(dropRandomizer%1000 == 3)
				{
					//Ancient Elven Ritual Shard
					Console.WriteLine($"Congratulations on kill {i} you recieved an Ancient Elven Ritual Shard!");
					ritualShard++;
				}
						
				/*Pages*/
				if(dropRandomizer%4 == 0)
				{
					//Pages
					grimPages = grimPages + (dropRandomizer%2) + 1;
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
				if (mainHandBowPersonal >= 1 && offHandBowPersonal >= 1 && grimPersonal >= 1 && mStaffs >= 1 && pMushroom >=1 && grimPages >=1 && sollyPet >= 1 && !logComplete)
				{
					logCompletionKC = i;
					logComplete = true;
				}
						
			}
					
			/*Value Calculations*/
			mhBowValue = (mainHandBowPersonal + mainHandBowSplits) * (950/teamSize);
			ohBowValue = (offHandBowPersonal + offHandBowSplits) * (1600/teamSize);
			grimValue = (grimPersonal + grimSplits) * (370/teamSize);
			staffValue = (mStaffs * 3);
			shroomValue = (pMushroom * 4);
			cinderValue = (cinders * 81);
			shardValue = (ritualShard * 16);
			pageValue = (grimPages * 6);
				
			uniqueValue = mhBowValue + ohBowValue + grimValue + staffValue + shardValue + cinderValue + shardValue + pageValue;

			for (int i = 0; i < commonDrops.Length; i++)
			{
				commonDrops[i].CalculateValue();
			}

			for (int i = 0; i < commonDrops.Length; i++)
			{
				commonsValue += commonDrops[i].DropValue;
			}

			for (int i = 0; i < commonDrops.Length; i++)
			{
				Console.WriteLine($"{commonDrops[i].Name}: {commonDrops[i].DropAmount}");
			}

			Console.WriteLine("/n");
			Console.WriteLine($"Grimoire Pages: {grimPages}");
			Console.WriteLine($"Cinderbanes: {cinders}");
			Console.WriteLine($"Ancient Elven Ritual Shard: {ritualShard}");
			Console.WriteLine($"Meritiel Staff: {mStaffs}");
			Console.WriteLine($"Purple Mushroom: {pMushroom}");
			Console.WriteLine($"Main Hand Crossbow Splits(including personals): {mainHandBowPersonal + mainHandBowSplits}");
			Console.WriteLine($"Off Hand Crossbow Splits(including personals): {offHandBowPersonal + offHandBowSplits}");
			Console.WriteLine($"Grimoire(including personals): {grimPersonal + grimSplits}");
			Console.WriteLine($"You would have recieved {sollyPet} Pets!");
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
