using DoDo.Utils;
using DoDo.Visualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDo.Models.GameModels
{
    public enum Direction
    {
        Up, Down, Left, Right
    }

    public class GameBoard
    {

        public int BoardWidth => Rooms.GetLength(0);
        public int BoardHeight => Rooms.GetLength(1);
        public Room[,] Rooms { get; set; }
        public Dictionary<string, Player> Players { get; set; }

        public GameBoard() : this(10, 10)
        { }

        public GameBoard(int width, int height)
        {
            Players = new Dictionary<string, Player>();
            CreateRooms(width, height);
        }

        private void CreateRooms(int width, int height)
        {
            Rooms = new Room[width, height];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Rooms[i, j] = new Room();
                }
            }

        }

        public void AddPlayer(Player player)
        {
            Players[player.Name] = player;
            RandomSpawn(player);
        }

        public void RemovePlayer(Player player)
        {
            Players.Remove(player.Name);
        }

        public bool MovePlayer(Direction direction, Player player)
        {
            var x = player.X;
            var y = player.Y;

            switch (direction)
            {
                case Direction.Up:
                    ++y;
                    break;
                case Direction.Down:
                    --y;
                    break;
                case Direction.Left:
                    --x;
                    break;
                case Direction.Right:
                    ++x;
                    break;
            }

            if (Rooms[x, y].IsOccupied)
            {

            }
            return true;

        }

        public void RespawnPlayers()
        {
            foreach (var player in Players.Values)
            {
                if (player.IsDead)
                    RandomSpawn(player);
            }
        }

        public void RandomSpawn(Creature creature)
        {
            int x, y;
            do
            {
                x = RandomUtils.GetNum(BoardWidth);
                y = RandomUtils.GetNum(BoardHeight);
            } while (Rooms[x,y].IsOccupied);
            Rooms[x, y].Occupier = creature;
        }

        public void Start()
        {
            do
            {
                BoardGraphics.ClearDisplay();
                BoardGraphics.DrawBoard(Rooms);
                Console.ReadLine();
            } while (Players.Count > 0);
        }

        public void WaitForPlayerCommand()
        {

        }

        public void UpdatePlayerPosition()
        {

        }
    }
}
