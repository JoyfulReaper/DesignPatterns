using GOFLibrary.Maze;
using GOFLibrary.Maze.MapSite;

// This class is a collection of Factory Methods
// This is not an abstract class, so it acts as
// BOTH the AbstractFactory and a ConcreteFactory

namespace GOFSingleton
{
    public class MazeFactory
    {
        static MazeFactory _instance = null;

        protected MazeFactory()
        {

        }

        public static MazeFactory Instance()
        {
            if(_instance == null)
            {
                _instance = new MazeFactory();
            }

            return _instance;
        }

        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Room MakeRoom(int roomNo)
        {
            return new Room(roomNo);
        }

        public virtual Door MakeDoor(Room r1, Room r2)
        {
            return new Door(r1, r2);
        }
    }
}
