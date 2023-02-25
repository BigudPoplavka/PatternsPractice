using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public class Knife: Weapon, IWeapon
    {
        public string Name { get; set; }

        public Knife()
        {
            Name = "Regular Knife";
            Damage = 80;
            Weight = 0.3;
        }

        public bool CanAttack()
        {
            return true;
        }

        public void Attack()
        {
            Console.WriteLine("Удар ножом ccc|=======>");
        }
    }
}
