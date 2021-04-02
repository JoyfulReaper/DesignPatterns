using System.Collections.Generic;
using System.Linq;

namespace PrototypeGOF
{
    public class Maze
    {
        private readonly List<Room> _rooms = new List<Room>();

        public Maze() {}

        public Maze(Maze other)
        {

        }

        public virtual Maze Clone()
        {
            return new Maze(this);
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
