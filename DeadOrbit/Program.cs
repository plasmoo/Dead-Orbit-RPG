using System;
// Include any other necessary namespaces

namespace DeadOrbit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate GameText Class
            GameText gameText = new GameText();
           
            //Set up intro to game
            gameText.GameIntro();

            //Getting player name
            gameText.YellowText("What is your name?");
            string playerName = Console.ReadLine();

            //Getting player age 
            int playerAge;
            bool isValidInput;

            do
            {
                gameText.YellowText("What is your age?");
                string input = Console.ReadLine();

                isValidInput = int.TryParse(input, out playerAge);

                if (!isValidInput)
                {
                    gameText.RedText("Invalid selection!");
                }


            } while (!isValidInput);
            
            
            bool isOld = false; 

            if (playerAge >= 50)
            {
                isOld = true;
            }

            //Selecting player gender and verification
            string genderInput;
            bool isMale = false;

           do
            {
                gameText.YellowText("Are you male or female? Please enter 'M' or 'F'");
                genderInput = Console.ReadLine().ToUpper();

                if (genderInput != "F" && genderInput != "M" )
                {
                    gameText.RedText("Invalid Selection!");
                }

            } while (genderInput != "F" && genderInput != "M");

            if (genderInput == "M") {
                isMale = true;
            }

            //Selecting player background and verification

            string backgroundInput; 
            bool isVeteran = false;
            bool isSalesman = false;
            bool isLifter = false;

            do
            {
                gameText.YellowText("What is your background? \n [Veteran]: You are a former Space Marine, having " +
                "served multiple years in the armed forces you are a force to be reckoned with in combat. " +
                " +2 to Attack Rolls \n [Salesman]: You used to sell manufacturing equipment to colonists many years" +
                " ago and were quite good at it. You've got a silver tongue. +2 to Charisma Rolls" +
                "\n [Weightlifter] Once upon a time you were a top tier competitive athlete. While " +
                "your competition days might be long past you're still stronger than the averagae joe.  +2 to " +
                "Strength Rolls.\n \n Please enter 'V', 'S', or 'W'");

                backgroundInput = Console.ReadLine().ToUpper();
                switch (backgroundInput)
                {
                    case "V":
                        isVeteran = true;
                        break;
                    case "S":
                        isSalesman = true;
                        break;
                    case "W":
                        isLifter = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Selection!");
                        Console.ResetColor();
                        break;
                }

            } while (backgroundInput != "V" && backgroundInput != "S" && backgroundInput != "W");


            // Explaining Ability Checks and distributing points
            int STR, AGL, PER, INTEL, CHAR;
            bool isInputValid;
            int totalPoints;

            do
            {
                totalPoints = 0;
                gameText.AbilityCheckInfo();

                gameText.YellowText("\n\nSelect your Strength score:");
                isInputValid = int.TryParse(Console.ReadLine(), out STR);
                totalPoints += isInputValid ? STR : 0;

                gameText.YellowText("\nSelect your Agility score:");
                isInputValid = int.TryParse(Console.ReadLine(), out AGL);
                totalPoints += isInputValid ? AGL : 0;

                gameText.YellowText("\nSelect your Perception score:");
                isInputValid = int.TryParse(Console.ReadLine(), out PER);
                totalPoints += isInputValid ? PER : 0;

                gameText.YellowText("\nSelect your Intelligence score:");
                isInputValid = int.TryParse(Console.ReadLine(), out INTEL);
                totalPoints += isInputValid ? INTEL : 0;

                gameText.YellowText("\nSelect your Charisma score:");
                isInputValid = int.TryParse(Console.ReadLine(), out CHAR);
                totalPoints += isInputValid ? CHAR : 0;

                if (!isInputValid)
                {
                    gameText.RedText("Invalid input! Please enter numeric values.");
                    STR = AGL = PER = INTEL = CHAR = 0;
                }
                else if (totalPoints > 5)
                {
                    gameText.RedText("Nice try, cheater! You only get 5 points to distribute, or less if you want" +
                        " to make the game harder on yourself. BUT NO MORE THAN 5! Try AGAIN! \n ");
                    STR = AGL = PER = INTEL = CHAR = 0;
                }

            } while (totalPoints > 5 || !isInputValid);

            Console.WriteLine(STR);
            Console.WriteLine(AGL);
            Console.WriteLine(PER);
            Console.WriteLine(INTEL);
            Console.WriteLine(CHAR);




            // Assuming Character is a class you have defined elsewhere
            Character Player = new Character(playerName, playerAge, true, "Veteran", 2, 2, 2, 2, 2);
            Player.DiceRoller("Strength", 10);

            Console.ReadLine();
        }
    }
}
