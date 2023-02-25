using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public class StrategyExample : IPatternExample
    {
        public void StartExample()
        {
            Hero hero = new Hero();

            IWeapon akm74 = new AKM();
            IWeapon glock18 = new Glock18();
            IWeapon knife = new Knife();

            Magazine akMagazine = new AKMagazine(typeof(RegularBullet));
            Magazine akMagazineArmPiercing = new AKMagazine(typeof(ArmorPiercingBullet));
            Magazine glockMagazine = new GlockMagazine();

            hero.TakeWeapon(knife);

            hero.Attack();

            hero.TakeWeapon(akm74);

            hero.TakeMagazine(akMagazine);

            for(int i = 0; i < akMagazine.Capacity; i++)
                hero.Attack();

            hero.Attack();

            for (int i = 0; i < akMagazine.Capacity; i++)
                hero.Attack();

            hero.Attack();

            hero.TakeWeapon(glock18);

            hero.Attack();

            hero.TakeMagazine(glockMagazine);
            hero.TakeMagazine(glockMagazine);
            hero.TakeMagazine(glockMagazine);
            hero.TakeMagazine(glockMagazine);
            hero.TakeMagazine(akMagazineArmPiercing);

            hero.Attack();

        }
    }
}
