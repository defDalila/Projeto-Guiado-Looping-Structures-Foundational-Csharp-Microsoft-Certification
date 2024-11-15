/*

Projeto - Desenvolver Estruturas de Ramificação Condicional e Loop em C#

*/


using System.Reflection.Metadata;

Console.Clear();

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

int maxPets = 8;
string? readResult;
string menuSelection = "";

string[] labelsForAnimalData = ["ID #", "Species", "Nickname", "Age", "Nickname", "Physical Description", "Personality"];
string[,] ourAnimals = new string[maxPets, 6];

#region Inicializa o array com dados de exemplo

for (int i = 0; i < maxPets; i++)
{
	switch (i)
	{
		case 0:
			animalSpecies = "dog";
			animalID = "D1";
			animalAge = "2";
			animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
			animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
			animalNickname = "lola";
			break;
			
		case 1:
			animalSpecies = "dog";
			animalID = "D2";
			animalAge = "9";
			animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
			animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
			animalNickname = "loki";
			break;
			
		case 2:
			animalSpecies = "cat";
			animalID = "C3";
			animalAge = "1";
			animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
			animalPersonalityDescription = "friendly";
			animalNickname = "Puss";
			break;
			
		case 3:
			animalSpecies = "cat";
			animalID = "C4";
			animalAge = "?";
			animalPhysicalDescription = "";
			animalPersonalityDescription = "";
			animalNickname = "";
			break;
		
		case 4:
			animalSpecies = "dog";
			animalID = "D5";
			animalAge = "5";
			animalPhysicalDescription = "";
			animalPersonalityDescription = "";
			animalNickname = "";
			break;

		default:
			animalSpecies = "";
			animalID = "";
			animalAge = "";
			animalPhysicalDescription = "";
			animalPersonalityDescription = "";
			animalNickname = "";
			break;
	}

	ourAnimals[i, 0] = animalID;
	ourAnimals[i, 1] = animalSpecies;
	ourAnimals[i, 2] = animalNickname;
	ourAnimals[i, 3] = animalAge;
	ourAnimals[i, 4] = animalPhysicalDescription;
	ourAnimals[i, 5] = animalPersonalityDescription;
}
#endregion

do
{
	Console.Clear();

	Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
	Console.WriteLine(" 1. List all of our current pet information");
	Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
	Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
	Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
	Console.WriteLine(" 5. Edit an animal's age");
	Console.WriteLine(" 6. Edit an animal's personality description");
	Console.WriteLine(" 7. Display all cats with a specified characteristic");
	Console.WriteLine(" 8. Display all dogs with a specified characteristic");
	Console.WriteLine();
	Console.Write("Enter your selection number (or type 0 to exit the program): ");

	readResult = Console.ReadLine();

	if (readResult != null)
	{
		menuSelection = readResult.ToLower().Trim();
	}

	switch (menuSelection)
	{
		case "0":
			// Exit the application
			break;
			
		case "1":
			Console.Clear();
			Console.WriteLine($"\n----- List all of our current pet information -----\n");

			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[i, 0] != "")
				{
					Console.WriteLine();
					for (int j = 0; j < 6; j++)
					{
						Console.WriteLine($"{labelsForAnimalData[j]}: {ourAnimals[i, j]}");
					}
				}
			}

			Console.WriteLine("\nPress the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
			
		case "2":
			Console.Clear();
			Console.WriteLine($"\n----- Add a new animal friend -----\n");

			string anotherPet = "y";
			int petCount = 0;

			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[i, 0] != "")
					petCount++;
			}

			if (petCount < maxPets)
			{
				Console.Write($"We currently have {petCount} pets that need homes.");
				Console.WriteLine($" We can manage {(maxPets - petCount)} more.");
			}

			while (anotherPet == "y" && petCount < maxPets)
			{
				bool validEntry = false;

				do
				{
					Console.Write("\nEnter 'dog' or 'cat' to begin a new entry: ");
					readResult = Console.ReadLine();

					if (readResult != null)
					{
						animalSpecies = readResult.ToLower().Trim();

						if (animalSpecies != "dog" && animalSpecies != "cat")
						{
							validEntry = false;
						}
						else
						{
							validEntry = true;
						}
					}

				} while (validEntry == false);

				animalID = animalSpecies.Substring(0, 1).ToUpper() + (petCount + 1).ToString();


				do
				{
					Console.Write("\nEnter a nickname for the pet: ");
					readResult = Console.ReadLine();

					if (readResult != null)
					{
						animalNickname = readResult.ToLower();
						if (animalNickname == "")
						{
							animalNickname = "tbd";
						}
					}
				} while (animalNickname == "");


				do
				{
					
					Console.Write("\nEnter the pet's age or '?' if unknown: ");
					readResult = Console.ReadLine();

					if (readResult != null)
					{
						animalAge = readResult.Trim();

						if (animalAge != "?")
						{
							validEntry = int.TryParse(animalAge, out _);
						}
						else
						{
							validEntry = true;
						}
					}

				} while (validEntry == false);
				
				
				do
				{
					Console.Write("\nEnter a physical description of the pet (size, color, gender...): ");
					readResult = Console.ReadLine();

					if (readResult != null)
					{
						animalPhysicalDescription = readResult.ToLower();
						if (animalPhysicalDescription == "")
						{
							animalPhysicalDescription = "tbd";
						}
					}

				} while (animalPhysicalDescription == "");
				

				do
				{
					Console.Write("\nEnter a personality description of the pet: ");
					readResult = Console.ReadLine();

					if (readResult != null)
					{
						animalPersonalityDescription = readResult.ToLower();
						if (animalPersonalityDescription == "")
						{
							animalPersonalityDescription = "tbd";
						}
					}

				} while (animalPersonalityDescription == "");
				

				ourAnimals[petCount, 0] = animalID;
				ourAnimals[petCount, 1] = animalSpecies;
				ourAnimals[petCount, 2] = animalNickname;
				ourAnimals[petCount, 3] = animalAge;
				ourAnimals[petCount, 4] = animalPhysicalDescription;
				ourAnimals[petCount, 5] = animalPersonalityDescription;

				petCount++;


				if (petCount < maxPets)
				{
					Console.Write("Do you want to enter info for another pet (y/n): ");

					do
					{
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							anotherPet = readResult.ToLower().Trim();
						}

					} while (anotherPet != "y" && anotherPet != "n");
				}
			}


			if (petCount >= maxPets)
			{
				Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
			}


			Console.WriteLine("\nPress the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
			
		case "3":
		
			Console.Clear();
			Console.WriteLine($"----- Ensure animal ages and physical descriptions are complete -----\n");
			
			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[i, 0] != "")
				{
					int ageIndex = 3;			
					if (ourAnimals[i, ageIndex] == "?")
					{
						bool validAge;
						do
						{
							Console.Write($"Enter an age for ID # {ourAnimals[i, 0]}: ");
							validAge = int.TryParse(Console.ReadLine(), out int petAge);
							
							if (validAge)
							{
								ourAnimals[i, ageIndex] = petAge.ToString();
							}
							else
							{
								Console.WriteLine("Please enter a valid age.\n");
							}
					
							
						} while (!validAge);
					}
					
										
					int physicalIndex = 4;
					if (ourAnimals[i, physicalIndex] == "tbd" || ourAnimals[i, physicalIndex] == "")
					{
						Console.WriteLine($"Animal ID {ourAnimals[i, 0]} has an invalid physical description.");
						
						bool validEntry = false;
						
						do
						{
							Console.Write($"Enter a physical description for ID # {ourAnimals[i, 0]} (min 3 characters): ");
							readResult = Console.ReadLine();
							
							if (readResult != null && readResult.Length >= 3)
							{
								ourAnimals[i, physicalIndex] = readResult.ToLower();
								validEntry = true;
							}
							else
							{
								Console.WriteLine("Please enter a valid physical description.\n");
							}
							
						} while (!validEntry);
					}
				
				}
			}
			
			Console.WriteLine("\nAge and physical description fields are complete for all of our friends.");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
			
		case "4":
			Console.Clear();
			Console.WriteLine("----- Ensure animal nicknames and personality descriptions are complete -----\n");
			
			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[i, 0] != "")
				{
					int nicknameIndex = 2;
					if (ourAnimals[i, nicknameIndex] == "tbd" || ourAnimals[i, nicknameIndex] == "")
					{
						bool validEntry = false;
						do
						{
							Console.Write($"Enter a nickname for ID # {ourAnimals[i, 0]} (min 3 characters): ");
							readResult = Console.ReadLine();
							
							if (readResult != null && readResult.Length >= 3)
							{
								ourAnimals[i, nicknameIndex] = readResult.ToLower();
								validEntry = true;
							}
							else
							{
								Console.WriteLine("Please enter a valid nickname.\n");
							}
							
						} while (!validEntry);
					}
					
					int personalityIndex = 5;
					if (ourAnimals[i, personalityIndex] == "tbd" || ourAnimals[i, personalityIndex] == "")
					{
						bool validEntry = false;
						
						do
						{
							Console.Write($"Enter a personality description for ID # {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level) (min 3 characters): ");
							readResult = Console.ReadLine();
							
							if (readResult != null && readResult.Length >= 3)
							{
								ourAnimals[i, personalityIndex] = readResult.ToLower();
								validEntry = true;
							}
							else
							{
								Console.WriteLine("Please enter a valid personality description.\n");
							}
							
						} while (!validEntry);
					}
				}
			}
			
			Console.WriteLine("\nNickname and personality description fields are complete for all of our friends.");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
			
		case "5":
			// Edit an animal’s age
			Console.WriteLine($"\nYou selected menu option {menuSelection}.");
			Console.WriteLine("this app feature is coming soon - please check back to see progress.");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
			
		case "6":
			// Edit an animal’s personality description
			Console.WriteLine($"\nYou selected menu option {menuSelection}.");
			Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
			
		case "7":
			// Display all cats with a specified characteristic
			Console.WriteLine($"\nYou selected menu option {menuSelection}.");
			Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
			
		case "8":
			// Display all dogs with a specified characteristic
			Console.WriteLine($"\nYou selected menu option {menuSelection}.");
			Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
			
		default:
			// Invalid menu selection
			Console.WriteLine("You did not select a valid menu option. Please try again.");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
	}

} while (menuSelection != "0");

Console.Clear();
Console.WriteLine("Exiting the Contoso PetFriends app.");
Thread.Sleep(1000);
Console.WriteLine("Goodbye!");
Thread.Sleep(1000);
Console.Clear();