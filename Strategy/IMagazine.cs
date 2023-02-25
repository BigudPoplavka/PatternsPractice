using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public interface IMagazine
    {
        public Type WeaponType { get; set; }
        public void LoadMagazine(Bullet bullet);
        public bool GiveBullet();
    }
}
