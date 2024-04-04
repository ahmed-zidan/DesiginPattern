using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.StructuralPattern.Adapter
{
   public class Salary
    {
        public void displaySalary(List<string> salaries)
        {
            foreach(var s in salaries)
            {
                Console.WriteLine(s);
            }
        }   
    }
}
