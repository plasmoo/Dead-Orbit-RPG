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

	//Start of Story 
	public void Docking()
	{
		Console.WriteLine("\nYou bring your ship down in the designated landing site. The ship's engine's begin to " +
			"cool down with a low hissing hum. You gather your things and make your way down to the ship's cargo " +
			"hold and walk down the landing ramp. You are immediately assailed by the sharp winds of Europa. You " +
			"see through the snow the head of security for the first time in person.\n\n " +
			"You see Sincere is dressed in all black ballistic plating, with a side arm strapped to his hip " +
			"and a datapad in hand. Despite his heavily armored appearance he greets you warmly.");
		GreenText("Sincere Arrington: ");
		Console.WriteLine("Welcome to Europa!You arrived just in time. A storm's blowing in from the northern hemisphere" +
			". If you'd attempted to land fifteen minutes later we wouldn't be having this conversation. I know it's cold " +
			"out here but I need to perform a routine inspection before I can let you enter the facility.");
		Console.WriteLine("\n\nAfter a long journey to Europa you're feeling quite exhausted, and with below freezing " +
			"winds rising by the second you do not feel particularly inclined to stick around for a lengthy cargo inspection." +
			" What do you do?");
		Console.WriteLine("\n [1] Wait through the routine inspection. \n [2] Charisma: Persuade Sincere to let you " +
			"pass early.");
	}

	public void DockingOption1()
	{
		Console.WriteLine("You allow Sincere to perform the routine inspection of the cargo hold. He finds nothing " +
			"of interest among the various food and medical supplies you've brought to Europa. However, while opening " +
			"crates for the security guard to inspect you accidently smash your finger in between two crates.");
		RedText("-1 Health");
	}

	public void DockingOption2()
	{
        GreenText("Sincere Arrington: ");
        Console.WriteLine("Well, I suppose it is getting pretty cold out here. Fine, feel free to " +
            "enter the facility whilst I check the cargo.");
    }

	public void EnteringTheFacility()
	{

	}

	//Constructor
	public GameText()
	{

	}
}
