using System;

namespace TictacToe {

    
    class TicTac {

        char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };


        int CheckIfWin() {
			if (board[0] == board[1] && board[1] == board[2]) {
				if (board[0] == 'X') return 1;
					return 2;
			} else if (board[3] == board[4] && board[4] == board[5]) {
				if (board[3] == 'X') return 1;
					return 2;
			} else if (board[6] == board[7] && board[7] == board[8]) {
				if (board[6] == 'X') return 1;
					return 2;
			} else if (board[0] == board[3] && board[3] == board[6]) {
				if (board[0] == 'X') return 1;
					return 2;
			} else if (board[1] == board[4] && board[4] == board[7]) {
				if (board[1] == 'X') return 1;
					return 2;
			} else if (board[2] == board[5] && board[5] == board[8]) {
				if (board[2] == 'X') return 1;
					return 2;
			} else if (board[0] == board[4] && board[4] == board[8]) {
				if (board[0] == 'X') return 1;
					return 2;
			} else if (board[2] == board[4] && board[4] == board[6]) {
				if (board[2] == 'X') return 1;
					return 2;
			} else if (board[0] == board[3] && board[3] == board[6]) {
				if (board[0] == 'X') return 1;
					return 2;
			} else
				return 0;
		}

		void Display() {
			Console.WriteLine("\n " + board[0] + " | "+ board[1] + " | " + board[2]);
			Console.WriteLine("-----------");
			Console.WriteLine(" " + board[3] + " | "+ board[4] + " | " + board[5]);
			Console.WriteLine("-----------");
			Console.WriteLine(" " + board[6] + " | " + board[7] + " | " + board[8]);
		}


		void MarkInput(int player, int box) {
			if (player == 1)
				board[box] = 'X';
			else
				board[box] = 'O'; 
        }


		public static void Main(string[] args) {
			int player1 = 1, player2 = 2;
			int index, result = 0,flag = 0;

			TicTac obj = new TicTac();
			obj.Display();

			for(int i=1; i<5; i++) {
				Console.Write("\nPlayer " + player1+" Turn: ");
				string input = Console.ReadLine();
				while(input.Length == 0) {
					Console.Write("Player " + player1 + " Turn: ");
					input = Console.ReadLine();
				}
				index = Convert.ToInt32(input);
				obj.MarkInput(player1, index);
				obj.Display();

				result = obj.CheckIfWin();
				if(result == 1) {
					Console.WriteLine("\n\n Player 1 Wins");
					flag = 1;
					break;
                } else if(result == 2) {
					Console.WriteLine("\n\n Player 2 Wins");
					flag = 1;
					break;
                }

				Console.Write("\nPlayer " + player2 + " Turn: ");
				input = Console.ReadLine();
				while (input.Length == 0) {
					Console.Write("Player " + player2 + " Turn: ");
					input = Console.ReadLine();
				}
				index = Convert.ToInt32(input);
				obj.MarkInput(player2, index);
				obj.Display();

				result = obj.CheckIfWin();

				if (result == 1) {
					Console.WriteLine("\n\n Player 1 Wins");
					flag = 1;
					break;
				} else if (result == 2) {
					Console.WriteLine("\n\n Player 2 Wins");
					flag = 1;
					break;
				}
				

			}
			if (flag == 0)
				Console.WriteLine("\n\nDraw");
		}

    }

}
