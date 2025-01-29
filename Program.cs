using Mission04;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe\n");


        string[] choices = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        bool gameOver = false;
        string currentPlayer = "X";
        string input = " ";


        do
        {
            // Prints the array
            Receives.ReceiveArray(choices);
            
            // Writes line for current player choice
            Console.WriteLine($"\nPlayer {currentPlayer}, choose position (1-9):");
            input = Console.ReadLine();

            // Pulls the position for the guess and assigns it to the array
            if (int.TryParse(input, out int position) && position >= 1 && position <= 9 && choices[position - 1] != "X" && choices[position - 1] != "O")
            {
                
                choices[position - 1] = currentPlayer;

                // Checks a winner
                if (Receives.CheckWinner(choices))
                {
                    Receives.ReceiveArray(choices);
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    gameOver = true;
                }
                // Checks for tie
                else if (Receives.IsBoardFull(choices))
                {
                    Receives.ReceiveArray(choices);
                    Console.WriteLine("The game is a tie!");
                    gameOver = true;
                }

                // Switches player
                else
                {
                    
                    currentPlayer = (currentPlayer == "X") ? "O" : "X";
                }
            }

            // Validates input is not already taken
            else
            {
                
                Console.WriteLine("Invalid input or spot already taken. Please choose a valid position (1-9).");
            }
        } while (!gameOver); // Keeps game going until finished
    }


}
