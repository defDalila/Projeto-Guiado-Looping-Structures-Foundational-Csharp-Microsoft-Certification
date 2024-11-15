/*

Projeto Guiado - Desenvolver Estruturas de Ramificação Condicional e Loop em C#

*/


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

string[] labelsForAnimalData = ["ID #", "Specie", "Age", "Nickname", "Physical Description", "Personality"];
string[,] ourAnimals = new string[maxPets, 6];

#region Inicializar o array com dados de exemplo

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
	ourAnimals[i, 2] = animalAge;
	ourAnimals[i, 3] = animalNickname;
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
			
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
		case "2":
			// Add a new animal friend to the ourAnimals array
			Console.WriteLine($"\nYou selected menu option {menuSelection}.");
			Console.WriteLine("this app feature is coming soon - please check back to see progress.");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
		case "3":
			// Ensure animal ages and physical descriptions are complete
			Console.WriteLine($"\nYou selected menu option {menuSelection}.");
			Console.WriteLine("Challenge Project - please check back soon to see progress.");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
		case "4":
			// Ensure animal nicknames and personality descriptions are complete
			Console.WriteLine($"\nYou selected menu option {menuSelection}.");
			Console.WriteLine("Challenge Project - please check back soon to see progress.");
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

