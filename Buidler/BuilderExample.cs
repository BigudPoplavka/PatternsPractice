using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.Buidler
{
    public class BuilderExample: IPatternExample
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee { Name = "Igor", Salary = 200 },
            new Employee { Name = "Oleg", Salary = 190 },
            new Employee { Name = "Misha", Salary = 300 }
        };

        public void StartExample()
        {
            var builder = new EmployeeReportBuilder(employees);

            var director = new EmployeeReportDirector(builder);

            director.Build();

            var report = builder.GetReport();

            Console.WriteLine(report);
            Console.ReadKey();
        }
    }
}
