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

using GOFLibrary.Maze.BombedMazeSite;
using GOFLibrary.Maze.MapSite;
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

            Console.WriteLine("Building the Maze using BombedMazeGame");
            mazeGame = new BombedMazeGame();
            maze = mazeGame.CreateMaze();

            Console.WriteLine("Building the Maze using EnchantedMazeGame");
            mazeGame = new EnchantedMazeGame();
            maze = mazeGame.CreateMaze();

            Console.WriteLine("Using the generic wall factory");
            var factory = new GenericCeator();
            var wall = factory.CreateWall<Wall>();
            wall = factory.CreateWall<BombedWall>();
        }
    }
}
