using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public class ArmorPiercingBullet: Bullet
    {
        public ArmorPiercingBullet(int damage, double caliber)
        {
            Description = "Бронебойные пули";
            Damage = damage;
            Caliber = caliber;
        }
}
}
