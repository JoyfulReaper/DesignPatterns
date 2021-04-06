using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class EmployeePrototypeFactory
    {
        private readonly IEmployee _employeePrototype;

        public EmployeePrototypeFactory(IEmployee employee)
        {
            _employeePrototype = employee;
        }

        public virtual IEmployee MakeEmployee()
        {
            return (IEmployee) _employeePrototype.Clone();
        }
    }
}
