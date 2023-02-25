using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public class Magazine: IMagazine
    {
        protected Stack<Bullet> _bullets;

        public Type WeaponType { get; set; }
        public Type BulletType { get; set; }
        public int BulletsCount { get => _bullets.Count; }
        public string Description { get; set; }
        public int Capacity { get; set; }

        public void LoadMagazine(Bullet bullet)
        {
            for (int i = 0; i < Capacity; i++)
                _bullets.Push(bullet);
        }

        public bool GiveBullet()
        {
            if (_bullets.Count != 0)
            {
                _bullets.Pop();
                return true;
            }
            else
                return false;
        }
    }
}
