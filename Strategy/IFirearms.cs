using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Strategy
{
    public interface IFirearms
    {
        void Shoot();
        void Reload();
        bool HasAmmo();
    }
}
