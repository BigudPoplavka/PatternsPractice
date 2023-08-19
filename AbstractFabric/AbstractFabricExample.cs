using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.AbstractFabric
{
    public class AbstractFabricExample: IPatternExample
    {
        public void StartExample()
        {
            DailyViewFabric dailyViewFabric = new DailyViewFabric();
            QuestViewFabric questViewFabric = new QuestViewFabric();

            FactoryClient client = new FactoryClient();

            client.SetFactory(dailyViewFabric);
            client.ShowViews();

            client.SetFactory(questViewFabric);
            client.ShowViews();
        }
    }

    public class FactoryClient
    {
        private AbstractFactory _viewFactory;

        public void SetFactory(AbstractFactory factory)
        {
            _viewFactory = factory;
        }

        public void ShowViews()
        {
            _viewFactory.GetEnergyView().Show();
            _viewFactory.GetMoneyView().Show();
        }
    }
}
