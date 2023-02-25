using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Buidler
{
    public interface IReportBuilder
    {
        IReportBuilder BuildHeader();
        IReportBuilder BuildBody();
        IReportBuilder BuildFooter();

        EmployeeReport GetReport();
    }
}
