using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternsPractice.Strategy
{
    public class Hero
    {
        private IWeapon Weapon { get; set; }
        public int MaxMagazines { get; set; }

        private List<IMagazine> _magazines;

        public Hero() 
        {
            MaxMagazines = 4;
            _magazines = new List<IMagazine>();
        }

        public void TakeWeapon(IWeapon weapon)
        {
            Weapon = weapon;

            Console.WriteLine($"Поднят предмет {Weapon.Name}");
        }

        public void Attack()
        {
            if (Weapon.GetType().GetInterfaces().Contains(typeof(IFirearms)))
            {
                if (Weapon.CanAttack())  
                    Weapon.Attack();
                else
                    Reload((IFirearms)Weapon);
            }
            else
                Weapon.Attack();
        }

        public void Reload(IFirearms firearms)
        {
            if (HasMagazine(Weapon.GetType()))
            {
                firearms.Reload();

                _magazines.Remove(_magazines.Find(x => x.WeaponType == Weapon.GetType()));
            }
            else
                Console.WriteLine($"Нет подходящих магазинов для {Weapon.Name}");
        }

        public bool HasMagazine(Type weaponType)
        {
            return _magazines.Any(x => x.WeaponType == weaponType);
        }

        public void TakeMagazine(Magazine magazine)
        {
            if(_magazines.Count != MaxMagazines)
            {
                _magazines.Add(magazine);
                Console.WriteLine($"Магазин {magazine.Description} +1");
            }
            else
            {
                Console.WriteLine("Все ячейки под магазины заполнены!");
            }
        }
    }
}
