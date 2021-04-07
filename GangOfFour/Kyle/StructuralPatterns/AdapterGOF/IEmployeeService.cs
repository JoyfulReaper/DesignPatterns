using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterGOF
{
    /// <summary>
    /// Represents the IAdapter
    /// This interface will allow the client to fetch an employee using employeeId
    /// </summary>
    public interface IEmployeeService
    {
        Employee GetEmployee(int employeeId);
    }
}
