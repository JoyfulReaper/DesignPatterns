using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeGOF
{
    public class MazePrototypeFactory : MazeFactory
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Wall _prototypeWall;
        private Door _prototypeDoor;

        public MazePrototypeFactory(Maze maze, Wall wall, Room room, Door door)
        {
            _prototypeMaze = maze;
            _prototypeWall = wall;
            _prototypeRoom = room;
            _prototypeDoor = door;
        }

        public override Maze MakeMaze()
        {
            return _prototypeMaze.Clone();
        }

        public override Room MakeRoom(int roomNo)
        {
            Room room = _prototypeRoom.Clone();
            room.Initialize(roomNo);
            return room;
        }

        public override Wall MakeWall()
        {
            return _prototypeWall.Clone();
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            Door door = _prototypeDoor.Clone();
            door.Initialize(r1, r2);
            return door;
        }
    }
}
