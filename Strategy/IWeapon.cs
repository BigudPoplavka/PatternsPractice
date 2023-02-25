using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public interface IWeapon
    {
        public string Name { get; set; }
        bool CanAttack();
        void Attack();
    }
}
