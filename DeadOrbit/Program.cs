using System;
using System.Reflection.PortableExecutable;
// Include any other necessary namespaces

namespace DeadOrbit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameText gameText = new GameText();
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

            // Instantiate the Player 
            Character Player = new Character(playerName,20, playerAge, isOld, isMale, backgroundInput, isVeteran, isSalesman,
                isLifter, STR, AGL, PER, INTEL, CHAR);

            //Adding ability points from Background 
            
            if (isSalesman == true)
            {
                Player.Charisma += 2; 
            }

            if (isLifter == true)
            {
                Player.Strength += 2;
            }


            //Checking if Player Info is Correct 
            Player.CharacterInfo();
            Console.WriteLine("Does this information look correct? \n[1] Yes \n[2] No");
            int IntroInput = Player.ProcessPlayerInput(Console.ReadLine());
            if (IntroInput == 1)
            {
                Console.WriteLine("The game will now proceed.");
            } else if (IntroInput == 2)
            {
                Console.WriteLine("Too bad! Should've double checked what you put in.");
            } else
            {
                Console.WriteLine("Invalid Selection! Pay attention to directions better next time!");
            }

            gameText.CommandsInfo();

            //Beginning of Act One 
            gameText.GreenText("Sincere Arrington: ");
            Console.WriteLine($"Your credentials have been verified, {Player.Name}. You are cleared to dock at " +
                $"landing pad 1F.");
            gameText.Docking();
            int ActOneInput = Player.ProcessPlayerInput(Console.ReadLine());
            int CharCheck;
            if (ActOneInput == 1)
            {
                gameText.DockingOption1();
                Player.Health = 19; 
            } else if (ActOneInput == 2)
            {
                CharCheck = Player.DiceRoller("Charisma", 5);

                if (CharCheck >= 5)
                {
                    gameText.DockingOption2();
                } else
                {
                    gameText.GreenText("Sincere Arrington: ");
                    Console.WriteLine($"Sorry, {Player.Name}. We have to do things by the book.");
                    gameText.DockingOption1();
                    Player.Health = 19;
                }
            } else
            {
                Console.WriteLine("You broke the game. Please select the correct options next time.");
            }

            gameText.EnteringTheFacility();
            ActOneInput = Player.ProcessPlayerInput(Console.ReadLine());
            int IntCheck;

            if (ActOneInput == 1 || ActOneInput == 2)
            {
                IntCheck = Player.DiceRoller("Intelligence", 7);

                if (IntCheck >= 15)
                {
                    gameText.ETFOption1();
                } else
                {
                    gameText.ETFOption2();
                    int NestedInput = Player.ProcessPlayerInput(Console.ReadLine());    
                    if (NestedInput == 1)
                    {
                        gameText.ETFNestedOpt1();

                    } else if (NestedInput == 2)
                    {
                        gameText.ETFNestedOpt2();
                    } else
                    {
                        Console.WriteLine("Listen there were two correction options to choose from, why would you" +
                            "select something else? Can you read?? Game is broken now.");
                    }
                }
            } else
            {
                gameText.RedText("Congrats! You broke the game! Please learn how to follow basic directions.");
            }

            Console.WriteLine("You reached the end of your written code, Andy.");




            Console.ReadLine();





           

        }
    }
}
