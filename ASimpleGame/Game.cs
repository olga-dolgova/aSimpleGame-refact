using System.Text;

namespace ASimpleGame
{
    public class Game
    {
        public StringBuilder board;
        // StringBuilder Class represents a mutable string of characters. This class cannot be inherited.

        public Game(string s)
        {
            board = new(s);
        }

        public Game(StringBuilder s, int position, char player)
        {
            board = new();
            board.Append(s);
            board.Insert(position, player);
        }

        public int Move(char player)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == '-')
                {
                    Game game = Play(i, player);
                    if (game.Winner() == player)
                        return i;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                if (board[i] == '-')
                    return i;
            }
            return -1;
        }

        public Game Play(int i, char player)
        {
            return new(this.board, i, player);
        }

        public char Winner()
        {
            if (board[0] != '-'
                  && board[0] == board[1]
                  && board[1] == board[2])
                return board[0];
            if (board[3] != '-'
                  && board[3] == board[4]
                  && board[4] == board[5])
                return board[3];
            if (board[6] != '-'
                  && board[6] == board[7]
                  && board[7] == board[8])
                return board[6];
            return '-';
        }
    }
}
