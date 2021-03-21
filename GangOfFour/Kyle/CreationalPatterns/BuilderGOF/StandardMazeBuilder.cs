using GOFLibrary.Maze;
using GOFLibrary.Maze.MapSite;

namespace BuilderGOF
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze _currentMaze;

        public StandardMazeBuilder()
        {
            _currentMaze = null;
        }

        public override void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public override void BuildRoom(int roomNo)
        {
            if(_currentMaze.RoomNo(roomNo) == null)
            {
                Room room = new Room(roomNo);
                _currentMaze.AddRoom(room);

                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.West, new Wall());
            }
        }

        public override void BuildDoor(int n1, int n2)
        {
            Room r1 = _currentMaze.RoomNo(n1);
            Room r2 = _currentMaze.RoomNo(n2);
            Door d = new Door(r1, r2);

            r1.SetSide(CommonWall(r1, r2), d);
            r2.SetSide(CommonWall(r2, r1), d);
        }

        public override Maze GetMaze()
        {
            return _currentMaze;
        }

        private Direction CommonWall(Room room1, Room room2)
        {
            // It doesnt have to be good, it just has to work :p
            // We assume Rooms are just like a long hallway
            // [1][2][3][4][5][6]...

            if (room1.RoomNum % 2 == 0)
            {
                return Direction.West;
            }
            else
            {
                return Direction.East;
            }
        }
    }
}
