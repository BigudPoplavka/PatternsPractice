using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternsPractice.Buidler
{
    public class EmployeeReportBuilder: IReportBuilder
    {
        private EmployeeReport _employeeReport;

        private readonly IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new EmployeeReport();
        }

        public IReportBuilder BuildHeader()
        {
            _employeeReport.Header = $"EMPLOYEE REPORT ON DATE: {DateTime.Now}\n";
            _employeeReport.Header += "\n------------------------------------------------------\n";

            return this;
        }

        public IReportBuilder BuildBody()
        {
            _employeeReport.Body = string.Join(Environment.NewLine,
                _employees.Select(e =>
                    $"Employee: {e.Name}\t\tSalary: {e.Salary}$"));

            return this;
        }

        public IReportBuilder BuildFooter()
        {
            _employeeReport.Footer = "\n------------------------------------------------------\n";
            _employeeReport.Footer += $"TOTAL EMPLOYEES: {_employees.Count()}, " +
                $"TOTAL SALARY: {_employees.Sum(e => e.Salary)}$";

            return this;
        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;

            _employeeReport = new EmployeeReport();

            return employeeReport;
        }
    }
}
