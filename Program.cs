using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRefreshment
{//EDNA LYNN LAXA 
 // CODE REFRESH I 
 // PROGRAMMING IV
 //SEPTEMBER 29,2023 

    //FEEDBACK: Ednalynn, You're code has gotten so clean! This is fantastic. I hope your proud of the progress you've made.
    //And this is a refresher coming back from break.
    //That's not easy. The issue you ran into with the first letter was extremely close.
    //-5 Display by first name Yours list.Name == letter It's been a while,
    //but a quick reminder, c# looks at strings as arrays. so list.Name[0] <-----
    //index 0 would always look at the first letter in a word.
    //so list.Name[0] == letter and your basically there ✅ :D Updated your code, push the changes, let me know. I'll regrade for full points. Welcome back :D
    public class Program
    {
        //THE GLOBAL LIST OF PLAYER 
        static List<Player> playerList = new List<Player>();
        static void Main(string[] args)
        {
            //ADDING 5 PLAYERS W/ NAME & NUMBER 
            Player player1 = new Player("MattRife", 32);
            Player player2 = new Player("KevinHart", 11);
            Player player3 = new Player("NateJackson", 12);
            Player player4 = new Player("PeteDavison", 3);
            Player player5 = new Player("ElonMusk", 22);

            //OFFICIALLY ADDING PLAYERS TO THE PLAYER LIST 
            playerList.Add(player1);
            playerList.Add(player2);
            playerList.Add(player3);
            playerList.Add(player4);
            playerList.Add(player5);

            // USING FOR EACH TO DISPLAY ALL PLAYERS 
            foreach (Player p in playerList)
            {
                Console.WriteLine(p);
            }
            //JUST SPACING, TO LOOK CLEAN 
            Console.WriteLine();
            Console.WriteLine();

        theMenu:;
            //THE MENU
            Console.WriteLine("THE MENU: ");
            Console.WriteLine("Players");
            Console.WriteLine("--------");
            Console.WriteLine("1. DISPLAY PLAYERS");
            Console.WriteLine("2. DISPLAY PLAYERS WITH ODD NUMBER");
            Console.WriteLine("3. DISPLAY PLAYERS STARTING WITH A LETTER");
            Console.WriteLine("4. ADD PLAYER");
            Console.WriteLine();
            Console.WriteLine("Make a selection (Enter Number ONLY)");
            //CAPTURING USER INPUT 
            string selection = Console.ReadLine();

            //USING IF CONDITION TO CORRESPOND TO USER'S INPUT. 
            if (selection == "1")
            {
                //THIS DISPLAY ALL PLAYERS. 
                Console.WriteLine("You entered: " + selection);
                Console.WriteLine();
                foreach (Player p in playerList) // ACCESSING PLAYER CLASS , WHICH PLAYS A PART IN PLAYER LIST , THE "p" represent the items in list. 
                {
                    Console.WriteLine(p); // "p" defines as the items w/in the list, this will display. 
                }
                Console.WriteLine(); // SPACING 
                goto theMenu;
            }
            else if (selection == "2") // This condition will respond when the #2 is inputted 
            {
                Console.WriteLine("You entered: " + selection); // CONFIRMING SELECTION TO USER 
                Console.WriteLine();

                foreach (Player play in playerList)
                {
                    if (play.Number % 2 != 0) // Accessing the property NUMBER in Player Class and coding in the equation for odd numbers. 
                    {
                        Console.WriteLine(play); //this should display players that has an uneven number. 
                    }

                }
                Console.WriteLine(); // Spacing for beautifulness. 
                goto theMenu;

            }
            else if (selection == "3") // This will prompt when NUMBER 3 is inputted 
            {
                Console.WriteLine("You entered: " + selection); // CONFIRMING selection 
                Console.WriteLine();
                Console.WriteLine("What letter?");
                char letter = char.Parse(Console.ReadLine()); // CAPTURING USER LETTER 

                foreach (Player list in playerList)
                {
                    if (list.Name[0] == letter)    // YAY this works now, thank you! 
                    {
                        Console.WriteLine(list);
                    }
                    else
                    {

                    }
                }
                Console.WriteLine();
                goto theMenu;
            }
            else if (selection == "4") // Will respond when #4 is inputted 
            {
                Console.WriteLine("You entered: " + selection); // CONFIMING SELECTION 
                Console.WriteLine();
                Console.WriteLine("Add name of player"); // REQUESTING FOR NAME OF PLAYER 
                string name = Console.ReadLine(); // Giving user's input a varible. 
                Console.WriteLine("Player Number?"); // REQUESTING FOR PLAYER NUMBER 
                string Num = Console.ReadLine(); // Giving user's input a variable
                int playerNum = int.Parse(Num); //Parse number into int 
                Player newPlayer = new Player(name, playerNum); //connecting the two request constructor of string & int which correlates name & number
                playerList.Add(newPlayer); //Adding new player 
                Console.WriteLine("New Player Added"); // CONFIRMING ADDITION 
                Console.WriteLine(); // Spacing 
                foreach (Player newList in playerList) // User's added person should prompt part of the list. YAY 
                {
                    Console.WriteLine(newList);
                }
                Console.WriteLine();
                goto theMenu;
            }

        }
    }
}
