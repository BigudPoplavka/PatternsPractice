using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.AbstractFabric
{
    public class MoneyView
    {
        protected string _viewTitle;
        protected string _buttonText;

        protected Image _icon;

        public void Show()
        {
            Console.WriteLine(_viewTitle);
        }
    }
}
