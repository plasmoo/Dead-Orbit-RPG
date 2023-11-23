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
                        Console.WriteLine("INVALID SELECTION.");
                        Console.ResetColor();
                        break;
                }

            } while (backgroundInput != "V" && backgroundInput != "S" && backgroundInput != "W");






            gameText.YellowText("Dead Orbit is a dice based roleplaying game, meaning that whether or not you " +
                "succeed in an action is determined by the roll of a D20 (a twenty sided die), adding on " +
                "your ability modifiers. There are 5 Ability Modifiers: Strength, Agility, Perception " +
                "Intelligence, and Charisma. \n [Strength]: This is a measure of your ability to generate force. " +
                "Example: Breaking down doors, lifting heavy objects, etc. \n [Agility]: this is a measure of " +
                "your ability to move quickly / react to stimuli. Example: Outrunning an enemy, catching a falling " +
                "item. \n [Perception]: This is a measure of your ability to observe the world around you. Example: " +
                "Noticing a hidden door. \n [Intelligence]: This is a measure of your knowledge. Example: Knowing " +
                "how to operate technical machinery. \n [Charisma]: This is a measure of your force of personality. " +
                "It determines how well you can influence others. Example: Persuading a merchant for a discount. \n " +
                "You have 5 Ability Points to disperse across these categories, each point is added onto your roll." +
                " Choose wisely.");
           


            // Assuming Character is a class you have defined elsewhere
            Character Player = new Character(playerName, playerAge, true, "Veteran", 2, 2, 2, 2, 2);
            Player.DiceRoller("Strength", 10);

            Console.ReadLine();
        }
    }
}
