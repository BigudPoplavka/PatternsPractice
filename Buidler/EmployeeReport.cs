using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Buidler
{
    public class EmployeeReport: Report
    {
        public override string ToString()
        {
            return new StringBuilder()
                .Append(Header)
                .Append(Body)
                .Append(Footer)
                .ToString();
        }
    }
}
