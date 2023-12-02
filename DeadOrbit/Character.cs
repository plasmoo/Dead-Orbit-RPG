public class Character
{
    // Character Info 
    public string Name { get; set; }
    public int Health {  get; set; }
    public int Age { get; set; }


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

 


    //Constructor
    public Character(string name,int health, int age, int strength, int agility, int perception,
        int intelligence, int charisma)
    {
        Name = name;
        Health = health;
        Age = age;
        Strength = strength;
        Agility = agility;
        Perception = perception;
        Intelligence = intelligence;
        Charisma = charisma;
    }




}


public class PlayerCharacter : Character
{
    //Player Specific Stats 
    public bool IsOld { get; set; }
    public string Gender { get; set; }
    public string Background { get; set; }
    public bool IsVeteran { get; set; }
    public bool IsSalesman { get; set; }
    public bool IsLifter { get; set; }


    // Character Information 

    public void CharacterInfo()
    {
       

        if (this.IsVeteran == true)
        {
            Background = "Veteran";
        }
        else if (this.IsSalesman = true)
        {
            Background = "Salesman";
        }
        else if (this.IsLifter = true)
        {
            Background = "Weightlifter";
        }
        else
        {
            Background = "";
        }

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nName: {this.Name}\nAge: {this.Age}\nGender: {this.Gender}\nBackground: {Background} " +
            $"\nStrength: {this.Strength}\nAgility: {this.Agility}\nPerception: {this.Perception}\nIntelligence: " +
            $"{this.Intelligence}\nCharisma: {this.Charisma} ");
        Console.ResetColor();
    }


    //Inventory 

    List<string> Inventory = new List<string>();

    public void CheckInventory()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        if (Inventory.Count == 0)
        {
            Console.WriteLine("\nInventory is empty.");
            return;
        }

        Console.WriteLine("\nInventory items:");
        foreach (string item in Inventory)
        {
            Console.WriteLine(item);
        }
        Console.ResetColor();
    }

    //Checking current health method 

    public void CheckHealth()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nCurrent Health: {this.Health}");
        Console.ResetColor();
    }

    public int ProcessPlayerInput(string input)
    {
        int number;
        bool validNumberEntered = false;

        do
        {
            if (int.TryParse(input, out number) && number < 4)
            {
                validNumberEntered = true;
                return number;
            }
            else
            {
                // Handling other commands
                switch (input.ToLower())
                {
                    case "/inventory":
                        this.CheckInventory();
                        break;
                    case "/health":
                        this.CheckHealth();
                        break;
                    case "/info":
                        this.CharacterInfo();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid selection!");
                        Console.ResetColor();
                        break;
                }

                // Read next input
                Console.WriteLine("Please enter a command or a numeric value:");
                input = Console.ReadLine();
            }
        } while (!validNumberEntered);

        // Return a default value for non-numeric and unhandled inputs
        return -1;
    }


    public PlayerCharacter(string name, int health, int age, int strength, int agility, int perception,
        int intelligence, int charisma, bool isOld, string gender, string background, bool 
        isVeteran, bool isSalesman, bool isLifter) : base(name, health, age, strength, agility, perception,
            intelligence, charisma)
    {
        IsOld = isOld; 
        Gender = gender; 
        Background = background; 
        IsVeteran = isVeteran; 
        IsSalesman = isSalesman;
        IsLifter = isLifter;

    }





}

