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

/*
 * Builder Demo from the GOF Design Patter Book (97)
 * 
 * Intent: Separate the construction of a complex object from its representation
 * so that the same construction process can create different representations
 * 
 * Also known as:
 * 
 * Participants:
 * Builder (IPizzaBuilder): Specifies an abstract interface for creating parts of a product object
 * ConcreteBuilder (VeganPizzaBuilder, SpicyHawaiianPizzaBuilder): Constructs and assembles parts of the product by implementing the builder interface
 * Director (PizzaChef): Constructs an object using the Builder interface
 * Product(Pizza): Represents the complex object under construction. ConcreateBuilder builds the product's internal
 * representation and define the process by which it is assembled.
 * Includes classes that define constituent parts, including interfaces for assembling the parts into the final result.
 * 
 * See Also:
 */

using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Updated Gang of Four Examples: Creational Design Patterns: Builder");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;

            Console.WriteLine("Building vegan pizza");
            PizzaChef _chef = new PizzaChef();

            _chef.SetPizzaBuilder(new VeganPizzaBuilder());
            _chef.BuildPizza();

            Console.WriteLine(_chef.GetPizza());

            Console.WriteLine();
            Console.WriteLine("Building spicy Hawaiian pizza");
            _chef.SetPizzaBuilder(new SpicyHawaiianPizzaBuilder());
            _chef.BuildPizza();

            Console.WriteLine(_chef.GetPizza());
        }
    }
}
