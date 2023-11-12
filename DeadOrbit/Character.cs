public class Character
{
    // Character Info 
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsMale { get; set; }
    public string Background { get; set; }

    //Character Stats
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Perception { get; set; }
    public int Intelligence { get; set; }
    public int Charisma { get; set; }

    //Creating instance of Random Class for Dice Roller
    Random random = new Random();

    //Dice Roller
    public void DiceRoller(string abilityType, int passingScore)
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
                return;
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
    }



        //Constructor
        public Character(string name, int age, bool isMale, string background, int strength, int agility, int perception,
            int intelligence, int charisma)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
            Background = background;
            Strength = strength;
            Agility = agility;
            Perception = perception;
            Intelligence = intelligence;
            Charisma = charisma;
        }
    }
