namespace tictactoe;

class Player {
    public string id;
    public string marker;
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my tic tac toe game!\n");
         Console.WriteLine("Press key to continue");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("You are player 1. You will be using X\n");
        Console.WriteLine("Press key to continue");
        Console.ReadLine();
        Console.Clear();

        Player currentPlayer1 = new player1;
        player1.id = "1";
        player1.marker = "X";

        
        Player player2 = new Player();
        player2.id = "2";
        player2.marker = "O";

        Player currentPlayer = player1;
        bool gameOver = false;
        while(gameOver != true){
            Console.WriteLine("This is the board\n");
            Console.WriteLine("|1||2||3|");
            Console.WriteLine("|4||5||6|");
            Console.WriteLine("|7||8||9|\n");

          
            Console.WriteLine($"Player {currentPlayer.id}. Make a move!");
            string playerchoice = Console.ReadLine();

          

            Console.Clear();

            //switch the current player
            if(currentPlayer.id == "1"){
                currentPlayer = player2;
            }
            else if (currentPlayer.id == "2"){
                currentPlayer = player1;
            }
        }
        
    }


        static void DisplayBoard(string[][] board){
        for(int i = 0; i < board.Length; i++){
            string[] row = board[i];
            for(int x = 0; x < row.Length; x++){
                string value = row[x];
                Console.Write("|" + value + "|" );
            }
            Console.WriteLine();
        }
    }

}