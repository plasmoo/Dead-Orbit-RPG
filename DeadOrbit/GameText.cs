﻿using System;

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

		GreenText("\nSincere Arrington:");
		Console.WriteLine("This is Sincere Arrington, Head of Security here at Europa. Please identify yourself and " +
			"forward your credentialsS."); 
	}

	public void PilotCredentials()
	{
		
	}




	//Constructor
	public GameText()
	{

	}
}