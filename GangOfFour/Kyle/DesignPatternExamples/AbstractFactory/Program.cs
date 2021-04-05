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
 * Abstract Factory Demo from the GOF Design Patter Book (87)
 * 
 * Intent: Provide an interface for creating families of related 
 * or dependent objects without specifying their concrete classes
 * 
 * Also known as: Kit
 * 
 * Participants:
 * AnstractFactory (IAnimalFactory): Interface for operations that create abstract product objects
 * ConcreteFactory (DogFactory, CatFactory): Implement the operations to create concrete product objects
 * AbstractProduct (IAnimal): Declares an interface for a type of product object
 * ConcreteProduct (Dog, Cat): defines a product object to be created by the corresponding concrete factory, implements AbstractProduct interface
 * Client (MazeGame): Uses only interfaces declared by AbstractFactory and AbstractProduct classes
 * 
 * See Also:
 * DI vs Factory Pattern: https://stackoverflow.com/questions/557742/dependency-injection-vs-factory-pattern
 */

using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory factory = new DogFactory();

            IAnimal a1 = factory.MakeAnimal();

            factory = new CatFactory();

            IAnimal a2 = factory.MakeAnimal();

            Console.WriteLine($"a1 says: {a1.Speak()}");
            Console.WriteLine($"a2 says: {a2.Speak()}");
        }
    }
}
