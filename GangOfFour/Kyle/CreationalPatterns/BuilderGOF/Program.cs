/*
 * Builder Demo from the GOF Design Patter Book (97)
 * 
 * Intent: Seperate the construction of a complext object from its representation
 * so that the same construction process can create different representations
 * 
 * Also know as:
 * 
 * Participants:
 * Builder (MazeBuilder): Specifies an abstract interface for creating parts of a product object
 * ConcreteBuilder (StandardMazeBuilder): Constructs and assembles parts of the product by implementing the builder interface
 * Director (MazeGame): Constructs an object using the Builder interface
 * Product(Maze): Represents the complex object under construction. ConcreateBuilder builds the product's internal
 * representation and define the process by which it is assembled.
 * Includes classes that define constituent parts, including interfaces for assembling the parts into the final result.
 * 
 * See Also:
 */

using System;

namespace BuilderGOF
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Traditional Gang of Four Examples: Creational Design Patterns: Builder");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;

            Console.WriteLine("Building the Maze using StandardMazeBuilder.");
            MazeGame mazeGame = new MazeGame();
            var maze = mazeGame.CreateMaze(new StandardMazeBuilder());

            Console.WriteLine("Building the Maze using CountingMazeBuilder.");
            mazeGame = new MazeGame();
            var countingMazeBuilder = new CountingMazeBuilder();
            maze = mazeGame.CreateMaze(countingMazeBuilder);
            countingMazeBuilder.GetCounts(out int rooms, out int doors);
            Console.WriteLine($"The maze has {rooms} rooms and {doors} doors");
        }
    }
}
