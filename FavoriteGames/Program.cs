using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteGames
{
    class Program
    {
        static void Main(string[] args)
        {
            string gameResponse;
            string userResponse;
            List<string> favoriteGames = new List<string>(); //Stored/made in heap
            
            
            bool done=true;

            do
            {
                Console.WriteLine("Enter your favorite games");                
                gameResponse = Console.ReadLine();
                if (gameResponse != "done")
                {
                    favoriteGames.Add(gameResponse);
                    Console.WriteLine();
                    done = false;
                }
                else
                {
                    Console.WriteLine();
                    done = true;
                }                

            } while (!done);

            Console.WriteLine("Favorite games are:");
            foreach (string favoriteGame in favoriteGames)
            {                
                Console.WriteLine(favoriteGame);               
            }

            Console.WriteLine();
            Console.WriteLine("Would you Like to remove a game?[Yes/no]");
            userResponse = Console.ReadLine();
            Console.WriteLine();

            if (userResponse =="yes")
            {
                Console.WriteLine("What Game would you like to delete?");
                Console.WriteLine();
                userResponse = Console.ReadLine();
                favoriteGames.Remove(userResponse);
            }
            else
            {
                Console.WriteLine("Okay we wont remove any");
            }

            Console.WriteLine();
            Console.WriteLine("Your new list of favorite games is:");
            foreach (string favoriteGame in favoriteGames)
            {
                Console.WriteLine(favoriteGame);                
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
