namespace Week3
{
    /* Namespace can have 1 or many classes
     * Functions: Group statements bundle together to do a specific task
     * ---> headings and body!
     * privacy ---> public, private, protected (Later)
     * public means you can access the function anywhere!
     * private functions are accessible only within the class itself
     * -----------------------------------------------------------------
     * accessibility (static and non-static)
     * Functions are part of classes --> You can u se classes in two separate ways
     * 1) Container to the parameters and functions which are correlated!
     * Static means you can access the function directly via class
     * 2) When you use classes as a blueprint of an object (2 weeks)
     * non-static the function is part of an instance (object) from the class and therefore
     * cannot access directly (Only by creating a new instance [object] out of class)
     * --------------------------------------------------------------------------------------
     * 
     * Create a program where a user guesses a random number. The program provides feedback
     * to the user when they did not guess the number right to guide the user accordingly 
     * to find the number (it keeps providing deedback until the user gets the answer right)
     * Count the number input and let the user know how many turns to guess the number
     * 
     * Decomposition: 
     * 1) We need a random number
     * 
     * Modify this game to make it two players
     * 1) Collect the players names
     * 2) Hint: assign a variable called turn to keep track of whose turn it is 
     * and change the turn
     * 
     * Extra : Since the player who starts the game first has disadvantage over the second player
     * 
     * Week 3 Lab, Elizabeth House 101465946
     */

    internal class Program
    {
        public static void Game() 
        {
            int randNum = new Random().Next(1, 101); // Generate 1 to 100, Since the upper bound is exclusive

            int counter = 0;
            int userInput;
            string playerOne, playerTwo;

            Console.WriteLine("Player 1, enter your name: ");
            playerOne = Console.ReadLine();
            Console.WriteLine("Player 2, enter your name: ");
            playerTwo = Console.ReadLine();
            Console.WriteLine("\n");

            bool turn = new Random().Next(0, 2) == 1;

            while (true)
            {
                if (turn == true)
                {
                    Console.WriteLine($"{playerOne}, enter a number between 1 to 100: ");
                    turn = false;
                }
                else if (turn == false)
                {
                    Console.WriteLine($"{playerTwo}, enter a number between 1 to 100: ");
                    turn = true;
                }

                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput > randNum)
                    Console.WriteLine("Guess something smaller\n");
                else if (userInput < randNum)
                    Console.WriteLine("Guess something bigger\n");

                else
                {
                    Console.WriteLine("\nYou win! The game is over!");
                    break;
                }
            }

            // computational thinking 1) pattern recognition and data representation 2) Abstract

            // With a do-while loop
            /*do
            {
                Console.WriteLine("Enter a number between 1 to 100: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                counter++;

                if (userInput > randNum)
                    Console.WriteLine("Guess a smaller number");
                else if (userInput < randNum)
                    Console.WriteLine("Guess a bigger number");
            }
            while (randNum != userInput);

            Console.WriteLine($"The game is over! It took {counter} turns to guess the number");*/

            // 3 different possibilities, randNum > userInput, randNum < userInput, randNum == userInput

            // With a while loop
            /*while (randNum != userInput)
            {
                // play the game!
                if (userInput > randNum)
                {
                    Console.WriteLine("Guess a smaller number");
                }
                else 
                {
                    Console.WriteLine("Guess a bigger number");
                }
               
            }

            Console.WriteLine($"The game is over! It took {counter} turns to guess the number");*/
        }

        

        static void Main(string[] args)
        {

            Dummy dummy = new Dummy();
            dummy.Message2();

            Console.Clear();
            Game();

            Console.WriteLine("Hello, World!");
        }
    }

    class Dummy
    {
        public static int x = 45;
        private static void Message(string message) 
        {
            Console.WriteLine("the message is " + message);
        }

        public void Message2() 
        {
            Message("Elizabeth House");
        }
    }
}
