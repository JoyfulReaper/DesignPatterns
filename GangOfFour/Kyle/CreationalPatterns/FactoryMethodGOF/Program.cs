/*
 * Builder Demo from the GOF Design Patter Book (97)
 * 
 * Intent: Define an interface for creating an object, but let subclasses decide which class to instanties. 
 * Factory Method lets a class defer instranation to subclasses.
 * 
 * Also know as:
 * Virtual Constructor
 * 
 * Participants:
 * Product: Defines the interface of objects the factory method creates.
 * ConcreteProduct: Implements the product interface
 * Creater: Declares the factory method, which returns an object of type Product. Creator may also define a default implementation
 * of the factory method that returns a default ConcreteProduct object.
 * ConcereteCreator: overrides the factory method to return an instance of ConcreteProduct.
 * 
 * See Also:
 */

using System;

namespace FactoryMethodGOF
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Traditional Gang of Four Examples: Creational Design Patterns: Factory Method");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;

            Console.WriteLine("Building the Maze using MazeGame");
            MazeGame mazeGame = new MazeGame();
            var maze = mazeGame.CreateMaze();
        }
    }
}
