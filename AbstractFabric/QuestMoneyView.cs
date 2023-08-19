using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.AbstractFabric
{
    public class QuestMoneyView : MoneyView
    {
        public QuestMoneyView()
        {
            _viewTitle = "Квестовая валюта";
        }
    }
}
