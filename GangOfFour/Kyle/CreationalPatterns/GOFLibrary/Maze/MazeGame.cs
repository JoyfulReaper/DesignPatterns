using GOFLibrary.Maze.MapSite;

namespace GOFLibrary.Maze
{
    // The traditional/old way of doing it
    // Abstract Factroy Pattern attempts to improve on this
    // We don't want to hard code the concrete classes here.

    public class MazeGame
    {
        public Maze CreateMaze()
        {
            Maze maze = new Maze();

            Room r1 = new Room(1);
            Room r2 = new Room(2);
            Door theDoor = new Door(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.West, theDoor);

            return maze;
        }
    }
}
