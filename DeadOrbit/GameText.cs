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
            "enter the facility whilst I check the cargo. Report to the Overseer's Office for compensation.");
    }

	public void EnteringTheFacility()
	{
		Console.WriteLine("\nThe large hydraulic doors behind you close with a thud, sealing out the ongoing storm. " +
			"Despite this there's still a noticeable chill in the air, even with heaters running 24/7 and layers " +
			"of thermal shielding the facility is never warm on Europa. You spot a few colonists in the spaceport " +
			"who direct you towards the Overseer's Office. You recall their instructions: Keep going straight " +
			"through the spaceport till you reach landing entrance 1A, then make a left were you'll find the central " +
			"elevator which will take you over towards the Administration Center located on sub-floor 12. From here " +
			"you just go down towards the end of the hallway, make a left, a right, and then another left. " +
			"You can't miss it. ");
		Console.WriteLine("\nA left at landing entrance 1A... Or was it a right? You turn back to ask the colonist you " +
			"just spoke with another question however they've already left. A quick glance around shows no one " +
			"else available to direct you.");
		Console.WriteLine("\n\nWas it a left or a right? [Intelligence]");
		Console.WriteLine("[1] Clearly it was a left turn.\n[2]No, no, I'm pretty sure it was a right turn.");
	}

	public void ETFOption1()
	{
		Console.WriteLine("You ponder on the directions some more and then you remember the correct " +
                        "directions. You feel silly for even doubting yourself. As you navigate through " +
                        "the facility you notice the scale of the colony far exceeds that of the lowly " +
                        "populated colony. You wonder what it is that they do here on Europa for a moment.\n" +
                        "You arrive at the Overseer's Office."); 
	}

	public void ETFOption2()
	{
        Console.WriteLine("You ponder on the directions some more and then you self assuredly continue " +
                        "on your way. You make a turn, and then another turn, and then . . . you realize you " +
                        "should have gone left on your last turn so you double back but then you find yourself " +
                        "at a janitorial closet . . . Hold on, now you really know where you are because there's a " +
                        "sign . . . which is a little faded . . . But you can make out the directions . . . you " +
                        "think. ");
        Console.WriteLine("After some maze running you manage to find the central elevator and proceed to" +
            " . . . which subfloor was it again? Was it two or was it twelve? You decide the simplest " +
            "way to find out is to go to both. You hit sub floor 2 and navigate to what you believe " +
            "to be the Overseer's Office. With the uptmost confidence you open the door to find " +
            "two lovers entertwined.");
        RedText("Lover One:\nWha???");
        RedText("Lover Two: \nWhat are you doing here?!");

        Console.WriteLine("\n Ask for directions?\n[1]Sure, they seem like they might be able to point me " +
			"in the right direction.I'll only be a moment. \n[2] This does not feel like an appropriate time to ask...");

    }

	public void ETFNestedOpt1()
	{
        Console.WriteLine("You kindly ask the pair if they could point you in the right dir-");
        RedText("Lover's In Unison: \nGET OUT!");
        Console.WriteLine("You quickly close the" +
            "door and suddenly (irritatingly so) you perfectly recall the directions to the " +
            "Overseer's Office. You make your way there promptly.");
    }

	public void ETFNestedOpt2()
	{
        Console.WriteLine("You decided it would be wise to leave immediately. You quickly close the" +
                            "door and suddenly (irritatingly so) you perfectly recall the directions to the " +
                            "Overseer's Office. You make your way there promptly.");
    }

	public void OverseerOffice()
	{
		Console.WriteLine("\nYou arrive at the Overseer's Office, indistinguishable from all the other rooms on the " +
			"administrative floor with the exception of the nameplate which read: Shaye Ellerbe. You press on the comm's button and wait to " +
			"bet let in. After a momentary pause you hear the slide of the hydraulic doors and you walk inside. The " +
			"interior office was the definition of utilitarian, composed of nothing else aside from the desk the Overseer " +
			"sat at, a computer, and two chairs. The lighting was bright white, giving the room a sterile feeling.\n" +
			"Behind the desk the Overseer hardly acknowledged your entrance, entranced in her work. Her glasses " +
			"were opaque white circles from the reflection of her computer screen. After a pause she glances in your " +
			"direction and directs you to sit. She wraps up with whatever it was she was doing and looks to you.");
		GreenText("Overseer Ellerbe: ");
		Console.WriteLine("I apologize, I am very busy these days I hardly get a moment to break away from my work. " +
			"Thank you for your effort in bringing these supplies here to Europa, we've been in desperate need for " +
			"supplies for much time now. It's getting harder and harder to find pilots to deliver this far out in " +
			"the Outer-Rim.");
		Console.WriteLine("\n\n[1] Why is it getting harder to hire pilots? \n[2] This facility is a maze by the way ");
	}

	public void OverseerOffice2()
	{
		GreenText("Overseer Ellerbe: ");
		Console.WriteLine("Anyways, I'd hate to waste your time with small talk. Let's get onto the matter at hand.");
		Console.WriteLine("\n\n[1] Charisma: Speaking to someone as beautiful as you is never a waste of time \n " +
			"[2] Right. Let's talk payment.");
	}

	public void OverseerFlirt()
	{
        Console.WriteLine("You notice the Overseer blush behind her desk.");
        GreenText("Overseer Ellerbe: ");
        Console.WriteLine("I wish we got more pilot's around here like you. I've got your number, " +
            "you'll be the first person I call if we need more supplies. Or just to see if you'd like " +
            "to visit.");
    }
	public void OverseerReject1()
	{
        Console.WriteLine("You notice the Overseer shift in her seat uncomfortably.");
        GreenText("Overseer Ellerbe: ");
        Console.WriteLine("Let's keep things professional, shall we?");
    }

	public void OverseerReject2()
	{
        GreenText("Overseer Ellerbe: ");
        Console.WriteLine("Settle down, old timer. You're a bit old for my taste. Maybe if " +
            "you were twenty years younger.");
    }

	public void OverseerCompensation()
	{
		GreenText("Overseer Ellerbe: ");
		Console.WriteLine("Accounting for all the cargo you've brought in and our head of security has verified that " +
			"the cargo is in good condition, it looks like your total payment is $25,000 credits.\n\n The Overseer " +
			"reaches into a drawer and retrieves a standard credit safe. It's a cylindrical device capable of " +
			"holding up to a hundred thousand credits inside safely. She hands the safe over to you with a smile.");
	}


	//Constructor
	public GameText()
	{

	}
}
