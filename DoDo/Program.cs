using DoDo.Models.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDo
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new GameBoard();
            var p1 = new Player("player 1");
            var p2 = new Player("Player 2");

            board.AddPlayer(p1);
            board.AddPlayer(p2);
            board.Start();
        }
    }
}
