using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.AbstractFabric
{
    public class DailyEnegryView : EnergyView
    {
        public DailyEnegryView()
        {
            _viewTitle = "Ежедневная энергия";
        }
    }
}
