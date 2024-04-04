using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.StructuralPattern.Adapter
{
    class Adapter : IAdapter
    {
        Salary salary = new Salary();
        public void showSalary(List<Employee>employees)
        {
            List<string> salaries = new List<string>();
            foreach(var emp in employees)
            {
                salaries.Add(emp.Salary.ToString());
            }
            salary.displaySalary(salaries);
        }
    }
}
