﻿public class Character
{
    // Character Info 
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsOld { get; set; }
    public bool IsMale { get; set; }
    public string Background { get; set; }
    public bool IsVeteran { get; set; } 
    public bool IsSalesman { get; set; }    
    public bool IsLifter { get; set; }

    //Character Stats
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Perception { get; set; }
    public int Intelligence { get; set; }
    public int Charisma { get; set; }

    //Creating instance of Random Class for Dice Roller
    Random random = new Random();

    //Dice Roller
    public int DiceRoller(string abilityType, int passingScore)
    {
        int AbilityScore = 0;

        switch (abilityType)
        {
            case "Strength":
                AbilityScore = this.Strength;
                break;
            case "Agility":
                AbilityScore = this.Agility;
                break;
            case "Perception":
                AbilityScore = this.Perception;
                break;
            case "Intelligence":
                AbilityScore = this.Intelligence;
                break;
            case "Charisma": 
                AbilityScore = this.Charisma;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("WARNING: Invalid ability type input (Remember ability type is case sensitive");
                Console.ResetColor();
                return -1; 
        }

        int DiceRoll = random.Next(1, 21);
        int RollPlusModifier = DiceRoll + AbilityScore; 
        Console.WriteLine($"You rolled a {RollPlusModifier}!");


        if (RollPlusModifier >= passingScore)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your {abilityType} succeeded!");
            Console.ResetColor();
        } else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Your {abilityType} failed!");
            Console.ResetColor();
        }

        return RollPlusModifier;
    }

    // Character Information 

    public void CharacterInfo()
    {
        string Gender = "";
        string Background;

        if (this.IsMale = true )
        {
            Gender = "Male";
        } else
        {
            Gender = "Female";
        }

        if (this.IsVeteran == true)
        {
            Background = "Veteran";
        } else if (this.IsSalesman = true )
        {
            Background = "Salesman";
        } else if (this.IsLifter = true)
        {
            Background = "Weightlifter";
        } else
        {
            Background = "";
        }

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nName: {this.Name}\nAge: {this.Age}\nGender: {Gender}\nBackground: {Background} " +
            $"\nStrength: {this.Strength}\nAgility: {this.Agility}\nPerception: {this.Perception}\nIntelligence: " +
            $"{this.Intelligence}\nCharisma: {this.Charisma} ");
        Console.ResetColor(); 
    }



        //Constructor
        public Character(string name, int age,bool isOld, bool isMale, string background,bool isVeteran,bool 
            isSalesman,bool isLifter, int strength, int agility, int perception,
            int intelligence, int charisma)
        {
            Name = name;
            Age = age;
            IsOld = isOld;
            IsMale = isMale;
            Background = background;
            IsVeteran = isVeteran;
            IsSalesman = isSalesman;
            IsLifter = isLifter;
            Strength = strength;
            Agility = agility;
            Perception = perception;
            Intelligence = intelligence;
            Charisma = charisma;
        }
    }
