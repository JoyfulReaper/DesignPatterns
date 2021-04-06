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
 * Factory Method Demo from the GOF Design Patter Book (107)
 * 
 * Intent: Define an interface for creating an object, but let subclasses decide which class to instanties. 
 * Factory Method lets a class defer instranation to subclasses.
 * 
 * Also known as:
 * Virtual Constructor
 * 
 * Participants:
 * Product (MapSite): Defines the interface of objects the factory method creates.
 * ConcreteProduct (Room): Implements the product interface
 * Creater (MazeGame): Declares the factory method, which returns an object of type Product. Creator may also define a default implementation
 * of the factory method that returns a default ConcreteProduct object.
 * ConcereteCreator (EnchantedMazeGame): overrides the factory method to return an instance of ConcreteProduct.
 * 
 * See Also:
 */

using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Updated Gang of Four Examples: Creational Design Patterns: Factory Method");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;

            List<ISandwhich> sandwhiches = new List<ISandwhich>();

            sandwhiches.Add(new PeanutButterAndGrapeJelly());
            sandwhiches.Add(new PeanutButterAndStrawberryJelly());

            foreach (ISandwhich sandwhich in sandwhiches)
            {
                Console.WriteLine("\n" + sandwhich.GetType().Name + "--");
                foreach (IIngredient ingredient in sandwhich.Ingredients)
                {
                    Console.WriteLine(" " + ingredient.GetType().Name);
                }
            }
        }
    }
}
