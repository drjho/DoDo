using DoDo.Models.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDo.Visualization
{
    public static class BoardGraphics
    {
        public static void ClearDisplay()
        {
            Console.Clear();
        }

        public static void DrawBoard(Room[,] rooms)
        {
            for (int y = 0; y < rooms.GetLength(1); y++)
            {
                var screenY = y * 2;
                for (int x = 0; x < rooms.GetLength(0); x++)
                {
                    var screenX = x * 4;
                    DrawRoom(screenX, screenY, rooms[x, y]);
                }
            }
        }

        public static void DrawRoom(int screenX, int screenY, Room room)
        {
            Console.SetCursorPosition(screenX, screenY);
            Console.Write("|");
            if (room.Gold > 0)
            {
                Console.Write(room.Gold);
            }
            else
            {
                Console.Write("  ");
            }
            Console.Write("|");
            Console.SetCursorPosition(screenX, screenY+1);
            Console.Write("|");
            if (room.IsOccupied)
            {
                Console.Write(room.Occupier.Name.Substring(0, 2));
            }
            else
            {
                Console.Write("  ");
            }
            Console.Write("|");
        }

    }
}
