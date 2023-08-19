using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.AbstractFabric
{
    public abstract class AbstractFactory
    {
        public abstract EnergyView GetEnergyView();
        public abstract MoneyView GetMoneyView();
    }

    public class DailyViewFabric : AbstractFactory
    {
        public override EnergyView GetEnergyView()
        {
            return new DailyEnegryView();
        }

        public override MoneyView GetMoneyView()
        {
            return new DailyMoneyView();
        }
    }

    public class QuestViewFabric : AbstractFactory
    {
        public override EnergyView GetEnergyView()
        {
            return new QuestEnergyView();
        }

        public override MoneyView GetMoneyView()
        {
            return new QuestMoneyView();
        }
    }
}
