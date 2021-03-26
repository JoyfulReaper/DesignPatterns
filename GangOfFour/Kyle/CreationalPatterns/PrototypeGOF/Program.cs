/**
Prototype Method Demo from the GOF Design Patter Book (117)

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
Prototype (): Declares an interface for cloning itself
ConcretePrototype ():  implements an operation for cloning itself
Client (): Create a new object by asking a prototype to clone itself.

See Also:
*/

using System;

namespace PrototypeGOF
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Traditional Gang of Four Examples: Creational Design Patterns: Prototype");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;


            Console.WriteLine("Creating Default Maze from prototypes.");
            MazeGame game = new MazeGame();
            MazePrototypeFactory simpleMazeFactory = new MazePrototypeFactory(
                new Maze(), new Wall(), new Room(), new Door()
                );

            Maze maze = game.CreateMaze(simpleMazeFactory);


            Console.WriteLine("Creating Bombed Maze from prototypes.");
            game = new MazeGame();
            MazePrototypeFactory bombedMazeFactory = new MazePrototypeFactory(
                new Maze(), new Wall(), new Room(), new Door()
                );

            maze = game.CreateMaze(bombedMazeFactory);
        }
    }
}
