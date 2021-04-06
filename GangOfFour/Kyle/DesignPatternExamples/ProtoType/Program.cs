/*
MIT License
Copyright(c) 2021 Kyle Givler
https://github.com/JoyfulReaper
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

/**
Prototype Demo from the GOF Design Patter Book (117)

Intent: 
Specify the kinds of objects to create using a prototypical instance, and
create new object by copying this prototype.

Also known as:

Applicability: 
System should be independent of how its products are created, composed, and represented and:
Classes to instantiate are specified at run-time/dynamic loading
Avoid building a class hierarchy of factories that parallels the class hierarchy of products
Instances of a class can have one of only a few different combinations of state.

Collaborations:
Client asks a prototype to clone itself

Participants:
Prototype (IEmployee): Declares an interface for cloning itself
ConcretePrototype (Employee):  implements an operation for cloning itself
Client (Program): Create a new object by asking a prototype to clone itself.

See Also:
*/

using System;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Updated Gang of Four Examples: Creational Design Patterns: Prototype");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;

            IEmployee empKyle = new Employee()
            {
                FirstName = "Kyle",
                LastName = "Givler",
                Id = 1,
                PhoneNumber = "555-555-5556",
                Address = new Address()
                {
                    AddressLineOne = "123 Main St",
                    City = "New York",
                    State = "PA",
                    ZipCode = "12345"
                }
            };

            EmployeePrototypeFactory factory = new EmployeePrototypeFactory(empKyle);
            EmployeeManager employeeManager = new EmployeeManager();

            employeeManager[empKyle.FullName] = empKyle;



            IEmployee empDerek = factory.MakeEmployee();
            empDerek.Initiliaze("Derek",  "Givler", 2);
            employeeManager[empDerek.FullName] = empDerek;

            IEmployee empChris = factory.MakeEmployee();
            empChris.Initiliaze("Chris", "Givler", 3,
                new Address
                {
                    AddressLineOne = "75 Back St",
                    City = "Tyler",
                    State = "TX",
                    ZipCode = "54321"
                });
            employeeManager[empChris.FullName] = empChris;

            foreach(IEmployee emp in employeeManager)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
