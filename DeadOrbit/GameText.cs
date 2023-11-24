using System;

public class GameText
{

	public void GreenText(string name)
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(name);
		Console.ResetColor();
	}

    public void RedText(string name)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(name);
        Console.ResetColor();
    }

	public void YellowText(string message)
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine(message);
		Console.ResetColor();
	}


    public void GameIntro()
	{
		RedText("----------------\r\n|  Dead Orbit  |\r\n----------------\r\n");
		YellowText("Welcome, Pilot. Dead Orbit is a text-based roleplaying game where the world is narrated to you" +
            "through text in the console, and you'll be prompted to respond through console commands. It is set " +
            "in the year 2350 and you are a Deep Space Pilot, a talented individual entrusted to make perilous journeys" +
			" into 'Deep Space', deeply isolated regions of space subject to a wide variety of threats from " +
			"blackholes to space marauders. You are currently en-route to the Outer-Rim colony of Europa. Despite " +
			"your initial bad feelings about this job it has proven to be a quiet trip. You've been hired to " +
			"transport food and medical supplies to the colony and are in the process of entering the planet's orbit.  ");
		Console.ResetColor();

		GreenText("\nSincere Arrington:");
		Console.WriteLine("This is Sincere Arrington, Head of Security here at Europa. Please identify yourself and " +
			"forward your credentialsS."); 
	}

	public void AbilityCheckInfo()
	{
        YellowText("Dead Orbit is a dice based roleplaying game, meaning that whether or not you " +
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
	}

	public void CommandsInfo()
	{
		YellowText("Throughout the course of the game you might want to check your inventory, or other information " +
			"that you wish to know. This can be done with the following commands at any time: \n /inventory\n /health\n /info");
	}



	//Constructor
	public GameText()
	{

	}
}
