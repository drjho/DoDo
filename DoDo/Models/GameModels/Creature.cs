using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDo.Models.GameModels
{
    public class Creature : GameObject
    {
        public int Health { get; set; }

        public int Gold { get; set; } = 0;

        public int Attack { get; set; }

        public Creature(string name, int health, int attack) : base(name)
        {
            Health = health;
            Attack = attack;
        }
    }
}
