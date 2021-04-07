using System.Collections.Generic;

namespace AdapterGOF
{
    /// <summary>
    /// This class represents the Adaptee class.
    /// Assuming this is a legacy code and it maintains a list of employee and have only one
    /// functionality of return all the employees to the caller
    /// </summary>
    public class RecordServer
    {
        private List<Employee> _employees;

        public RecordServer()
        {
            InitializeEmployees();
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        private void InitializeEmployees()
        {
            _employees = new List<Employee>
        {
            new Employee { Id = 1001, FirstName = "Michael" , LastName = "Lawson", Department = "Management"},
            new Employee { Id = 1002, FirstName = "Lindsay" , LastName = "Ferguson", Department = "Developer"},
            new Employee { Id = 1003, FirstName = "Tobias" , LastName = "Funke", Department = "IT"},
            new Employee { Id = 1004, FirstName = "Byron" , LastName = "Fields", Department = "IT"},
            new Employee { Id = 1004, FirstName = "George" , LastName = "Edwards", Department = "Developer"}
        };
        }
    }
}