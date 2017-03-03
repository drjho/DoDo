using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDo.Models.GameModels
{

    public abstract class Creature : GameObject
    {
        public int Health { get; set; }

        public int Gold { get; set; } = 0;

        public int Damage { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public Creature(string name, int health, int damage) : base(name)
        {
            Health = health;
            Damage = damage;
        }

        public void AttackedBy(Creature attacker) => Health -= attacker.Damage;

        public bool IsDead => Health < 0;

        public abstract void ResetStats();
    }
}
