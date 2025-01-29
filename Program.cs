using Mission04;

Console.WriteLine("Welcome to Tic-Tac-Toe");

List<string> choices = new List<string>();
int numPlayers = 0;
Boolean gameOver = false;
Receives r = new Receives(); //Why error
string currentPlayer = "X";
string input = "";

Console.WriteLine("How many people are playing");
numPlayers = int.Parse(Console.ReadLine());


do
{
    // print array
    r.ReceivesArray();

    Console.WriteLine($"Player {currentPlayer}, choose position (1-9).");
    input = Console.ReadLine();

    if (int.TryParse(input, out int position) && position >= 1 && position <= 9)
    {
        choices[position - 1] = currentPlayer;
        r.CheckWinner(choices); //Which variable

    }



    else
    {
        if (currentPlayer == "X")
        {
            currentPlayer = "O";
        }

        else
        {
            currentPlayer = "X";
        }
    }



} while (!gameOver);