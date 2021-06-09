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

			Drop coins = new Drop("Coins", 1);
			Drop kwuarm = new Drop("Kwuarms",15176);
			Drop mediumSalvage = new Drop("Medium Rune Salvages",22631 );
			Drop battleStaff = new Drop("Battlestaffs",3150);
			Drop onyxBTips = new Drop("Onyx Bolt Tips",7563);
			Drop hydrixBTips = new Drop("Hydrix Bolt Tips",41050);
			Drop sirenicScales = new Drop("Sirenic Scales",428784);
			Drop tinySalv = new Drop("Tiny Rune Salvage",6732);
			Drop saradominWines = new Drop("Saradomin Wines",112318);
			Drop crushedNests = new Drop("Crushed Nest",3576);
			Drop cadantine = new Drop("Cadantines",5747);
			Drop baniteStoneSp = new Drop("Banite Stone Spirits",4465);
			Drop LightAnimicaSpirits = new Drop("Light Animica Stone Spirits",4453);
			Drop blackDragonhide = new Drop("Black Dragonhide",2397);
			Drop irit = new Drop("Irits",3357);
			Drop uncOnyx = new Drop("Uncut Onyx",3289241);
			Drop uncDragonstones = new Drop("Uncut Dragonstones",9427);


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
						coins.DropAmount = coins.DropAmount + (dropRandomizer%151512) + 748333;
						break;
								
					case 1 :
						//Kwuarm
						kwuarm.DropAmount = kwuarm.DropAmount + (dropRandomizer%46) + 155;
						break;
								
					case 2 :
						//Med Salvage
						mediumSalvage.DropAmount = mediumSalvage.DropAmount + (dropRandomizer%16) + 30 ;
						break;
								
					case 3 :
						//BattleStaff
						battleStaff.DropAmount = battleStaff.DropAmount + (dropRandomizer%51) + 75;
						break;
								
					case 4 :
						//Onyx Bolt Tips
						onyxBTips.DropAmount = onyxBTips.DropAmount + (dropRandomizer%45) +128 ;
						break;
								
					case 5 :
						//Hydrix Bolt Tips
						hydrixBTips.DropAmount = hydrixBTips.DropAmount + (dropRandomizer%84) + 100;
						break;
								
					case 6 :
						//Sirenic Scale
						sirenicScales.DropAmount = sirenicScales.DropAmount + (dropRandomizer%3) + 3;
						break;
								
					case 7 :
						//Tiny Salvage
						tinySalv.DropAmount = tinySalv.DropAmount + (dropRandomizer%57) + 29;
						break;
								
					case 8 :
						//Sara Wines
						saradominWines.DropAmount = saradominWines.DropAmount + (dropRandomizer%11) + 15;
						break;
								
					case 9 :
						//Crushed Nest
						crushedNests.DropAmount = crushedNests.DropAmount + (dropRandomizer%51) + 200;
						break;
								
					case 10 :
						//Cadantine
						cadantine.DropAmount = cadantine.DropAmount + (dropRandomizer%50) + 151;
						break;
								
					case 11 :
						//Banite Spirits
						baniteStoneSp.DropAmount = baniteStoneSp.DropAmount + (dropRandomizer%55) + 50;
						break;
								
					case 12 :
						//Light Animica Spirits
						LightAnimicaSpirits.DropAmount = LightAnimicaSpirits.DropAmount + (dropRandomizer%65) + 40;
						break;
								
					case 13 :
						//Black Dragonhide
						blackDragonhide.DropAmount = blackDragonhide.DropAmount + (dropRandomizer%90) + 252;
						break;
								
					case 14 :
						//Irit
						irit.DropAmount = irit.DropAmount + (dropRandomizer%45) + 156;
						break;
								
					case 15 :
						//Onyx
						uncOnyx.DropAmount = uncOnyx.DropAmount + (dropRandomizer%2) + 1;
						break;
								
					case 16 :
						//Dragonstone
						uncDragonstones.DropAmount = uncDragonstones.DropAmount + (dropRandomizer%26) + 75;
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

			coins.CalculateValue();
			kwuarm.CalculateValue();
			mediumSalvage.CalculateValue();
			battleStaff.CalculateValue();
			onyxBTips.CalculateValue();
			hydrixBTips.CalculateValue();
			sirenicScales.CalculateValue();
			tinySalv.CalculateValue();
			saradominWines.CalculateValue();
			crushedNests.CalculateValue();
			cadantine.CalculateValue();
			baniteStoneSp.CalculateValue();
			LightAnimicaSpirits.CalculateValue();
			blackDragonhide.CalculateValue();
			irit.CalculateValue();
			uncOnyx.CalculateValue();
			uncDragonstones.CalculateValue();

					
			commonsValue = (coins.DropValue + kwuarm.DropValue + battleStaff.DropValue + onyxBTips.DropValue + hydrixBTips.DropValue + sirenicScales.DropValue + tinySalv.DropValue + saradominWines.DropValue + crushedNests.DropValue + cadantine.DropValue + baniteStoneSp.DropValue + LightAnimicaSpirits.DropValue + blackDragonhide.DropValue + irit.DropValue + uncOnyx.DropValue + uncDragonstones.DropValue);

			Console.WriteLine($"{coins.Name}: {coins.DropAmount}");
			Console.WriteLine($"{kwuarm.Name}: {kwuarm.DropAmount}");
			Console.WriteLine($"{mediumSalvage.Name}: {mediumSalvage.DropAmount}");
			Console.WriteLine($"{battleStaff.Name}: {battleStaff.DropAmount}");
			Console.WriteLine($"{onyxBTips.Name}: {onyxBTips.DropAmount}");
			Console.WriteLine($"{hydrixBTips.Name}: {hydrixBTips.DropAmount}");
			Console.WriteLine($"{sirenicScales.Name}: {sirenicScales.DropAmount}");
			Console.WriteLine($"{tinySalv.Name}: {tinySalv.DropAmount}");
			Console.WriteLine($"{saradominWines.Name}: {saradominWines.DropAmount}");
			Console.WriteLine($"{crushedNests.Name}: {crushedNests.DropAmount}");
			Console.WriteLine($"{cadantine.Name}: {cadantine.DropAmount}");
			Console.WriteLine($"{baniteStoneSp.Name}: {baniteStoneSp.DropAmount}");
			Console.WriteLine($"{LightAnimicaSpirits.Name}: {LightAnimicaSpirits.DropAmount}");
			Console.WriteLine($"{blackDragonhide.Name}: {blackDragonhide.DropAmount}");
			Console.WriteLine($"{irit.Name}: {irit.DropAmount}");
			Console.WriteLine($"{uncOnyx.Name}: {uncOnyx.DropAmount}");
			Console.WriteLine($"{uncDragonstones.Name}: {uncDragonstones.DropAmount} \n");
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
