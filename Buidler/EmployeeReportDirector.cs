using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Buidler
{
    public class EmployeeReportDirector
    {
        private readonly IReportBuilder _reportBuilder;

        public EmployeeReportDirector(IReportBuilder builder)
        {
            _reportBuilder = builder;
        }

        public void Build()
        {
            _reportBuilder.BuildHeader()
                .BuildBody()
                .BuildFooter();
        }
    }
}
