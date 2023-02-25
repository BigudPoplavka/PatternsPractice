using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public abstract class Bullet
    {
        public int Damage { get; set; }
        public double Caliber { get; set; }
        public string Description { get; set; }
    }
}
