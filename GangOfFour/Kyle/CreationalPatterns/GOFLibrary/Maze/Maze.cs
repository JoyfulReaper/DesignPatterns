using GOFLibrary.Maze.MapSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
