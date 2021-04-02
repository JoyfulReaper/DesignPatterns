/**
Singleton Demo from the GOF Design Patter Book (117)

Intent: 
Ensure a class only has one instance and provide a global point of access to it.

Also known as:

Applicability: 
There must be only one instance of a class, and it must be accessible to clients
from a well-known acess point

Collaborations:
Clients access a Singleton instance solely through Singleton's Instance operation

Participants:
Singleton - defines an Instance operation that lets clients access its unique instance.
Instance is a class operation. May be responisble for creating its own unique instance.

See Also:
*/

using System;

namespace GOFSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Traditional Gang of Four Examples: Creational Design Patterns: Singleton");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;

            Console.WriteLine("Creating Maze using MazeFactory singleton");
            MazeGame mazeGame = new MazeGame();
            var maze = mazeGame.CreateMaze(MazeFactory.Instance());
        }
    }
}
