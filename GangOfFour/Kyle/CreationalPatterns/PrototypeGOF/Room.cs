using System;

namespace PrototypeGOF
{
    public class Room : MapSite
    {
        public int RoomNum { get; private set; }
        MapSite[] _sides = new MapSite[4];

        public Room() {}

        public Room(Room other)
        {
            for(int i =0; i < other._sides.Length; i++)
            {
                //TODO: deep copy... too tired now
            }

            RoomNum = other.RoomNum;
        }

        public virtual void Initialize(int roomNo)
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
