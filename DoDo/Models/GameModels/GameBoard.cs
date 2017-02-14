using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDo.Models.GameModels
{
    public class GameBoard
    {
        public int Width() => Rooms.GetLength(0);
        public int Height() => Rooms.GetLength(1);
        public Room[,] Rooms { get; set; } = new Room[10, 10];
        public List<Player> Players { get; set; } = new List<Player>();

        public GameBoard()
        {

        }

        public GameBoard(int width, int height)
        {
            Rooms = new Room[width, height];
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }

    }
}
