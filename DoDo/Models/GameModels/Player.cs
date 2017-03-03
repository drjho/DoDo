using System;

namespace DoDo.Models.GameModels
{
    public class Player: Creature
    {
        static int defaultPlayerHealth = 10;

        static int defaultPlayerDamage = 3;


        public Player(string name) : this(name, defaultPlayerHealth, defaultPlayerDamage)
        {
        }

        public Player(string name, int health, int attack) : base(name, health, attack)
        {
        }

        public override void ResetStats()
        {
            throw new NotImplementedException();
        }
    }
}