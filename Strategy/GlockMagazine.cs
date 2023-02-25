using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public class GlockMagazine: Magazine
    {
        public GlockMagazine()
        {
            _bullets = new Stack<Bullet>();

            WeaponType = typeof(Glock18);
            Capacity = 17;
            Description = " для Glock 18";
        }
    }
}
