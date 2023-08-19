using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.AbstractFabric
{
    public class DailyMoneyView : MoneyView
    {
        public DailyMoneyView()
        {
            _viewTitle = "Ежедневная валюта";
        }
    }
}
