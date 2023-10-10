using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomwWork1_Review
{
    public class Program
    {
        static List<Player> players = new List<Player>();
        static void Main(string[] args)
        {

            //list
            players.Add(new Player("Arash", 44));
            players.Add(new Player("Raul", 3));
            players.Add(new Player("John", 9));
            players.Add(new Player("Brian", 11));
            players.Add(new Player("Shelby", 25));


            //true of false
            bool continueDisplay = true;


            while (continueDisplay)
            {
                Console.WriteLine("LIST:");
                Console.WriteLine("1. Display all player names");
                Console.WriteLine("2. Display players with odd numbers");
                Console.WriteLine("3. Display players whose names start with a letter");
                Console.WriteLine("4. Add a new player");
                Console.WriteLine("5. Exit");
                //Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        DisplayPlayerNames();
                        break;
                    case "2":
                        DisplayPlayersWithOddNumbers();
                        break;
                    case "3":
                        DisplayPlayersWithLetter();
                        break;
                    case "4":
                        AddNewPlayer();
                        break;
                    case "5":
                        continueDisplay = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }


        }

        static void DisplayPlayerNames()
        {
            Console.WriteLine("All Player Names:");
            foreach (var player in players)
            {
                Console.WriteLine(player.Name);
            }
        }

        static void DisplayPlayersWithOddNumbers()
        {
            Console.WriteLine("Players with Odd Numbers:");
            foreach (var player in players)
            {
                if (player.Number % 2 != 0)
                {
                    Console.WriteLine($"{player.Name} (Number: {player.Number})");
                }
            }
        }

        static void DisplayPlayersWithLetter()
        {
            Console.Write("Enter a letter: ");
            string letter = Console.ReadLine().ToLower(); 

            Console.WriteLine($"Players with names starting with '{letter}':");
            foreach (var player in players)
            {
                if (player.Name.ToLower().StartsWith(letter))
                {
                    Console.WriteLine($"{player.Name} (Number: {player.Number})");
                }
            }
        }

        static void AddNewPlayer()
        {
            Console.Write("Enter the player's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the player's number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                players.Add(new Player(name, number));
                Console.WriteLine($"{name} (Number: {number}) has been added.");
            }
            else
            {
                Console.WriteLine("Invalid number. Player not added.");
            }



        }
        }
}
