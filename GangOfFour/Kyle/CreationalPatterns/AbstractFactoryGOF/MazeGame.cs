using GOFLibrary.Maze;
using GOFLibrary.Maze.MapSite;

// Example of creating a Maze using the Abstract Factory Pattern

namespace AbstractFactoryGOF
{
    public class MazeGame
    {
        public Maze CreateMaze (MazeFactory factory)
        {
            Maze maze = factory.MakeMaze();
            Room r1 = factory.MakeRoom(1);
            Room r2 = factory.MakeRoom(2);
            Door door = factory.MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.North, factory.MakeWall());
            r1.SetSide(Direction.East, door);
            r1.SetSide(Direction.South, factory.MakeWall());
            r1.SetSide(Direction.West, factory.MakeWall());

            r2.SetSide(Direction.North, factory.MakeWall());
            r2.SetSide(Direction.East, factory.MakeWall());
            r2.SetSide(Direction.South, factory.MakeWall());
            r2.SetSide(Direction.West, door);

            return maze;
        }
    }
}
