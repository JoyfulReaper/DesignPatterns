using GOFLibrary.Maze.MapSite;
using System.Collections.Generic;
using System.Linq;

namespace GOFLibrary.Maze
{
    public class Maze
    {
        private readonly List<Room> _rooms = new List<Room>();

        public Maze()
        {

        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Room RoomNo(int roomNo)
        {
            return _rooms.Where(n => n.RoomNum == roomNo).SingleOrDefault();
        }
    }
}
