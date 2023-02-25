using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public class AKMagazine: Magazine
    {
        public AKMagazine(Type bullet)
        {
            _bullets = new Stack<Bullet>();

            BulletType = bullet;
            WeaponType = typeof(AKM);
            Capacity = 30;
            Description = " для АКМ";
        }
    }
}
