using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.AbstractFabric
{
    public class EnergyView
    {
        protected string _viewTitle;
        protected List<string> _buttonText;

        protected Image _icon;

        public void Show()
        {
            Console.WriteLine(_viewTitle);
        }
    }
}
