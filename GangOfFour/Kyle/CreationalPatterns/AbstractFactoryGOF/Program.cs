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

namespace AbstractFactoryGOF
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Traditional Gang of Four Examples: Creational Design Patterns: Abstract Factory");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;

            Console.WriteLine("Creating Maze using MazeFactory");
            MazeGame mazeGame = new MazeGame();
            var maze = mazeGame.CreateMaze(new MazeFactory());

            Console.WriteLine("Creating Maze using EnchantedMazeFactory");
            mazeGame = new MazeGame();
            maze = mazeGame.CreateMaze(new EnchantedMazeFactory());

            Console.WriteLine("Creating Maze using BombedMazeFactory");
            mazeGame = new MazeGame();
            maze = mazeGame.CreateMaze(new BombedMazeFactory());
        }
    }
}
