using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public class RegularBullet: Bullet
    {
        public RegularBullet(int damage, double caliber)
        {
            Description = "Обыкновенные оболочечные";
            Damage = damage;
            Caliber = caliber;
        }
    }
}
