using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public class AKM : Weapon, IFirearms, IWeapon
    {
        private Bullet AKBullet { get; set; }
        private AKMagazine Magazine { get; set; }
        public string Name { get; set; }

        public AKM()
        {
            Name = "AKM-74";
            Damage = 75;
            Weight = 3.6;

            AKBullet = new RegularBullet(Damage, 5.45);
            Magazine = new AKMagazine(AKBullet.GetType());
            Magazine.LoadMagazine(AKBullet);
        }

        public void Attack()
        {
            Shoot();
        }

        public void Reload()
        {
            Magazine.LoadMagazine(AKBullet);

            Console.WriteLine("Перезарядка [   ] -> [|||]");
        }

        public void Shoot()
        {
            if(Magazine.GiveBullet())
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

        public void ChangeAmmoType(Bullet bullet)
        {
            Magazine.WeaponType = bullet.GetType();
        }

        public Type GetMagazineType()
        {
            return Magazine.GetType();
        }
    }
}
