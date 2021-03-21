/*
 * Abstract Factory Demo from the GOF Design Patter Book (87)
 * 
 * Intent: Provide an interface for creating families of related 
 * or dependant objects without specifing their concrete classes
 * 
 * Also know as: Kit
 * 
 * Participants:
 * AnstractFactory: Interface for operations that create abstract product objects
 * ConcreteFactory: Implement the operations to create concrete product objects
 * AbstractProduct: Declares an interface for a type of product object
 * ConcreteProduct: defines a product object to be created by the corresponding concrete factory, implements AbstractProduct interface
 * Client: Uses only interfaces declared by AbstractFactory and AbstractProduct classes
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
            Console.WriteLine("Hello World!");
        }
    }
}
