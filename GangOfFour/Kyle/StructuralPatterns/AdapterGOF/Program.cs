// Example is from here not the GOF book:
// https://executecommands.com/adapter-design-pattern-csharp-simple-usecase/

/**
Adapter Demo from the GOF Design Patter Book (139)

Intent: 
Convert the interface of a class into another interface clients expect.
Adapter lets classes word together that couldn't otherwise because of incompatible interfaces.

Also known as: Wrapper

Applicability: 
You want to use an existing class, and its interface does not match the one you need.
You want to create a reusable class that cooperates with unrelated or unforeseen classes,
that is, classes that don't necessarily have compatible interfaces.
(object Adapter): You need to use several existing subclasses, but its impractical to
adapt their interface by subclassing everyone. An object updater can adapt the interface of its parent class.

Collaborations:
Clients call operations on an Adapter instance. In turn, the adapter calls 
Adaptee operations that carry out the request.

Participants:
Target (IEmployeeService): defines the domain-specific interface that Client uses
Client (Program):  Collaborates with objects conforming to the Target interface
Adaptee (RecordServer): defines an existing interface that needs adapting
Adapter (EmployeeService): Adapts the interface of Adaptee to the target interface

See Also:
*/

using System;

namespace AdapterGOF
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Traditional Gang of Four Examples: Structural Design Patterns: Adapter");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;

            Console.WriteLine();
            Console.WriteLine("Example from: https://executecommands.com/adapter-design-pattern-csharp-simple-usecase/");

            IEmployeeService service = new EmployeeService();
            var employee = service.GetEmployee(1001);
            PrintEmployeeDetails(employee);
            employee = service.GetEmployee(1004);
            PrintEmployeeDetails(employee);
            employee = service.GetEmployee(1020);
            PrintEmployeeDetails(employee);
            employee = service.GetEmployee(1002);
            PrintEmployeeDetails(employee);
            Console.Read();
        }
        static void PrintEmployeeDetails(Employee employee)
        {
            if (employee != null)
                Console.WriteLine(employee);
            else
                Console.WriteLine("Employee not found");
        }
    }
}
