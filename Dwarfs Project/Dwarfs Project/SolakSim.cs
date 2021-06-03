//Programmer: Jackson Bruening
// SOLAK KILL SIM

using System;
using System.Collections.Generic;
using System.Text;

namespace System

{
	public class SolakSim
		{
		
			public static void Main(string[] args)
				{
					/* Slamjam note:
					 * All of thsese variables below should be split into classes to make it more neat.  Having all these variables in one class is not a good look.
					 * 
					 * When you make classes, think of the different functions that a class can have.  In this example, I can mainly think of a class called DropTable that takes in an array of Drops, for example.
					 * 
					 * (Drops being an item such as coins, kwarms, for simplicity.  A drop class for instance can have its type, how much of it you get, rarity, etc.)
					 */

					/*Basic Variables*/
					bool logComplete = false;
					int logCompletionKC = 0;

					/* Slamjam note: Don't use object names e.g int, random, etc when naming your classes.  I've named this class something else for you already, that's probably why it didn't work.*/
					Random random = new Random();

					/*Pet Threshold*/
					int petThresh = 1;
					
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
					
					/*Common Drop Variables*/
					float coinDrop = 0;
					float kwuarmDrop = 0;
					float medSalvage = 0;
					float bStaffs = 0;
					float onyxTips = 0;
					float hydrixTips = 0;
					float sirenicScale = 0;
					float tinySalvage = 0;
					float saraWines = 0;
					float cruishedNest = 0;
					float cadDrop = 0;
					float baniteSpirits = 0;
					float liteAnimaSpirits = 0;
					float blackDHide = 0;
					float iritDrop = 0;
					float uncutOnyx = 0;
					float uncutDStones = 0;
					
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
					float coinValue = 0;
					float kwuarmValue = 0;
					float mSalvValue = 0;
					float bStaffValue = 0;
					float onTipValue = 0;
					float hyTipValue = 0;
					float scaleValue = 0;
					float tnSalvValue = 0;
					float winesValue = 0;
					float nestValue = 0;
					float cadValue = 0;
					float baniteValue = 0;
					float liteAnimaValue = 0;
					float dHideValue = 0;
					float iritValue = 0;
					float onyxValue = 0;
					float dStoneValue = 0;
					
					
					
					WelcomeMessage();
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
								coinDrop = coinDrop + (dropRandomizer%151512) + 748333;
								break;
								
							case 1 :
								//Kwuarm
								kwuarmDrop = kwuarmDrop + (dropRandomizer%46) + 155;
								break;
								
							case 2 :
								//Med Salvage
								medSalvage = medSalvage + (dropRandomizer%16) + 30 ;
								break;
								
							case 3 :
								//BattleStaff
								bStaffs = bStaffs + (dropRandomizer%51) + 75;
								break;
								
							case 4 :
								//Onyx Bolt Tips
								onyxTips = onyxTips + (dropRandomizer%45) +128 ;
								break;
								
							case 5 :
								//Hydrix Bolt Tips
								hydrixTips = hydrixTips + (dropRandomizer%84) + 100;
								break;
								
							case 6 :
								//Sirenic Scale
								sirenicScale = sirenicScale + (dropRandomizer%3) + 3;
								break;
								
							case 7 :
								//Tiny Salvage
								tinySalvage = tinySalvage + (dropRandomizer%57) + 29;
								break;
								
							case 8 :
								//Sara Wines
								saraWines = saraWines + (dropRandomizer%11) + 15;
								break;
								
							case 9 :
								//Crushed Nest
								cruishedNest = cruishedNest + (dropRandomizer%51) + 200;
								break;
								
							case 10 :
								//Cadantine
								cadDrop = cadDrop + (dropRandomizer%50) + 151;
								break;
								
							case 11 :
								//Banite Spirits
								baniteSpirits = baniteSpirits + (dropRandomizer%55) + 50;
								break;
								
							case 12 :
								//Light Animica Spirits
								liteAnimaSpirits = liteAnimaSpirits + (dropRandomizer%65) + 40;
								break;
								
							case 13 :
								//Black Dragonhide
								blackDHide = blackDHide + (dropRandomizer%90) + 252;
								break;
								
							case 14 :
								//Irit
								iritDrop = iritDrop + (dropRandomizer%45) + 156;
								break;
								
							case 15 :
								//Onyx
								uncutOnyx = uncutOnyx + (dropRandomizer%2) + 1;
								break;
								
							case 16 :
								//Dragonstone
								uncutDStones = uncutDStones + (dropRandomizer%26) + 75;
								break;
							
						}
						
						/*Log Completion*/
						if (mainHandBowPersonal >= 1 && offHandBowPersonal >= 1 && grimPersonal >= 1 && mStaffs >= 1 && pMushroom >=1 && grimPages >=1 && sollyPet >= 1 && !logComplete)
						{
							logCompletionKC = i;
							//Console.WriteLine($"Congratulations you have completed the So-Lacking in drops feat at killcount {logCompletionKC}!");
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
					
					coinValue = (coinDrop/1000000);
					kwuarmValue = ((kwuarmDrop * 15176)/1000000);
					mSalvValue = ((medSalvage * 22631)/1000000);
					bStaffValue = ((bStaffs * 3150)/1000000);
					onTipValue = ((onyxTips * 7563)/1000000);
					hyTipValue = ((hydrixTips * 41050)/1000000);
					scaleValue = ((sirenicScale * 428784)/1000000);
					tnSalvValue = ((tinySalvage * 6732)/1000000);
					winesValue = ((saraWines * 112318)/1000000);
					nestValue = ((cruishedNest * 3576)/1000000);
					cadValue = ((cadDrop * 5747)/1000000);
					baniteValue = ((baniteSpirits * 4455)/1000000);
					liteAnimaValue = ((liteAnimaSpirits * 4453)/1000000);
					dHideValue = ((blackDHide * 2397)/1000000);
					iritValue = ((iritDrop * 3357)/1000000);
					onyxValue = ((uncutOnyx * 3289241)/1000000);
					dStoneValue = ((uncutDStones * 9427)/1000000);
					
					commonsValue = (coinValue + kwuarmValue + bStaffValue + onTipValue + hyTipValue + scaleValue + tnSalvValue + winesValue + nestValue + cadValue + baniteValue + liteAnimaValue + dHideValue + iritValue + onyxValue + dStoneValue);

					Console.WriteLine($"Coins: {coinDrop}");
					Console.WriteLine($"Kwuarm: {kwuarmDrop}");
					Console.WriteLine($"Medium Rune Salvage: {medSalvage}");
					Console.WriteLine($"Battlestaff: {bStaffs}");
					Console.WriteLine($"Onyx Bolt Tips: {onyxTips}");
					Console.WriteLine($"Hydrix Bolt Tips: {hydrixTips}");
					Console.WriteLine($"Sirenic Scales: {sirenicScale}");
					Console.WriteLine($"Tiny Rune Salvage: {tinySalvage}");
					Console.WriteLine($"Saradomin Wines: {saraWines}");
					Console.WriteLine($"Crushed Nest: {cruishedNest}");
					Console.WriteLine($"Cadantine: {cadDrop}");
					Console.WriteLine($"Banite Stone Spirits: {baniteSpirits}");
					Console.WriteLine($"Light Animica Stone Spirits: {liteAnimaSpirits}");
					Console.WriteLine($"Black Dragon Hide: {blackDHide}");
					Console.WriteLine($"Irit: {iritDrop}");
					Console.WriteLine($"Uncut Onyx: {uncutOnyx}");
					Console.WriteLine($"Uncut Dragonstone: {uncutDStones} \n");
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