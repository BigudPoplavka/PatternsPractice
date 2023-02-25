using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public class Glock18 : Weapon, IFirearms, IWeapon
    {
        private Bullet GlockBullet { get; set; }
        private GlockMagazine Magazine { get; set; }
        public string Name { get; set; }

        public Glock18()
        {
            Name = "Glock 18";
            Damage = 10;
            Weight = 0.6;

            GlockBullet = new RegularBullet(Damage, 9);
            Magazine = new GlockMagazine();
            Magazine.LoadMagazine(GlockBullet);
        }

        public void Attack()
        {
            Shoot();
        }

        public void Reload()
        {
            Magazine.LoadMagazine(GlockBullet);

            Console.WriteLine("Перезарядка [   ] -> [|||]");
        }

        public void Shoot()
        {
            if (Magazine.GiveBullet())
            {
                Console.WriteLine($"Выстрел = --------------x>    Магазин: {Magazine.BulletsCount}");
            }
            else
            {
                Console.WriteLine("Магазин пуст! [   ]");
            }
        }

        public bool CanAttack()
        {
            return HasAmmo();
        }

        public bool HasAmmo()
        {
            return Magazine.BulletsCount != 0;
        }
    }
}
