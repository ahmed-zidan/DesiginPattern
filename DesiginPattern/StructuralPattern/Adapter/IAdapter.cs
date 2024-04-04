using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesiginPattern.StructuralPattern.Adapter
{
    public interface IAdapter
    {
        void showSalary(List<Employee> employees);
    }
}
