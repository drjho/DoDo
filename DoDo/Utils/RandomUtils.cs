using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDo.Utils
{
    public static class RandomUtils
    {
        static Random random = new Random();

        static public int GetNum(int maxValue)
        {
            return random.Next(maxValue);
        }
    }
}
