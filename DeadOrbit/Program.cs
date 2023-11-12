using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace DeadOrbit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameText gameText = new GameText();
            gameText.GameIntro();
            Console.ReadLine();

            Character Player = new Character("Johnny", 23, true, "Veteran", 2,2,2,2,2);
            Player.DiceRoller("Strength", 10);
            Console.ReadLine();
        }
    }
}