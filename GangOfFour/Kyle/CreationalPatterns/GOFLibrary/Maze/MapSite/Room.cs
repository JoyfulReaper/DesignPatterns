using System;

namespace GOFLibrary.Maze.MapSite
{
    public class Room : MapSite
    {
        public int RoomNum { get; private set; }
        MapSite[] _sides = new MapSite[4];

        public Room(int roomNo)
        {
            RoomNum = roomNo;
        }

        public MapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            _sides[(int)direction] = mapSite;
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
