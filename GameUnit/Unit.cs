using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int movement;
        public virtual int Health { get; set; }
        public abstract float Cost { get; }

        public void Move()
        {
            Console.WriteLine($"Move {movement} units");
        }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
    }
}