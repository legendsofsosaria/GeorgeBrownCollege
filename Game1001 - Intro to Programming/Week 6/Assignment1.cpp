/* Week 6, Assignment 1
* Elizabeth Gress
* 02/18/2023
*/

#include <iostream>
#include <ctime>
#include <cstdlib>
#include <fstream>
#include <string>

std::string playerName, userPassword1, userPassword2;
int playerTurn, computerTurn, gameState;
int rock = 1, paper = 2, scissors = 3;
int playerWins = 0, playerTies = 0, computerWins = 0;
std::fstream outputFile;
std::fstream inputFile;

void saveGame(); // I just wanted to try a prototype for fun
void runGame() //We're going to run through all the motions of the game here
{
	std::cout << "Welcome to Rock, Paper, Scissors Simulator!\n";
	std::cout << "Please enter a username (must be at least 8 characters): \n";
	std::getline(std::cin, playerName);
	if (playerName.length() < 8) //Check length
	{
		std::cout << "Invalid input. Please enter a username (must be at least 8 characters):\n";
		std::getline(std::cin, playerName);
	}

	//Check if the user exists. If the user exists, let's load their save file and check if their password matches.
	inputFile.open(playerName + ".txt", std::ios::in);
	if (inputFile.is_open())
	{
		std::cout << "Please enter the password: \n";
		std::cin >> userPassword1;
		inputFile >> userPassword2 >> playerWins >> computerWins >> playerTies; //Let's load their score and tell them what it is.

		if (userPassword1 == userPassword2)
		{
			std::cout << playerName << ", you have won " << playerWins << " games, " << "you have lost " << computerWins << " games, "
				<< "you have tied " << playerTies << " games.\n";
		}
		else
		{
			std::cout << "Incorrect password.\n";
			return;
		}
	}
	else //This person is new, let's have them enter a password to save to their save file.
	{
		std::cout << "Please enter a password: \n";
		std::cin >> userPassword2;
	}
	//Let's roll a choice for the computer
	srand(time(NULL));
	computerTurn = rand() % 3 + 1;

	bool validInput = false;

	do {
		std::cout << "Choose your move: 1 = Rock, 2 = Paper, 3 = Scissors\n";
		std::cin >> playerTurn;
		std::cin.ignore();

		if (playerTurn == 1)
		{
			std::cout << playerName << " shoots rock.\n";
			validInput = true;
		}
		else if (playerTurn == 2)
		{
			std::cout << playerName << " shoots paper.\n";
			validInput = true;
		}
		else if (playerTurn == 3)
		{
			std::cout << playerName << " shoots scissors.\n";
			validInput = true;
		}
		else
		{
			std::cout << "Invalid input.";
			validInput = false;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		}
	} while (!validInput);

	if (computerTurn == 1)
		std::cout << "Computer shoots rock.\n";
	else if (computerTurn == 2)
		std::cout << "Computer shoots paper.\n";
	else
		std::cout << "Computer shoots scissors.\n";

	if (playerTurn == computerTurn) //Check who won
	{
		std::cout << "It's a tie!\n";
		playerTies += 1;
		std::cout << playerName << ", you have won " << playerWins << " games, " << "you have lost " << computerWins << " games, "
			<< "you have tied " << playerTies << " games.\n";
	}
	else if ((playerTurn == 1 && computerTurn == 3) || (playerTurn == 2 && computerTurn == 1) || (playerTurn == 3 && computerTurn == 2))
	{
		std::cout << "Player wins!\n";
		playerWins += 1;
		std::cout << playerName << ", you have won " << playerWins << " games, " << "you have lost " << computerWins << " games, "
			<< "you have tied " << playerTies << " games.\n";
	}
	else
	{
		std::cout << "Computer wins!\n";
		computerWins += 1;
		std::cout << playerName << ", you have won " << playerWins << " games, " << "you have lost " << computerWins << " games, "
			<< "you have tied " << playerTies << " games.\n";
	}
	saveGame();
	return;
}
int main()
{
	do
	{
		runGame();
		std::cout << "Would you like to play again? Enter 1 for yes, any other key to exit. \n";
		std::cin >> gameState;
		std::cin.ignore();
	} while (gameState == 1);

	system("pause");
	return 0;
}
void saveGame()
{
	outputFile.open(playerName + ".txt", std::ios::out); //Save data to the file 

	if (outputFile.is_open())
	{
		outputFile << userPassword2 << "\t" << playerWins << "\t" << computerWins << "\t" << playerTies;
		outputFile.close();
	}
}