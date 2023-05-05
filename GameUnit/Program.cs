using System;

namespace GameUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit[] units = new Unit[]{new MilitaryUnit(6,60,12),
                new SettlerUnit(2,30)};

            foreach (Unit unit in units)
            {
                Console.WriteLine(unit.GetType().Name);
                unit.Move();
                Console.WriteLine($"Heath = {unit.Health}\nCost = {unit.Cost}\n");
            }
        }        
    }
}

