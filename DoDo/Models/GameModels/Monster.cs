using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDo.Models.GameModels
{
    public class Monster : Creature
    {
        static int defaultMonsterHealth = 10;

        static int defaultMonsterDamage = 2;
        
        public Monster(string name) : this (name, defaultMonsterHealth, defaultMonsterDamage)
        {

        }

        public Monster(string name, int health, int attack) : base(name, health, attack)
        {

        }

        public override void ResetStats()
        {
            Health = defaultMonsterHealth;
        }
    }
}
