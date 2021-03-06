using GOFLibrary.Maze;
using GOFLibrary.Maze.MapSite;

namespace FactoryMethodGOF
{
    public class MazeGame
    {
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Room MakeRoom(int n)
        {
            return new Room(n);
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Door MakeDoor(Room r1, Room r2)
        {
            return new Door(r1, r2);
        }

        public Maze CreateMaze()
        {
            Maze maze = MakeMaze();

            Room r1 = MakeRoom(1);
            Room r2 = MakeRoom(2);
            Door door = MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.North, MakeWall());
            r1.SetSide(Direction.East, door);
            r1.SetSide(Direction.South, MakeWall());
            r1.SetSide(Direction.West, MakeWall());

            r2.SetSide(Direction.North, MakeWall());
            r2.SetSide(Direction.East, MakeWall());
            r2.SetSide(Direction.South, MakeWall());
            r2.SetSide(Direction.West, door);

            return maze;
        }
    }
}
